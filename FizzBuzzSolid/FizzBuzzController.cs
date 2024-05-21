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

        public List<string> PrintList(int value) {

            List<string> fizzBuzzList = new List<string>();

            for (int i = 1; i <= value; i++)
            {
                foreach (var fizzBuzzRule in fizzBuzzRuleList)
                {
                    if (fizzBuzzRule.IsValid(i))
                    {
                        fizzBuzzList.Add(fizzBuzzRule.Print());
                        break;
                    } 
                }

                fizzBuzzList.Add(i.ToString());
            }

            return fizzBuzzList;
        }
    }
}
