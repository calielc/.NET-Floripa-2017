using System;

namespace PatternMatching
{
    abstract class Bebida
    {
        public string Nome { get; set; }
        public decimal TeorAlcoolico { get; set; }
    }

    class Vinho : Bebida
    {
        public Cores Cor { get; set; }

        public enum Cores { Tinto, Branco, Rose };
    }

    class Cerveja : Bebida
    {
        public decimal IBU { get; set; }
    }


    class PatternMatching
    {
        static void Main(string[] args)
        {
            var bebidas = new object[] {
                new Vinho { Nome = "Sangue de Boi", Cor = Vinho.Cores.Tinto, TeorAlcoolico = 10 },
                new Cerveja { Nome = "Heineken", TeorAlcoolico = 5, IBU = 23 },
                null,
                1,
                new Cerveja { Nome = "Coice", TeorAlcoolico = 11.5m, IBU = 69 }
            };

            {
                var bebida = bebidas[0];
                if (bebida is null)
                {
                    Console.WriteLine($"bebida é nula");
                }
                else
                {
                    Console.WriteLine($"bebida NÃO é nula");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            {
                var bebida = bebidas[1];
                if (bebida is Cerveja cerveja)
                {
                    Console.WriteLine($"nome: {cerveja.Nome}, ibu: {cerveja.IBU}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            {
                var bebida = bebidas[3];
                switch (bebida)
                {
                    default: //sempre é a ultima
                        Console.WriteLine("default");
                        break;
                    case Cerveja cerveja when (cerveja.TeorAlcoolico > 10):
                        Console.WriteLine($"Que coice essa {cerveja.Nome} com {cerveja.TeorAlcoolico}");
                        break;
                    case Cerveja cerveja:
                        Console.WriteLine($"cerveja: {cerveja.Nome}, ibu: {cerveja.IBU}");
                        break;
                    case Vinho vinho:
                        Console.WriteLine($"vinho: {vinho.Nome}, cor: {vinho.Cor}");
                        break;
                    case null:
                        Console.WriteLine("nulo");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();

                {
                    const string ABC = "ABC";

                    string texto = "Pudim";
                    switch (texto) {
                        case ABC:
                            Console.WriteLine("def == ABC");
                            break;
                        case "DEF":
                            Console.WriteLine("def == DEF");
                            break;
                        case null:
                            Console.WriteLine("null");
                            break;
                        default:
                            Console.WriteLine(texto);
                            break;
                    }

                }
                Console.ReadKey();
            }
        }
    }
}
;