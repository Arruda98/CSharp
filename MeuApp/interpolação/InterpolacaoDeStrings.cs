using System;

namespace Strings
{
    public class Strings
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //var text = "O preço do produto é " + price;
            //var text = string.Format("O preço do produto é {0} apenas na promoção.", price);
            var text = $"O preço do produto é {price} apenas na promoção.";
            Console.WriteLine(text);

        }
    }
}