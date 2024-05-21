using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolid
{
    public interface IFizzBuzzRule
    {
        bool IsValid(int number);

        string Print();
    }
}
