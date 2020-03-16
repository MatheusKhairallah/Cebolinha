using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            string texto=Console.ReadLine();
            string texto2=texto.Replace("r", "l");

            Console.Clear();
            
            string mensagem="" +texto2+ "";

            Console.WriteLine(mensagem);
        }
    }
}
