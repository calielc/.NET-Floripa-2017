using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    class OutParameter
    {
        static int CalculeOut(int[] values, out int contador)
        {
            var sum = 0;
            contador = 0;
            foreach (var value in values)
            {
                sum += value;
                contador++;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 5, 8 };

            {
                int contador;
                var soma = CalculeOut(array, out contador);
                Console.WriteLine($"soma: {soma}, contador: {contador}");
            }
            Console.WriteLine();
            Console.WriteLine();

            {
                var soma = CalculeOut(array, out int contador);
                Console.WriteLine($"soma: {soma}, contador: {contador}");
            }
            Console.WriteLine();
            Console.WriteLine();

            {
                var soma = CalculeOut(array, out var contador);
                Console.WriteLine($"soma: {soma}, contador: {contador}");
            }
            Console.WriteLine();
            Console.WriteLine();

            {
                var soma = CalculeOut(array, out _);
                Console.WriteLine($"soma: {soma}");
            }
            Console.WriteLine();
            Console.WriteLine();

            {
                var texto = "av";
                if (int.TryParse(texto, out var numero))
                {
                    Console.WriteLine($"no if: {numero}");
                }
                else
                {
                    Console.WriteLine($"no else: {numero}");
                }
                Console.WriteLine($"fora: {numero}");
            }

            Console.ReadKey();
        }
    }
}
