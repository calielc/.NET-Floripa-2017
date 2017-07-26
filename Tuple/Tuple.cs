using System;

namespace Tuple
{
    class Tuple
    {
        static (int, int) CalculeTupla1(int[] values)
        {
            var r = (0, 0);
            foreach (var value in values)
            {
                r = (r.Item1 + value, r.Item2 + 1);
            }
            return r;
        }

        static (int soma, int contador) CalculeTupla2(int[] values)
        {
            var r = (s: 0, c: 0);
            foreach (var value in values)
            {
                r.s += value;
                r.c++;
            }
            return r;
        }

        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 5, 8 };
            {
                var valorTupla = CalculeTupla1(array);
                Console.WriteLine($"soma: {valorTupla.Item1} e contador: {valorTupla.Item2}");
            }
            {
                var valorTupla = CalculeTupla2(array);
                Console.WriteLine($"{valorTupla.Item1} e {valorTupla.Item2}");
                Console.WriteLine($"soma: {valorTupla.contador} e contador: {valorTupla.soma}");
            }
            {
                //deconstructor
                var (soma, contador) = CalculeTupla2(array);
                Console.WriteLine($"soma: {soma} e contador: {contador}");
            }
        }
    }
}
