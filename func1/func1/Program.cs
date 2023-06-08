using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func1
{
    internal class Program
    {

        static void inverterTela()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        static int entrarNum(string msg, int li, int ls)
        {
            int x;
            do
            {
                Console.Write(msg);
                x = int.Parse(Console.ReadLine());
            }
            while (x < li || x > ls);
            return x;
        }
        static int somar(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int n1;
            int n2;

            inverterTela();

            n1 = entrarNum("Digite o 1º numero: ", 0, 10);
            n2 = entrarNum("Digite o 2º numero: ", 10, 20);
            Console.WriteLine("Soma de {0} com {1} é {2}", 
                n1, 
                n2, 
                somar(n1, n2));

        }
    }
}
