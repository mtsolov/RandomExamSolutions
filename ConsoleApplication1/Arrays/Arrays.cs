using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //string input = @"""#"" Pesho: @Sofia 16:00";
            List<string> a = new List<string>();
            string b = "1234";
            a.Add(b);

            foreach (var item in a)
            {
                char[] charArray = item.ToCharArray();
                string[] strArray = item.Select(x => x.ToString()).ToArray();
                Console.WriteLine("{0}", string.Join(", ", strArray));
            }
            // Here we call Regex.Match.
            //string c = Regex.Replace(Console.ReadLine(), @"\s+", "");
            //Console.WriteLine(c);
            //Match match = Regex.Match(input, @"^""#""([A-Za-z]+):\s*@([A-Za-z]+)\s*(\d+:\d+)$",
            //    RegexOptions.IgnoreCase);

            //// Here we check the Match instance.
            //if (match.Success)
            //{
            //    // Finally, we get the Group value and display it.
            //    string key = match.Groups[1].Value;
            //    string hey = match.Groups[2].Value;
            //    string rey = match.Groups[3].Value;
            //    Console.WriteLine(key);
            //    Console.WriteLine(hey);
            //    Console.WriteLine(rey);
            //}
        }

    }
}
//string input = Console.ReadLine();
//string[] items = input.Split(' ');
//int[] arr = new int[items.Length];
//for (int i = 0; i < items.Length; i++)
//{
//    arr[i] = int.Parse(items[i]);
//}
//Array.Sort(arr);
//Console.WriteLine(string.Join(", ", arr)); 

//===============================================

//string input = Console.ReadLine();
//string[] array = input.Split(' ');

//foreach (string word in array)
//{
//    Console.WriteLine(word);
//}
//===============================================

//LISTS:

// 1. Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and 
//all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, 
//separated by a space, each list at a separate line. Do not use LINQ! This problems aims to help you exercise your algorithmic thinking and 
//not how well you are familiar with built-in .NET functionalities. Use only arrays and lists.

//string input1 = Console.ReadLine();
//string input2 = Console.ReadLine();

//List<string> lista = new List<string>();
//List<string> listb = new List<string>();

//lista = input1.Split(' ').ToList();
//listb = input2.Split(' ').ToList();

//IEnumerable<string> union = lista.Union(listb);
// List<string> listc = union.ToList();

// listc.Select(int.Parse).ToList();
// listc.Sort();

//Console.WriteLine(string.Join(", ", listc));

//===============================================

//2. Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only 
//the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print 
//both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).

//List<string> a = new List<string>();
//string input1 = Console.ReadLine();
//a = input1.Split(' ').ToList();

//foreach (var item in a)
//{
//    if (item.Contains('.')
//}


// First we see the input string.

