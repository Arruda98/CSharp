using System;

namespace MyApp
{
    class MyApp
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            Console.WriteLine(id);
        }
    }
}