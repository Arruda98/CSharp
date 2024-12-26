using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";

            //Verifica se existe a palavra no texto ↓
            Console.WriteLine(texto.Contains("Testando"));
            Console.WriteLine(texto.Contains("text"));

            //Compara Strings totalmente iguais ↓
            //Console.WriteLine(texto.CompareTo("Testando"));
            //Console.WriteLine(texto.CompareTo("testando"));
        }
    }
}