using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class Pais
    {
        public string Nome { get; private set; }
        public List<Pais> Restaurantes { get; private set; }

        public Pais(string Nome)
        {
            this.Nome = Nome;
            this.Restaurantes = new List<Pais>();
        }
    }
}
