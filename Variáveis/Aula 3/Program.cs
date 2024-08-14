using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 90;
            bool a = false;
            int y;
            y = x;
            string nome = "Ana Júlia";
            //Neste caso o WriteLine aceita apenas caracteres, para usar uma variável do tipo inteiro eu preciso usar um conversor
            Console.WriteLine("O número é: " + x.ToString());//ToString converte a variável inteiro para string, assim ele poderá ser lido como o valor exato da variável que eu atribui
            Console.WriteLine("E o valor lógico é: " + a.ToString());
            Console.WriteLine("O número é: " + y.ToString());
            Console.WriteLine("Meu nome é: " + nome);//Uma variável simples, sem conversão
            Console.ReadKey();
        }
    }
}
