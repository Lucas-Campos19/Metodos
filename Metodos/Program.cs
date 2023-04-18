using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma de {0} + {1} é igual a {2}", v1, v2, Soma(v1, v2));
            Console.ReadKey();
        }

        static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
