﻿using System;
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

            //countvalley(8, "UDDDUDUU");
            //gradingStudents(list);
            fizzbuzz(5);
            Console.Read();
        }

        public static void Multiplicationtable(int size)
        {
            int value = 0;

            for (int i = 1; i <= size; i++)
            {
                for (int k = 1; k <= size; k++)
                {
                    value = i * k;
                    Console.Write("\t" + value);
                }
                Console.WriteLine();
            }
        }
        public static void Multiplicationtable2(int size)
        {
            int value = 0;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    value = i * j;
                    Console.Write("\t" + value);
                }
                Console.WriteLine();
            }
        }
        public static void Fabonacci()
        {
            int x = 0, y = 1;
            for (int i = 0; i <= 5; i++)
            {
                Console.Write(x);
                x = x + y;
                y = x - y;

            }
            Console.ReadLine();

        }
        public void OddOrEven(int numberToDetermine)
        {
            if (numberToDetermine % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
        public static void OddOrEven2(int numberToDetermine)
        {
            string x;
            x = (numberToDetermine % 2 == 0) ? "EVEN" : "ODD";
            Console.WriteLine(x);
        }
        public static void BubbleSort()   //bubble sort 
        {

            int[] listNumber = { 5, 1, 3, 13, 134, 12, 13, 4, 122, 145, 1156 };
            int holdNumber;

            for (int i = 0; i < listNumber.Length; i++)
            {
                for (int secondHolderNumber = 0; secondHolderNumber < listNumber.Length - 1; secondHolderNumber++)
                {
                    if (listNumber[secondHolderNumber] > listNumber[secondHolderNumber + 1])
                    {
                        holdNumber = listNumber[secondHolderNumber + 1];
                        listNumber[secondHolderNumber + 1] = listNumber[secondHolderNumber];
                        listNumber[secondHolderNumber] = holdNumber;
                    }
                }
            }
            for (int i = 0; i < listNumber.Length; i++)
            {
                Console.WriteLine(listNumber[i] + ", ");
            }
        }
        public static void Palindrome() //palindrome
        {
            string word = "HELLO";
            string rev = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }
            Console.WriteLine(rev);
            Console.WriteLine(rev == word ? "PALINDROME" : "NOT PALINDROME");
        }
        public static void NumberToMonths(int numberToMonths) //numbertoMonths
        {

            String[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            string display = numberToMonths < 13 ? Months[numberToMonths - 1] : "ERROR";
            Console.Write(display);

        }
        public static void ChangingValue()
        {
            int a = 10, b = 20;
            a = a + b;   //  a =30
            b = a - b;    //  b = 10
            a = a - b;      //  a = 20


            Console.WriteLine("A:" + a + "\t B:" + b);

        }
        public static int AddSumOfDigits(int num)   // Add the sum of Digits 
        {
            string snum = num.ToString();
            int total = 0;
            int[] listToSumInt = new int[50];

            for (int i = 0; i < snum.Length; i++)
            {
                listToSumInt[i] = Convert.ToInt32(snum[i] - 48);
                Console.WriteLine();
            }
            Console.WriteLine("---------------- TOTAL -------------------");

            for (int i = 0; i < snum.Length; i++)
            {
                total = total + listToSumInt[i];
            }

            return total;
        }
        public static int FindMostUsed(int number)    // input  numbers then  find the most common used
        {



            return 1;
        }
        public static string FindMostUsed(string input)   // input number or letter find the most common used
        {// ERROR 
            char[] split = new char[50];
            int[] counter = new int[50];

            string mostused = "";
            for (int i = 0; i < input.Length; i++)
            {
                split[i] = input[i];
                //Console.WriteLine(split[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (split[i] == input[j])
                    {
                        counter[i] += 1;
                        Console.WriteLine(counter[i]);
                    }
                }

            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(counter[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (counter[i] > counter[i + 1])
                {
                    mostused = counter[i].ToString();
                }
            }

            return mostused;
        }
        public static string FindNumber(List<int> arr, int k) //HACKER RANK
        {
            string x = "YES";
            for (int i = 0; i <= arr.Count - 1; i++)
            {
                if (arr[i] == k)
                {

                    x = "YES";
                    break;
                }

                else x = "NO";
            }
            return x;
        }
        public static List<int> OddNumberToarray(int l, int r)  //HACKER RANK   
        {
            int x = 0;
            List<int> numbers = new List<int>() { };
            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
        public static List<int> FindMaxSum(List<int> InputList)
        {
            List<int> result = new List<int>();
            List<int> result2 = new List<int>();
            int max = 0;
            int Secondndmax = 0;
            for (int i = 0; i <= InputList.Count - 1; i++)
            {

                if (InputList[i] > InputList[i + 1])
                {
                    result.Add(InputList[i]);
                    max = InputList[i];
                }

            }
            result.Add(max);
            result.Add(Secondndmax);
            return result;
        }
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] totalNames = names1.Concat(names2).ToArray();
            string[] distinctArray = totalNames.Distinct().ToArray(); ;
            
            return distinctArray;
        }
        public static int countvalley(int steps,string path)
        {
            int start = 2;
            char[] pathchar = path.ToCharArray();

            for (int i = 0; i <= steps - 1; i++)
            {
                if (pathchar[i] == 'U' && start < 3)
                {
                    start++;
                }
                else if (pathchar[i] == 'D' && start !=0)
                {
                    start--;
                }
            }

            return start;
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> newgrade = new List<int>();
            for (int i = 0; i < grades.Count(); i++)
            {
                var divideTemp = grades[i] % 5;
                if (5 - divideTemp < 3 && grades[i] >= 38)
                {
                    grades[i] += 5 - divideTemp;
                }
            }
            return grades;
        }
        public static void fizzbuzz(int n)
        {

            string strX = "";
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    strX = "FizzBuzz";
                }
                else if ((i % 3) == 0 && (i % 5) != 0)
                {
                    strX = "Fizz";
                }
                else if ((i % 3) != 0 && (i % 5) == 0)
                {
                    strX = "Buzz";
                }
                else strX = Convert.ToString(i);
                //3&5  FizzBuzz
                //3   NOT 5  Fizz
                //5   NOT 3  Buzz 
                // not 3 and 5    return i 
                Console.WriteLine(strX);
            }
        }
    }
}
