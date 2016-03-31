using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adasdas
{
    class adasdas
    {
        string pattern = "aa|aba|bcc|cc|cbc";
        string input = "abaabb";
        
        
        foreach (Match m in Regex.Matches(input, pattern)) 
        {

             Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}
