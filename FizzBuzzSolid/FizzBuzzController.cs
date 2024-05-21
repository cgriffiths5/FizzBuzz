using System.Data;
using System.Runtime.CompilerServices;

namespace FizzBuzzSolid
{
    public class FizzBuzzController
    {
        private readonly List<IFizzBuzzRule> fizzBuzzRuleList;


        public FizzBuzzController()
        {
            fizzBuzzRuleList = new List<IFizzBuzzRule>
            {
                new FizzBuzz(),
                new Fizz(),
                new Buzz()
            };
        }

        public void PrintList(int value) {

            for (int i = 1; i <= value; i++)
            {
                var stringNum = i.ToString();

                foreach (var fizzBuzzRule in fizzBuzzRuleList)
                {
                    if (fizzBuzzRule.IsValid(i))
                    {
                        stringNum = fizzBuzzRule.Print();
                        break;
                    } 
                }

                Console.WriteLine(stringNum);
            }
        }
    }
}
