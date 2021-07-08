using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class Restaurante
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Cardapio Cardapio { get; set; }

        public Restaurante(string Nome, string Endereco)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Cardapio = new Cardapio();
        }
    }
}
