using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nokia_Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            Testrun();
        }

        public static void Testrun()
        {

            #region Test
            //string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            //string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            //Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            //List<int> list = new List<int> { 5, 9, 2, 1, 3 };
            //FindMaxSum(list);
            //OddNumberToarray(2, 5);
            //Console.WriteLine(OddNumberToarray(2, 4));
            //List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            //int x = 5;
            //string v = FindNumber(numbers, x);
            //Console.WriteLine(v);


            //OddOrEven2(2);
            //Console.WriteLine("HELLO");
            //Fabonacci();
            //Multiplicationtable(5);
            //Multiplicationtable2(5);
            //BubbleSort();
            //Palindrome();
            //NumberToMonths(1);
            //ChangingValue();
            //Console.WriteLine( AddSumOfDigits(12956));
            //FindMostUsed("HELLO");

            #endregion Test
            #region Hackkerrank
            //countvalley(8, "UDDDUDUU");
            //gradingStudents(list);
            //fizzbuzz(5);
            //diagonalDifference(/*jioasdjs*/);
            //plusMinus(list);
            //staircase(10);
            //miniMaxSum(list);
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(23);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(4);
            list.Add(4);
            list.Add(23);
            list.Add(19);
            list.Add(19);
            list.Add(19);
            //birthdayCakeCandles(list);
            #endregion Hackerrank
            HackerRank hackerRank = new HackerRank();
            hackerRank.FindMaxSum(list);
            Console.Read();
        }
    }
}
