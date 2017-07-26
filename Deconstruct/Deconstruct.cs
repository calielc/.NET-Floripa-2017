using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruct
{
    public class Classe1
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void Deconstruct(out int id, out string nome)
        {
            id = this.Id;
            nome = this.Nome;
        }
        public void Deconstruct(out int id, out string nome, out string tudo)
        {
            id = this.Id;
            nome = this.Nome;
            tudo = $"{this.Nome} ({this.Id})";
        }
    }

    public class Classe2
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public static class Classe2Helper
    {
        public static void Deconstruct(this Classe2 self, out int id, out string nome)
        {
            id = self.Id;
            nome = self.Nome;
        }
    }

    class Deconstruct
    {
        static void Main(string[] args)
        {
            var instancia1 = new Classe1
            {
                Id = 1,
                Nome = "Pizza"
            };
            {
                var (id, nome) = instancia1;
                Console.WriteLine($"id: {id}, nome: {nome}");
            }
            {
                var (id, nome, tudo) = instancia1;
                Console.WriteLine($"id: {id}, nome: {nome}, tudo: {tudo}");
            }
            {
                var (id, _) = instancia1;
                Console.WriteLine($"id: {id}");
            }

            var instancia2 = new Classe2
            {
                Id = 20,
                Nome = "Pudim"
            };
            {
                var (id, nome) = instancia2;
                Console.WriteLine($"id: {id}, nome: {nome}");
            }

            Console.ReadKey();
        }
    }
}
