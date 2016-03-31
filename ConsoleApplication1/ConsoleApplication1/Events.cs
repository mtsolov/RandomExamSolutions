using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Events
    {
        static void Main(string[] args)
        {
            Regex rgx = new Regex(@"#[A-z]+: @[A-z]+ (?:[01]?[0-9]|2[0-3]):[0-5][0-9]");
            var person = new List<string>();
            var location = new List<string>();
            var time = new List<string>();
            string input = Console.


            for (int i = 0; i < 1; i++)
			{
			    Console.WriteLine();
			}

            var variables = rgx.Matches(input);
            foreach (Match variable in variables)
            {
                var type = variable.Groups[1].Value;
                var name = variable.Groups[2].Value;
                if(type == \)
                {
                    doubles.Add(name);
                }
                else
                {
                    ints.Add(name);
                }
            }
        
        }
    }
}
