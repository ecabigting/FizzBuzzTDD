using System.Collections.Generic;
using System.Diagnostics;

namespace FizzBuzz
{
    public class Generator
    {
        public Generator()
        {
        }

        public List<string> Generate(int maxNumber)
        {
            var results = new List<string>();
            for (int x = 1; x <= maxNumber; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    results.Add("FizzBuzz");
                }
                else if (x % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else if (x % 5 == 0)
                {
                    results.Add("Buzz");
                }
                else
                {
                    results.Add(x.ToString());
                }
            }
            Debug.WriteLine(results);
            return results;
        }
    }
}