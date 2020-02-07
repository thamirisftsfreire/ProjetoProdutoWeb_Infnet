using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Models
{
    public class Produto
    {

        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Fabricante { get; set; }
        public String CodigoBarras { get; set; }
        public Decimal Preco { get; set; }
        public Int32 Estoque { get; set; }
    }
}
