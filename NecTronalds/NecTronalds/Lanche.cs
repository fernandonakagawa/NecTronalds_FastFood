using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class Lanche
    {
        public string Nome { get; set; }
        public string Desc { get; set; }
        public decimal Preco { get; set; }

        public Lanche(string Nome, string Desc, decimal Preco)
        {
            this.Nome = Nome;
            this.Desc = Desc;
            this.Preco = Preco;
        }
    }
}
