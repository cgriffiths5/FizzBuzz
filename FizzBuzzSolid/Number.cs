using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolid
{
    public class Number : IFizzBuzzRule
    {
        public int _number;

        public bool IsValid(int number)
        {
            _number = number;
            return number % 3 != 0 || number % 5 != 0;
        }

        public string Print()
        {
            return _number.ToString();
        }
    }
}
