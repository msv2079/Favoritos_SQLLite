using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Favoritos;

namespace ListLink
{
    public partial class FavoritosForm : Form
    {
        #region Eventos

        public FavoritosForm()
        {
            InitializeComponent();
        }

        private void FavoritosForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Favoritos.db"))
            {
                var logica = new FavoritosLogica();
                logica.CriarBancoDados();
            }

            this.HidePesquisaPanel();
            this.FiltroComboBox.SelectedIndex = 0;

            this.PreecherCategorias();
        }

        private void FavoritosTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FavoritosTabControl.SelectedIndex == 0 && this.IdLabel.Text == string.Empty)
            {
                this.PreecherCategorias();
            }

            if (FavoritosTabControl.SelectedIndex == 1)
            {
                this.ResetFormularioCadastro();

                this.PopularListaLinks();
            }
            else
            {
                this.ResetFormularioPesquisa();
            }
        }

        private void FavoritosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(this.FavoritosDataGridView.CurrentRow.Cells["id"].Value.ToString());

            if (e.ColumnIndex == 0)
            {
                var logica = new FavoritosLogica();
                logica.AtualizarNumeroAcessos(id);

                Process.Start(this.FavoritosDataGridView.CurrentCell.Value.ToString());
            }
            else if (e.ColumnIndex == 3)
            {
                this.EditarCadastro(id);
            }
        }

        private void EditarCadastro(int id)
        {
            var logica = new FavoritosLogica();
            var favorito = logica.BuscarFavoritoPorId(id);

            if (favorito != null)
            {
                this.PaginaCadastroTextBox.Text = favorito.Pagina;
                this.DescricaoCadastroTextBox.Text = favorito.Descricao;
                this.CategoriasComboBox.SelectedIndex = CategoriasComboBox.Items.IndexOf(favorito.Categoria);
                this.IdLabel.Text = favorito.Id.ToString();

                this.FavoritosTabControl.SelectedTab = CadastroTabPage;
                this.ExcluirButton.Enabled =
                    this.MarcarComoLidoButton.Enabled = true;
            }
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            var tipoFiltro = this.FiltroComboBox.SelectedItem.ToString();
            var valorFiltro = this.FiltroTextBox.Text;
            var incluirLinksLidos = this.IncluirLinksLidosCheckBox.Checked? 1 : 0;

            var lista = new List<FavoritosEntidade>();
            var logica = new FavoritosLogica();

            if (tipoFiltro == "Nenhum")
            {
                lista = logica.BuscarFavoritos();
            }
            else if (tipoFiltro == "Categoria")
            {
                lista = logica.BuscarFavoritosPorCategoria(valorFiltro, incluirLinksLidos);
            }
            else if (tipoFiltro == "Descrição")
            {
                lista = logica.BuscarFavoritosPorDescricao(valorFiltro, incluirLinksLidos);
            }
            else if (tipoFiltro == "Página")
            {
                lista = logica.BuscarFavoritosPorPagina(valorFiltro, incluirLinksLidos);
            }

            this.PopularListaLinks(lista);
        }

        private void FiltrosButton_Click(object sender, EventArgs e)
        {
            if (this.PesquisaPanel.Size.Height == 22)
            {
                this.ShowPesquisaPanel();
            }
            else
            {
                this.ResetFormularioPesquisa();
            }
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FiltroComboBox.SelectedItem.ToString() == "Nenhum")
            {
                this.FiltroTextBox.Text = string.Empty;
                this.FiltroTextBox.Enabled = false;
            }
            else
            {
                this.FiltroTextBox.Enabled = true;
            }
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var url = this.PaginaCadastroTextBox.Text;
                var descricao = this.DescricaoCadastroTextBox.Text;
                var categoria = this.CategoriasComboBox.Text.ToLower();

                var titulo = this.PegarTituloPagina(url);

                var logica = new FavoritosLogica();
                var retorno = logica.Cadastrar(new FavoritosEntidade
                {
                    DataCadastro = DateTime.Now,
                    DataEdicao = null,
                    UltimoAcesso = null,
                    NumeroAcessos = 0,
                    TituloPagina = titulo,
                    Pagina = url,
                    Descricao = descricao,
                    Categoria = categoria,
                    Lido = 0
                });

                MessageBox.Show(retorno);
                this.ResetFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.IdLabel.Text);
            var logica = new FavoritosLogica();
            var retorno = logica.Excluir(id);

            MessageBox.Show(retorno);
            this.ResetFormulario();
        }

        private void MarcarComoLidoButton_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.IdLabel.Text);
            var logica = new FavoritosLogica();
            var retorno = logica.MarcarComoLido(id);

            MessageBox.Show(retorno);
            this.ResetFormulario();
        }

        #endregion

        #region Metodos

        private void ResetFormulario()
        {
            this.ResetFormularioCadastro();
            this.PreecherCategorias();
        }

        private string PegarTituloPagina(string url)
        {
            try
            {
                var request = HttpWebRequest.Create(url);

                request.UseDefaultCredentials = true;

                var response = request.GetResponse();

                var regex = @"(?<=<title.*>)([\s\S]*)(?=</title>)";

                if (new List<string>(response.Headers.AllKeys).Contains("Content-Type"))
                {
                    if (response.Headers["Content-Type"].StartsWith("text/html"))
                    {
                        var web = new WebClient();
                        web.UseDefaultCredentials = true;
                        var page = web.DownloadString(url);

                        var ex = new Regex(regex, RegexOptions.IgnoreCase);

                        return ex.Match(page).Value.Trim();
                    }
                }
            }
            catch
            {
                return string.Empty;
            }

            return string.Empty;
        }

        private void PreecherCategorias()
        {
            var logica = new FavoritosLogica();
            var lista = logica.BuscarCategorias();

            if (lista != null)
            {
                this.CategoriasComboBox.DataSource = lista;
            }

            this.CategoriasComboBox.SelectedIndex = 0;
        }

        private void PopularListaLinks(List<FavoritosEntidade> lista)
        {
            this.FavoritosDataGridView.AutoGenerateColumns = false;

            this.FavoritosDataGridView.DataSource = lista;
        }

        private void PopularListaLinks()
        {
            var logica = new FavoritosLogica();
            var lista = logica.BuscarFavoritos();

            this.PopularListaLinks(lista);
        }

        private void ShowPesquisaPanel()
        {
            this.PesquisaPanel.Size = new Size(this.PesquisaPanel.Width, 78);
            this.FavoritosDataGridView.Size = new Size(this.FavoritosDataGridView.Width, 170);
        }

        private void HidePesquisaPanel()
        {
            this.PesquisaPanel.Size = new Size(this.PesquisaPanel.Width, 22);
            this.FavoritosDataGridView.Size = new Size(this.FavoritosDataGridView.Width, 225);
        }

        private void ResetFormularioCadastro()
        {
            this.FiltroComboBox.SelectedIndex = 0;
            this.PaginaCadastroTextBox.Text =
            this.DescricaoCadastroTextBox.Text =
            this.IdLabel.Text = string.Empty;

            this.ExcluirButton.Enabled =
                this.MarcarComoLidoButton.Enabled = false;
            this.CategoriasComboBox.SelectedIndex = 0;
        }

        private void ResetFormularioPesquisa()
        {
            this.HidePesquisaPanel();
            this.FiltroTextBox.Text = string.Empty;
        }

        #endregion
    }
}