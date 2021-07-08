using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class Pais
    {
        public string Nome { get; private set; }
        public List<Restaurante> Restaurantes { get; private set; }
        public Cardapio Cardapio { get; private set; }

        public Pais(string Nome)
        {
            this.Nome = Nome;
            this.Restaurantes = new List<Restaurante>();
            this.Cardapio = new Cardapio();
        }
    }
}
