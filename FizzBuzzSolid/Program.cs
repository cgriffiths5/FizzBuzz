using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolid
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzController fizzBuzzController = new FizzBuzzController();

            Console.WriteLine("Up To 10");

            var result = fizzBuzzController.PrintList(10);

            result.ForEach(r => Console.WriteLine(r));

            Console.WriteLine("Up To 100");

            var secondResult = fizzBuzzController.PrintList(100);

            secondResult.ForEach(r => Console.WriteLine(r));
        }
    }
}
