using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Favoritos
{
    public class FavoritosLogica : BaseDAO
    {
        public bool CriarBancoDados()
        {
            try
            {
                SQLiteConnection.CreateFile("Favoritos.db");

                var command = new SQLiteCommand("create table Favoritos(Id integer primary key autoincrement not null, DataCadastro datetime not null, DataEdicao datetime, UltimoAcesso datetime, NumeroAcessos int default 0, Pagina varchar(500) not null, TituloPagina varchar(500) not null, Descricao varchar(500) not null, Categoria varchar(255) not null, Cancelado int default 0, DataCancelamento datetime, Lido int)");

                this.ExecuteNonQuery(command);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string Cadastrar(FavoritosEntidade favorito)
        {
            try
            {
                if (string.IsNullOrEmpty(favorito.Pagina))
                {
                    throw new Exception("O campo Página deve ser informado!");
                }

                if (string.IsNullOrEmpty(favorito.Descricao))
                {
                    throw new Exception("O campo Descrição deve ser informado!");
                }

                if (string.IsNullOrEmpty(favorito.Categoria) || favorito.Categoria == "Digite aqui a Nova Categoria")
                {
                    throw new Exception("O Categoria deve ser informado!");
                }

                var idPaginaExistente = this.BuscarId(favorito.Pagina);

                if (idPaginaExistente != 0)
                {
                    favorito.Id = idPaginaExistente;
                    favorito.DataEdicao = DateTime.Now;

                    this.Editar(favorito);

                    return "Link Atualizado com sucesso!";
                }
                else
                {
                    this.Incluir(favorito);

                    return "Link Cadastrado com sucesso!";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Incluir(FavoritosEntidade favorito)
        {
            var command = new SQLiteCommand("insert into Favoritos (DataCadastro, Pagina, TituloPagina, Descricao, Categoria, Lido) VALUES(@dataCadastro, @pagina, @tituloPagina, @descricao, @categoria, 0)");
            command.Parameters.Add(new SQLiteParameter("@dataCadastro", favorito.DataCadastro));
            command.Parameters.Add(new SQLiteParameter("@pagina", favorito.Pagina));
            command.Parameters.Add(new SQLiteParameter("@tituloPagina", favorito.TituloPagina));
            command.Parameters.Add(new SQLiteParameter("@descricao", favorito.Descricao));
            command.Parameters.Add(new SQLiteParameter("@categoria", favorito.Categoria));

            this.ExecuteNonQuery(command);
        }

        public void Editar(FavoritosEntidade favorito)
        {
            var command = new SQLiteCommand("update Favoritos set Pagina = @pagina, Descricao = @descricao, Categoria = @categoria, DataEdicao = @dataEdicao where Id = @id");
            command.Parameters.Add(new SQLiteParameter("@pagina", favorito.Pagina));
            command.Parameters.Add(new SQLiteParameter("@descricao", favorito.Descricao));
            command.Parameters.Add(new SQLiteParameter("@categoria", favorito.Categoria));
            command.Parameters.Add(new SQLiteParameter("@dataEdicao", favorito.DataEdicao));
            command.Parameters.Add(new SQLiteParameter("@id", favorito.Id));

            this.ExecuteNonQuery(command);
        }

        public void AtualizarNumeroAcessos(int id)
        {
            var favorito = this.BuscarFavoritoPorId(id);

            var command = new SQLiteCommand("update Favoritos set UltimoAcesso = @ultimoAcesso, NumeroAcessos = @numeroAcessos where Id = @id");
            command.Parameters.Add(new SQLiteParameter("@ultimoAcesso", DateTime.Now));
            command.Parameters.Add(new SQLiteParameter("@numeroAcessos", favorito.NumeroAcessos + 1));
            command.Parameters.Add(new SQLiteParameter("@id", favorito.Id));

            this.ExecuteNonQuery(command);
        }

        public string MarcarComoLido(int id)
        {
            var favorito = this.BuscarFavoritoPorId(id);

            var command = new SQLiteCommand("update Favoritos set Lido = 1 where Id = @id");
            command.Parameters.Add(new SQLiteParameter("@id", favorito.Id));

            this.ExecuteNonQuery(command);

            return "Link marcado como lido!";
        }

        public string Excluir(int id)
        {
            var mensagem = string.Empty;
            var dataCancelamento = DateTime.Now;

            try
            {
                var command = new SQLiteCommand("update Favoritos set Cancelado = 1, DataCancelamento = @dataCancelamento where Id = @id");
                command.Parameters.Add(new SQLiteParameter("@dataCancelamento", dataCancelamento));
                command.Parameters.Add(new SQLiteParameter("@id", id));

                this.ExecuteNonQuery(command);

                return "Link Excluído com sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<FavoritosEntidade> BuscarFavoritos()
        {
            var command = new SQLiteCommand("select Id, DataCadastro, DataEdicao, UltimoAcesso, NumeroAcessos, Pagina, TituloPagina, Descricao, Categoria, Cancelado, DataCancelamento, Lido from Favoritos where Cancelado = 0 and Lido = 0 Order By Pagina");

            var dt = this.ExecuteDataTable(command);

            var lista = this.PreencherListaFavoritos(dt);

            return lista;
        }

        public List<string> BuscarCategorias()
        {
            var command = new SQLiteCommand("select distinct Categoria from Favoritos where Cancelado = 0 and Lido = 0 order by 1 asc");

            var dt = this.ExecuteDataTable(command);

            var lista = new List<string>();
            lista.Add("Digite aqui a Nova Categoria");

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(row["categoria"].ToString());
                }
            }

            return lista;
        }

        public List<FavoritosEntidade> BuscarFavoritosPorCategoria(string categoria, int incluirLidos)
        {
            var command = new SQLiteCommand("select Id, DataCadastro, DataEdicao, UltimoAcesso, NumeroAcessos, Pagina, TituloPagina, Descricao, Categoria, Cancelado, DataCancelamento, Lido from Favoritos where Categoria like @categoria and Cancelado = 0 and (Lido = 0 or Lido = @incluirLidos)");
            categoria = string.Format("%{0}%", categoria);
            command.Parameters.Add(new SQLiteParameter("@categoria", categoria));
            command.Parameters.Add(new SQLiteParameter("@incluirLidos", incluirLidos));

            var dt = this.ExecuteDataTable(command);

            return this.PreencherListaFavoritos(dt);
        }

        public List<FavoritosEntidade> BuscarFavoritosPorPagina(string pagina, int incluirLidos)
        {
            var command = new SQLiteCommand("select Id, DataCadastro, DataEdicao, UltimoAcesso, NumeroAcessos, Pagina, TituloPagina, Descricao, Categoria, Cancelado, DataCancelamento, Lido from Favoritos where Pagina like @pagina and Cancelado = 0 and (Lido = 0 or Lido = @incluirLidos)");
            pagina = string.Format("%{0}%", pagina);
            command.Parameters.Add(new SQLiteParameter("@pagina", pagina));
            command.Parameters.Add(new SQLiteParameter("@incluirLidos", incluirLidos));

            var dt = this.ExecuteDataTable(command);

            return this.PreencherListaFavoritos(dt);
        }

        public List<FavoritosEntidade> BuscarFavoritosPorDescricao(string descricao, int incluirLidos)
        {
            var command = new SQLiteCommand("select Id, DataCadastro, DataEdicao, UltimoAcesso, NumeroAcessos, Pagina, TituloPagina, Descricao, Categoria, Cancelado, DataCancelamento, Lido from Favoritos where Descricao like @descricao and Cancelado = 0 and (Lido = 0 or Lido = @incluirLidos)");
            descricao = string.Format("%{0}%", descricao);
            command.Parameters.Add(new SQLiteParameter("@descricao", descricao));
            command.Parameters.Add(new SQLiteParameter("@incluirLidos", incluirLidos));

            var dt = this.ExecuteDataTable(command);

            return this.PreencherListaFavoritos(dt);
        }

        public FavoritosEntidade BuscarFavoritoPorId(int id)
        {
            var command = new SQLiteCommand("select Id, DataCadastro, DataEdicao, UltimoAcesso, NumeroAcessos, Pagina, TituloPagina, Descricao, Categoria, Cancelado, DataCancelamento, Lido from Favoritos where Id = @id and Cancelado = 0 and Lido = 0");
            command.Parameters.Add(new SQLiteParameter("@id", id));

            var dt = this.ExecuteDataTable(command);

            var favorito = this.PreencherListaFavoritos(dt);

            return favorito[0];
        }

        private FavoritosEntidade PreencherFavoritos(DataRow row)
        {
            var favorito = new FavoritosEntidade
            {
                Id = int.Parse(row["Id"].ToString()),
                DataCadastro = DateTime.Parse(row["DataCadastro"].ToString()),
                NumeroAcessos = int.Parse(row["NumeroAcessos"].ToString()),
                Pagina = row["Pagina"].ToString(),
                TituloPagina = row["TituloPagina"].ToString(),
                Descricao = row["Descricao"].ToString(),
                Categoria = row["Categoria"].ToString()
            };

            DateTime dataEdicao;
            DateTime ultimoAcesso;
            DateTime dataCancelamento;

            if (DateTime.TryParse(row["DataEdicao"].ToString(), out dataEdicao))
            {
                favorito.DataEdicao = dataEdicao;
            }

            if (DateTime.TryParse(row["DataCancelamento"].ToString(), out dataCancelamento))
            {
                favorito.DataEdicao = dataCancelamento;
            }


            if (DateTime.TryParse(row["UltimoAcesso"].ToString(), out ultimoAcesso))
            {
                favorito.UltimoAcesso = ultimoAcesso;
            }

            return favorito;
        }

        private List<FavoritosEntidade> PreencherListaFavoritos(DataTable dt)
        {
            var lista = new List<FavoritosEntidade>();

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var favorito = this.PreencherFavoritos(row);

                    lista.Add(favorito);
                }

                return lista;
            }

            return null;
        }

        private int BuscarId(string pagina)
        {
            var command = new SQLiteCommand("select Id, Pagina from Favoritos where Pagina = @pagina and Cancelado = 0");
            command.Parameters.Add(new SQLiteParameter("@pagina", pagina));

            var dt = this.ExecuteDataTable(command);

            if (dt.Rows.Count != 0)
            {
                return int.Parse(dt.Rows[0]["Id"].ToString());
            }

            return 0;
        }
    }
}