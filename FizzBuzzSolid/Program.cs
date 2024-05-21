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

            Console.WriteLine("Fizz Buzz Up To 10");

            fizzBuzzController.PrintList(10);

            Console.WriteLine("Fizz Buzz Up To 100");

            fizzBuzzController.PrintList(100);


        }
    }
}
