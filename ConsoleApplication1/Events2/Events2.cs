using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Events2
{
    class Events2
    {
        private static DateTime eventTime;
        static void Main(string[] args)
        {
            var rgx = new Regex(@"^#([A-z]+):\s*@([A-z]+)\s*((?:[0-1][0-9]|2[0-3]):[0-5][0-9])$");

            var data = new SortedDictionary<string, SortedDictionary<string, List<string>>>();
            int N = int.Parse(Console.ReadLine());



            for (int i = 1; i <= N; i++)
            {


                Match match = rgx.Match(Console.ReadLine());
                if (match.Success)
                {
                    string person = match.Groups[1].Value;
                    string location = match.Groups[2].Value;
                    string time = match.Groups[3].Value;

                    if (!data.ContainsKey(location))
                    {
                        data[location] = new SortedDictionary<string, List<string>>();
                    }
                    if (!data[location].ContainsKey(person))
                    {
                        data[location][person] = new List<string>();
                    }
                    data[location][person].Add(time);
                }
            }

            string[] cities = Console.ReadLine().Split(',');

            foreach (var pair in data)
            {
                if (cities.Contains(pair.Key))
                {
                    Console.WriteLine(pair.Key + ":");
                    int a = 1;
                    foreach (var b in pair.Value)
                    {
                        var c = b.Value.OrderBy(v => v);
                        Console.WriteLine("{0}. {1} -> {2}", a++, b.Key, string.Join(", ", c));
                    }
                }
                else break;
            }



        }
    }
}


//namespace Events
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text.RegularExpressions;

//    public class Events
//    {
//        private static DateTime eventTime;

//        private static void Main()
//        {
//            string pattern = @"^#([A-Za-z]+):\s*@([A-Za-z]+)\s*(\d+:\d+)$";
//            Regex rgx = new Regex(pattern);
//            int N = int.Parse(Console.ReadLine());
//            var data = new SortedDictionary<string, SortedDictionary<string, List<DateTime>>>();

//            for (int i = 1; i <= N; i++)
//            {
//                Match match = rgx.Match(Console.ReadLine());
//                if (match.Success) 
//                    // && IsValidDate(match.Groups[3].Value)
//                {
//                    string person = match.Groups[1].Value;
//                    string location = match.Groups[2].Value;
//                    string time = match.Groups[3].Value;


//                    if (!data.ContainsKey(location))
//                    {
//                        data[location] = new SortedDictionary<string, List<DateTime>>();
//                    }
//                    if (!data[location].ContainsKey(person))
//                    {
//                        data[location][person] = new List<DateTime>();
//                    }

//                    data[location][person].Add(eventTime);
//                }
//            }

//            string[] locations = Console.ReadLine().Split(',');
//            foreach (var pair in data)
//            {
//                if (locations.Contains(pair.Key))
//                {
//                    Console.WriteLine(pair.Key + ":");
//                    int lineNumber = 1;
//                    foreach (var personData in pair.Value)
//                    {
//                        var formattedEventTimes = personData.Value
//                            .OrderBy(v => v)
//                            .Select(v => v.ToString("HH:mm"));
//                        Console.WriteLine("{lineNumber++}. {personData.Key} -> {string.Join(", ", formattedEventTimes)}");
//                    }
//                }
//            }
//        }

//        private static bool IsValidDate(string d)
//        {
//            return DateTime.TryParse(d, out eventTime);
//        }
//    }
//}