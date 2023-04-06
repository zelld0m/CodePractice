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
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(23);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            
            //plusMinus(list);
            //staircase(10);
            miniMaxSum(list);
            #endregion Hackerrank

            Console.Read();
        }
        #region Random Exams
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
        #endregion Random exams

        #region hackerrank
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
        public static int countvalley(int steps, string path)
        {
            int start = 2;
            char[] pathchar = path.ToCharArray();

            for (int i = 0; i <= steps - 1; i++)
            {
                if (pathchar[i] == 'U' && start < 3)
                {
                    start++;
                }
                else if (pathchar[i] == 'D' && start != 0)
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
        public static void crewsort(List<int> crew_id, List<int> job_id)
        {
            long cost = 0;
            crew_id.Sort();
            job_id.Sort();
            int len1 = crew_id.Count;

            int len2 = job_id.Count;

            if (len1 == len2)

            {

                for (int i = 0; i < len1; i++)

                {

                    if (job_id[i] >= crew_id[i])

                    {

                        cost = cost + (job_id[i] - crew_id[i]);

                    }

                    else if (job_id[i] < crew_id[i])

                    {

                        cost = cost + (crew_id[i] - job_id[i]);

                    }

                }

            };


        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int x = 0;

            int diag1 = 0;
            int diag2 = 0;
            int store = 0;
            for (int i = 0; i <= arr.Count - 1; i++)
            {
                diag1 += i;
            }
            return diag1;
        }
        public static void plusMinus(List<int> arr)
        {
            //determine the positive numbers and size
            int listcount = arr.Count;
            decimal dTotal = 0;
            int positive = 0;
            int negative = 0;
            int zero = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    positive += 1;
                }
                else if (arr[i] < 0)
                {
                    negative += 1;
                }
                else if (arr[i] ==0)
                {
                    zero++;
                }
                
            }
            result.Add(positive);
            result.Add(negative);
            result.Add(zero);

            for (int i = 0; i < result.Count; i++)
            {
                dTotal = Convert.ToDecimal(result[i]) / Convert.ToDecimal(listcount);
                Console.WriteLine(dTotal.ToString("N6"));
            }

        }
        #endregion Hackerrank
        public static void staircase(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                Console.WriteLine (spaces + hashes);
            }
        }
        public static void miniMaxSum(List<int> arr)
        {
            //sort the minimum value 
            //place it on an array
            List<int> sorted = new List<int>();
            Int64 minimum = 0;
            Int64 max = 0;
            int holdNumber = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int secondHolderNumber = 0; secondHolderNumber < arr.Count - 1; secondHolderNumber++)
                {
                    if (arr[secondHolderNumber] > arr[secondHolderNumber + 1])
                    {
                        holdNumber = arr[secondHolderNumber + 1];
                        arr[secondHolderNumber + 1] = arr[secondHolderNumber];
                        arr[secondHolderNumber] = holdNumber;
                    }
                }
            }
            for (int i = arr.Count - 1; i > 0; i--)
            {
                max += Convert.ToInt64(arr[i]);
            }
            for (int i = 0; i < arr.Count - 1; i++)
            {
                minimum += Convert.ToInt64(arr[i]);
            }
            Console.WriteLine("{0} {1}", minimum, max);
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
        public static string fizzbuzz( int i )
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
            //FROM OTHER DEVS  didnt pass other test case 
            //// string[] arr_temp = Console.ReadLine().Split(' ');
            //long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
            //long minSum = arr.Sum() - arr.Max();
            //long maxSum = arr.Sum() - arr.Min();
            //Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}
