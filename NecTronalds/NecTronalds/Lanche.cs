using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class Lanche
    {
        public string Nome { get; set; }
        public string Desc { get; set; }
        public float Preco { get; set; }

        public Lanche(string Nome, string Desc, float Preco)
        {
            this.Nome = Nome;
            this.Desc = Desc;
            this.Preco = Preco;
        }
    }
}
