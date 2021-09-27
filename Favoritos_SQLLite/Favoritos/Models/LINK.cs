using System;
using System.Collections.Generic;

namespace Favoritos.Models
{
    public partial class LINK
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string DESCRICAO { get; set; }
        public string CATEGORIA { get; set; }
    }
}
