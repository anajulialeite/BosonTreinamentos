using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Condicional simples:
            int num1;
            int num2;
            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais");
            }
            Console.ReadLine();*/

            //Condicional Composto:

            int num1;
            int num2;
            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais: ");
            }
            else
            {
                Console.WriteLine("Os números são diferentes");
            }
            Console.ReadLine();
        }
    }
}
