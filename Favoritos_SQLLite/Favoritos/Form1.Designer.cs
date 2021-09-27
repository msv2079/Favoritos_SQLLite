namespace ListLink
{
    partial class FavoritosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritosForm));
            this.FavoritosTabControl = new System.Windows.Forms.TabControl();
            this.CadastroTabPage = new System.Windows.Forms.TabPage();
            this.MarcarComoLidoButton = new System.Windows.Forms.Button();
            this.CategoriasComboBox = new System.Windows.Forms.ComboBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DescricaoCadastroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaginaCadastroTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FavoritosDataGridView = new System.Windows.Forms.DataGridView();
            this.Pagina = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TituloPagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesquisaPanel = new System.Windows.Forms.Panel();
            this.FiltrosButton = new System.Windows.Forms.Button();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkEntidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncluirLinksLidosCheckBox = new System.Windows.Forms.CheckBox();
            this.FavoritosTabControl.SuspendLayout();
            this.CadastroTabPage.SuspendLayout();
            this.PesquisarTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritosDataGridView)).BeginInit();
            this.PesquisaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkEntidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FavoritosTabControl
            // 
            this.FavoritosTabControl.Controls.Add(this.CadastroTabPage);
            this.FavoritosTabControl.Controls.Add(this.PesquisarTabPage);
            this.FavoritosTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavoritosTabControl.Location = new System.Drawing.Point(0, 0);
            this.FavoritosTabControl.Name = "FavoritosTabControl";
            this.FavoritosTabControl.SelectedIndex = 0;
            this.FavoritosTabControl.Size = new System.Drawing.Size(963, 280);
            this.FavoritosTabControl.TabIndex = 18;
            this.FavoritosTabControl.SelectedIndexChanged += new System.EventHandler(this.FavoritosTabControl_SelectedIndexChanged);
            // 
            // CadastroTabPage
            // 
            this.CadastroTabPage.BackColor = System.Drawing.Color.Transparent;
            this.CadastroTabPage.Controls.Add(this.MarcarComoLidoButton);
            this.CadastroTabPage.Controls.Add(this.CategoriasComboBox);
            this.CadastroTabPage.Controls.Add(this.IdLabel);
            this.CadastroTabPage.Controls.Add(this.ExcluirButton);
            this.CadastroTabPage.Controls.Add(this.CadastrarButton);
            this.CadastroTabPage.Controls.Add(this.label3);
            this.CadastroTabPage.Controls.Add(this.DescricaoCadastroTextBox);
            this.CadastroTabPage.Controls.Add(this.label2);
            this.CadastroTabPage.Controls.Add(this.label1);
            this.CadastroTabPage.Controls.Add(this.PaginaCadastroTextBox);
            this.CadastroTabPage.Location = new System.Drawing.Point(4, 22);
            this.CadastroTabPage.Name = "CadastroTabPage";
            this.CadastroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CadastroTabPage.Size = new System.Drawing.Size(955, 254);
            this.CadastroTabPage.TabIndex = 0;
            this.CadastroTabPage.Text = "Cadastro";
            // 
            // MarcarComoLidoButton
            // 
            this.MarcarComoLidoButton.Enabled = false;
            this.MarcarComoLidoButton.Location = new System.Drawing.Point(130, 163);
            this.MarcarComoLidoButton.Name = "MarcarComoLidoButton";
            this.MarcarComoLidoButton.Size = new System.Drawing.Size(112, 44);
            this.MarcarComoLidoButton.TabIndex = 27;
            this.MarcarComoLidoButton.Text = "Marcar Como Lido";
            this.MarcarComoLidoButton.UseVisualStyleBackColor = true;
            this.MarcarComoLidoButton.Click += new System.EventHandler(this.MarcarComoLidoButton_Click);
            // 
            // CategoriasComboBox
            // 
            this.CategoriasComboBox.FormattingEnabled = true;
            this.CategoriasComboBox.Location = new System.Drawing.Point(25, 96);
            this.CategoriasComboBox.Name = "CategoriasComboBox";
            this.CategoriasComboBox.Size = new System.Drawing.Size(458, 21);
            this.CategoriasComboBox.TabIndex = 2;
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(340, 163);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(86, 44);
            this.IdLabel.TabIndex = 26;
            this.IdLabel.Visible = false;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Enabled = false;
            this.ExcluirButton.Location = new System.Drawing.Point(248, 163);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(86, 44);
            this.ExcluirButton.TabIndex = 25;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Location = new System.Drawing.Point(38, 163);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(86, 44);
            this.CadastrarButton.TabIndex = 4;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = true;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Categorias:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescricaoCadastroTextBox
            // 
            this.DescricaoCadastroTextBox.Location = new System.Drawing.Point(510, 29);
            this.DescricaoCadastroTextBox.Multiline = true;
            this.DescricaoCadastroTextBox.Name = "DescricaoCadastroTextBox";
            this.DescricaoCadastroTextBox.Size = new System.Drawing.Size(422, 203);
            this.DescricaoCadastroTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(507, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Página:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaginaCadastroTextBox
            // 
            this.PaginaCadastroTextBox.Location = new System.Drawing.Point(25, 29);
            this.PaginaCadastroTextBox.Name = "PaginaCadastroTextBox";
            this.PaginaCadastroTextBox.Size = new System.Drawing.Size(458, 20);
            this.PaginaCadastroTextBox.TabIndex = 1;
            // 
            // PesquisarTabPage
            // 
            this.PesquisarTabPage.BackColor = System.Drawing.Color.Transparent;
            this.PesquisarTabPage.Controls.Add(this.panel1);
            this.PesquisarTabPage.Controls.Add(this.PesquisaPanel);
            this.PesquisarTabPage.Location = new System.Drawing.Point(4, 22);
            this.PesquisarTabPage.Name = "PesquisarTabPage";
            this.PesquisarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PesquisarTabPage.Size = new System.Drawing.Size(955, 254);
            this.PesquisarTabPage.TabIndex = 1;
            this.PesquisarTabPage.Text = "Pesquisa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FavoritosDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 170);
            this.panel1.TabIndex = 8;
            // 
            // FavoritosDataGridView
            // 
            this.FavoritosDataGridView.AllowUserToAddRows = false;
            this.FavoritosDataGridView.AllowUserToDeleteRows = false;
            this.FavoritosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FavoritosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagina,
            this.TituloPagina,
            this.Categoria,
            this.Edit,
            this.Id});
            this.FavoritosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavoritosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FavoritosDataGridView.Name = "FavoritosDataGridView";
            this.FavoritosDataGridView.ReadOnly = true;
            this.FavoritosDataGridView.Size = new System.Drawing.Size(949, 170);
            this.FavoritosDataGridView.TabIndex = 1;
            this.FavoritosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FavoritosDataGridView_CellContentClick);
            // 
            // Pagina
            // 
            this.Pagina.DataPropertyName = "Pagina";
            this.Pagina.HeaderText = "Pagina";
            this.Pagina.Name = "Pagina";
            this.Pagina.ReadOnly = true;
            this.Pagina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pagina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Pagina.Width = 350;
            // 
            // TituloPagina
            // 
            this.TituloPagina.DataPropertyName = "TituloPagina";
            this.TituloPagina.HeaderText = "TituloPagina";
            this.TituloPagina.Name = "TituloPagina";
            this.TituloPagina.ReadOnly = true;
            this.TituloPagina.Width = 230;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 250;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Editar";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PesquisaPanel
            // 
            this.PesquisaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PesquisaPanel.Controls.Add(this.IncluirLinksLidosCheckBox);
            this.PesquisaPanel.Controls.Add(this.FiltrosButton);
            this.PesquisaPanel.Controls.Add(this.FiltroComboBox);
            this.PesquisaPanel.Controls.Add(this.FiltrarButton);
            this.PesquisaPanel.Controls.Add(this.FiltroTextBox);
            this.PesquisaPanel.Controls.Add(this.label5);
            this.PesquisaPanel.Controls.Add(this.label4);
            this.PesquisaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PesquisaPanel.Location = new System.Drawing.Point(3, 3);
            this.PesquisaPanel.Name = "PesquisaPanel";
            this.PesquisaPanel.Size = new System.Drawing.Size(949, 78);
            this.PesquisaPanel.TabIndex = 7;
            // 
            // FiltrosButton
            // 
            this.FiltrosButton.BackColor = System.Drawing.Color.Silver;
            this.FiltrosButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FiltrosButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FiltrosButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FiltrosButton.Location = new System.Drawing.Point(0, 55);
            this.FiltrosButton.Name = "FiltrosButton";
            this.FiltrosButton.Size = new System.Drawing.Size(949, 23);
            this.FiltrosButton.TabIndex = 13;
            this.FiltrosButton.Text = "Filtros";
            this.FiltrosButton.UseVisualStyleBackColor = false;
            this.FiltrosButton.Click += new System.EventHandler(this.FiltrosButton_Click);
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Nenhum",
            "Categoria",
            "Descrição",
            "Página"});
            this.FiltroComboBox.Location = new System.Drawing.Point(24, 28);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(149, 21);
            this.FiltroComboBox.TabIndex = 1;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(630, 26);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 3;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Enabled = false;
            this.FiltroTextBox.Location = new System.Drawing.Point(195, 28);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(416, 20);
            this.FiltroTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Parâmetro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo";
            // 
            // linkEntidadeBindingSource
            // 
            this.linkEntidadeBindingSource.DataSource = typeof(Favoritos.FavoritosEntidade);
            // 
            // IncluirLinksLidosCheckBox
            // 
            this.IncluirLinksLidosCheckBox.AutoSize = true;
            this.IncluirLinksLidosCheckBox.Location = new System.Drawing.Point(751, 30);
            this.IncluirLinksLidosCheckBox.Name = "IncluirLinksLidosCheckBox";
            this.IncluirLinksLidosCheckBox.Size = new System.Drawing.Size(110, 17);
            this.IncluirLinksLidosCheckBox.TabIndex = 16;
            this.IncluirLinksLidosCheckBox.Text = "Incluir Links Lidos";
            this.IncluirLinksLidosCheckBox.UseVisualStyleBackColor = true;
            // 
            // FavoritosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 280);
            this.Controls.Add(this.FavoritosTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavoritosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus Favoritos";
            this.Load += new System.EventHandler(this.FavoritosForm_Load);
            this.FavoritosTabControl.ResumeLayout(false);
            this.CadastroTabPage.ResumeLayout(false);
            this.CadastroTabPage.PerformLayout();
            this.PesquisarTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FavoritosDataGridView)).EndInit();
            this.PesquisaPanel.ResumeLayout(false);
            this.PesquisaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkEntidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FavoritosTabControl;
        private System.Windows.Forms.TabPage CadastroTabPage;
        private System.Windows.Forms.TabPage PesquisarTabPage;
        private System.Windows.Forms.Panel PesquisaPanel;
        private System.Windows.Forms.Button FiltrosButton;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.BindingSource linkEntityBindingSource;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource linkEntidadeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView FavoritosDataGridView;
        private System.Windows.Forms.ComboBox CategoriasComboBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescricaoCadastroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaginaCadastroTextBox;
        private System.Windows.Forms.DataGridViewLinkColumn Pagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloPagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button MarcarComoLidoButton;
        private System.Windows.Forms.CheckBox IncluirLinksLidosCheckBox;


    }
}

