using System;

namespace Favoritos
{
    public class FavoritosEntidade
    {
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataEdicao { get; set; }

        public DateTime? UltimoAcesso { get; set; }

        public int NumeroAcessos { get; set; }

        public string Pagina { get; set; }

        public string TituloPagina { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

        public int Cancelado { get; set; }

        public DateTime? DataCancelamento { get; set; }

        public int Lido { get; set; }
    }
}