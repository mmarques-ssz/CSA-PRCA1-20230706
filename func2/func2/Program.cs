using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace func2
{
    internal class Program
    {
        static int[] num;

        static void inverterTela()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        static void entrar()
        {
            for(int i=0; i<5; ++i)
            {
                Console.Write("Digite o {0}º valor: ", i+1);
                num[i] = int.Parse(Console.ReadLine());
            }
        }
        static void dobrar()
        {
            for (int i = 0; i < 5; ++i)
            {
                num[i] *= 2;
            }
        }
        static void mostrar()
        {
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("{0}º valor: {1}", i+1, num[i]);
            }
            Console.WriteLine("-----------");
        }
        static void Main(string[] args)
        {
            num = new int[5];
            inverterTela();
            entrar();
            mostrar();

            dobrar();
            mostrar();
        }
    }
}
