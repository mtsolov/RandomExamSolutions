using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace BasicMarkupLanguage
{
    class BasicMarkupLanguage
    {
        public static string word;
        static void Main(string[] args)
        {
            //string pattern = "^<([inverse]*|[reverse]*|[repeat]*|[stop+/+>]*)+[\s+]*(content+[\s+]*=|value+[\s+]*=+[\s+]*\"\d\"+[\s+]*content+=)*[\s+]*(\"?[\w|\s]+\"?)?[\s+]*[/][>]";
            
            
            //Regex rgx = new Regex(@"^<([inverse]*|[reverse]*|[repeat]*|[stop+/+>]*)+[\s+]*(content+[\s+]*=|value+[\s+]*=+[\s+]*""\d""+[\s+]*content+=)*[\s+]*(""?[\w|\s]+""?)?[\s+]*[/][>]");
            //@"^<([inverse]*|[reverse]*|[repeat]*|[stop+/+>]*)+[\s+]*(content+[\s+]*=|value+[\s+]*=+[\s+]*""\d""+[\s+]*content+=)*[\s+]*(""?[\w|\s]+""?)?[\s+]*[/][>]"

           
                
                
                while (true)
                {
                    
                    string input = Regex.Replace(Console.ReadLine(), @"\s+", "");
                    Match match = Regex.Match(input, @"^<(inverse|reverse|repeat)+(content+|value+)=(""\d"")*[\w+=]*(""?[\w|\s]+""?)?[\s+]*", RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        string function = match.Groups[1].Value;
                        string value = match.Groups[2].Value;
                        string valuenumber = match.Groups[3].Value;
                        string text = match.Groups[4].Value;
                        
                        if (function == "inverse")
                        {
                            string text2 = text.Reverse();
                            
                            
                        }
                        
                       
                        
                        
                    }
                    if (input == "<stop/>")
                        {
                            break;
                        }
                    
                
            }

            }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            word = new string(charArray);
            return word;
        }
    }
}