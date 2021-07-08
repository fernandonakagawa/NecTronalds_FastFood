using System;
using System.Collections.Generic;
using System.Text;

namespace NecTronalds
{
    class ConsoleRestaurante
    {
        public void MostrarCardapioPais(Pais p)
        {
            Console.WriteLine($"=======Cardápio do país {p.Nome}=======");
            foreach (Lanche l in p.Cardapio.Lanches)
            {
                Console.WriteLine($"{l.Nome} {l.Desc} {l.Preco}");
            }
        }

        public void MostrarCardapioTodosPaises(RedeRestaurante rr)
        {
            foreach(Pais p in rr.Paises)
            {
                MostrarCardapioPais(p);
            }
        }

        public void MostrarRestaurantesPais(Pais p)
        {
            Console.WriteLine($"=======Restaurantes do país: {p.Nome}=======");
            foreach (Restaurante r in p.Restaurantes)
            {
                Console.WriteLine($"{r.Nome} {r.Endereco}");
            }
        }
    }
}
