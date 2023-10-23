using System;
using System.Collections.Generic;

namespace Nokia_Exams
{
    internal class RandomProblem
    {
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
        public void BubbleSort()   //bubble sort 
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

        public void multiplierTable()
        {

            double hold = 0;

            for (double i = 1; i < 7; i++)
            {
                for (double j = 1; j < 6; j++)
                {
                    if (j == 1 && i == 1 && hold == 0)
                    {
                        hold = j * i;
                        Console.Write(hold + "     ");
                    }
                    else if (hold == 0 && i >= 2)  // activate when reset
                    {
                        hold = 1;
                        hold = hold * i;
                        Console.Write(hold + "     ");
                    }
                    else // j > 2
                    {
                        i++;
                        hold = (hold * i);
                        Console.Write(hold + "     "); // activate on reset hold = j*i
                        i--;
                    }

                }
                Console.WriteLine();
                hold = 0;
            }
        }
        private int CalculatePower(int number, int powerOf)
        {
            int result = number;
            for (int i = 2; i <= powerOf; i++)
                result *= number;
            return result;
        }
        private List<int> CalculatePower(int powerOf, int number, int x)
        {
            List<int> result = new List<int>();


            return result;
        }


    }
}
