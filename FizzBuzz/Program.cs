using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            var results = generator.Generate(100);
            foreach(var res in results)
            {
                Console.WriteLine(res);
            }    
        }
    }
}
