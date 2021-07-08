using System;

namespace NecTronalds
{
    class Program
    {
        static void Main(string[] args)
        {
            RedeRestaurante rr = new RedeRestaurante("NecTronalds");
            ConsoleRestaurante console = new ConsoleRestaurante();
            Pais p1 = new Pais("Brasil");
            Lanche l1 = new Lanche("NecBacon", "Lanche de Bacon", 15.50M);
            Lanche l2 = new Lanche("NecPicanha", "Lanche de Picanha", 25.90M);
            Lanche l3 = new Lanche("NecAcarajé", "Lanche de Acarajé", 23.90M);
            p1.Cardapio.AdicionarLanche(l1);
            p1.Cardapio.AdicionarLanche(l2);
            p1.Cardapio.AdicionarLanche(l3);
            Restaurante r1 = new Restaurante("Loja Catuai", "Rod. Celso Garcia");
            Restaurante r2 = new Restaurante("Loja Centro", "Rua Belém");
            p1.Restaurantes.Add(r1);
            p1.Restaurantes.Add(r2);
            rr.Paises.Add(p1);
            //console.MostrarCardapioPais(p1);

            Pais p2 = new Pais("Argentina");
            Lanche l4 = new Lanche("NecChimichurri", "Lanche de Chimichurri", 13.30M);
            Lanche l5 = new Lanche("NecPicanha", "Lanche de Picanha", 15.90M);
            Lanche l6 = new Lanche("NecBacon", "Lanche de Bacon", 12.50M);
            p2.Cardapio.AdicionarLanche(l4);
            p2.Cardapio.AdicionarLanche(l5);
            p2.Cardapio.AdicionarLanche(l6);
            Restaurante r3 = new Restaurante("Loja Hermanos", "Rua Hermanito");
            Restaurante r4 = new Restaurante("Loja Maradona", "Rua del Maradona");
            p2.Restaurantes.Add(r3);
            p2.Restaurantes.Add(r4);
            p2.Cardapio.RemoverLanche(l6);
            rr.Paises.Add(p2);
            //console.MostrarCardapioPais(p2);

            //console.MostrarCardapioTodosPaises(rr);

            console.MostrarRestaurantesPais(p1);

        }


    }
}
