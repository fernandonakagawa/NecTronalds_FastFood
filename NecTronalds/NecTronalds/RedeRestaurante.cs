using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class RedeRestaurante
    {
        public string Nome { get; private set; }
        public List<Pais> Paises { get; private set; }

        public RedeRestaurante(string Nome)
        {
            this.Nome = Nome;
            this.Paises = new List<Pais>();
        }
    }
}
