using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            int b = 20;
            Console.WriteLine(“a é igual a b ? { 0}”, (a == b));
            Console.WriteLine(“a é diferente de b ? { 0}”, (a != b));
            Console.WriteLine(“a é maior do que b? { 0}”, (a > b));
            Console.WriteLine(“a é menor do que b? { 0}”, (a < b));
            Console.WriteLine(“a é maior ou igual a b ? { 0}”, (a >= b));
            Console.WriteLine(“a é menor ou igual a b ? { 0}”, (a <= b));*/

            /*Testando &&:
            int idade;
            bool idadeValida;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            idadeValida = (idade > 0) && (idade <= 120);// Retorna true se idade estiver entre 0 e 120:
            Console.WriteLine(idadeValida);*/
            

            //Testando || (pipe):
            int temperatura;
            bool temperaturaInvalida;
            Console.WriteLine("Digite a temperatura em graus Celcius para verificar se a água está nos estados sólidos ou gasos: ");
            temperatura = int.Parse(Console.ReadLine());
            //Verifica se a temperatura é inválida (água não está no estado líquido):
            temperaturaInvalida = (temperatura < 0) || (temperatura > 100);
            Console.WriteLine(temperaturaInvalida);
            Console.ReadLine();

            /*Testando !:
            bool valorLogico;
            valorLogico = false; // Mude para false para ver o resultado
            valorLogico = !valorLogico; //Invertendo o valor lógico
            Console.WriteLine(valorLogico.ToString()); //Resultado impresso é inverso do fornecido à variável.*/

        }
    }
}
