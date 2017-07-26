using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFuncions
{
    class LocalFuncions
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 5, 8 };

            var soma = 0;
            void Adicione(int valor)
            {
                soma += valor;
            };
            bool EPar(int valor)
            {
                return valor % 2 == 0;
            }

            foreach (var item in array)
            {
                if (EPar(item))
                {
                    Adicione(item);
                }
            }
            Console.WriteLine($"soma: {soma}");
            Console.ReadKey();
        }
    }
}
