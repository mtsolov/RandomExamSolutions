using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        //string input1 = Console.ReadLine();
        //Regex reg = new Regex("aa|aba|bcc|cc|cdc");
        //var data = new Dictionary<string, int>();



        //foreach (Match match in reg.Matches(input1))
        //{
        //    string SoftUniNumeral = match.Groups[1].Value;
            
        //    if (data.ContainsKey(match))
        //    {

        //    }
        //}


        //foreach (var item in b)
        //{
        //    Console.WriteLine(item);   
        //}


        List<string> numbers = new List<string>();

        string a = Console.ReadLine();
        var b = a.Trim().Split(',').ToList();
            
        for (int i = 0; i < b.Count; i++)
        {
            string randomNumbers = "";
            string numberWord = "";
            randomNumbers = b[i].Trim();
            char [] arrayche = new char[randomNumbers.Length];
            arrayche = randomNumbers.ToCharArray();

            for (int j = 0; j < arrayche.Length; j++)
            {
                if (arrayche[j].Equals('0'))
                {
                    numberWord += "zero+";
                }
                if (arrayche[j].Equals('1'))
                {
                    numberWord += "one+";
                }
                if (arrayche[j].Equals('2'))
                {
                    numberWord += "two+";
                }
                if (arrayche[j].Equals('3'))
                {
                    numberWord += "three+";
                }
                if (arrayche[j].Equals('4'))
                {
                    numberWord += "four+";
                }
                if (arrayche[j].Equals('5'))
                {
                    numberWord += "five+";
                }
                if (arrayche[j].Equals('6'))
                {
                    numberWord += "six+";
                }
                if (arrayche[j].Equals('7'))
                {
                    numberWord += "seven+";
                }
                if (arrayche[j].Equals('8'))
                {
                    numberWord += "eight+";
                }
                if (arrayche[j].Equals('9'))
                {
                    numberWord += "nine+";
                }



                
            }
            numbers.Add(numberWord);
 
            //var sortedNumbers = numbers.OrderBy(x => x).ToList();
            //List<string> final = new List<string>();
            //string add = "";

            //for (int i = 0; i < numbers.Count; i++)
            //{
                
            //}
        }

        var sortedNumbers = numbers.OrderBy(x => x).ToList();
        List<string> krai = new List<string>();


        for (int m = 0; m < numbers.Count; m++)
        {
            List<string> aideoshte = new List<string>();

            
            
            string wordNumber = "";
            
            aideoshte = sortedNumbers[m].Split('+').ToList();

            for (int s = 0; s < aideoshte.Count; s++)
            {


                if (aideoshte[s].Equals("zero"))
                {
                    wordNumber += "0";
                }
                if (aideoshte[s].Equals("one"))
                {
                    wordNumber += "1";
                }
                if (aideoshte[s].Equals("two"))
                {
                    wordNumber += "2";
                }
                if (aideoshte[s].Equals("three"))
                {
                    wordNumber += "3";
                }
                if (aideoshte[s].Equals("four"))
                {
                    wordNumber += "4";
                }
                if (aideoshte[s].Equals("five"))
                {
                    wordNumber += "5";
                }
                if (aideoshte[s].Equals("six"))
                {
                    wordNumber += "6";
                }
                if (aideoshte[s].Equals("seven"))
                {
                    wordNumber += "7";
                }
                if (aideoshte[s].Equals("eight"))
                {
                    wordNumber += "8";
                }
                if (aideoshte[s].Equals("nine"))
                {
                    wordNumber += "9";
                }

            }

            krai.Add(wordNumber);

        }
        Console.WriteLine(string.Join(", ", krai));

        



    }

}
