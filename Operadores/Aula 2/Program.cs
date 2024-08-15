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
            //Operadores de atribuição
            // =, +=, -=, *=, /=
            //variável = += valor | var = var + valor

            //int var01;
            //var01 = 50;
            //Console.WriteLine("Atribuição:  {0}", var01);
            //var01 += 20;
            //Console.WriteLine("Acumulando: {0}", var01);
            //var01 *= 2;
            //Console.WriteLine("Multiplicando: {0}", var01);
            //Console.ReadKey();

            //Operadores de incremento e decremento
            //Incremento e decremento pré-fixo:
            //++ variável  variável = variável + 1  variável += 1
            //--variável   variável = variável - 1  variável -= 1
            //Operador de incremento e decremento pós-fixos:
            //variável ++  variável = variável + 1  variável += 1
            //variável--   variável = variável -1   variável -= 1

            int contador;
            contador = 50;
            Console.WriteLine(contador);
            Console.WriteLine(contador++);
            Console.WriteLine(contador);
            Console.ReadKey();

            contador = 50;
            Console.WriteLine(contador);
            Console.WriteLine(++contador);
            Console.WriteLine(contador);
            Console.ReadKey();
        }
    }
}
