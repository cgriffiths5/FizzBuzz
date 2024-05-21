﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolid
{
    public class Fizz : IFizzBuzzRule
    {
        public bool IsValid(int number)
        {
            return number % 3 == 0;
        }

        public string Print()
        {
            return "Fizz";
        }
    }
}
