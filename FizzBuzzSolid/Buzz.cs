using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolid
{
    public class Buzz : IFizzBuzzRule
    {
        public bool IsValid(int number)
        {
            return number % 5 == 0;
        }

        public string Print()
        {
            return "Buzz";
        }
    }
}
