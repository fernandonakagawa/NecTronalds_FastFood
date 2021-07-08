using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class Cardapio
    {
        public List<Lanche> Lanches { get; private set; }
        public Cardapio()
        {
            this.Lanches = new List<Lanche>();
        }
        public void AdicionarLanche(Lanche l)
        {
            this.Lanches.Add(l);
        }
        public void AdicionarLanche(string Nome, string Desc, float Preco)
        {
            this.AdicionarLanche(new Lanche(Nome, Desc, Preco));
        }
        public void RemoverLanche(Lanche l)
        {
            this.Lanches.Remove(l);
        }
    }
}
