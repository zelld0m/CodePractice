using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nokia_Exams
{
    class  HackerRank
    {
        #region hackerrank
        public List<int> FindMaxSum(List<int> InputList)
        {
            List<int> result = new List<int>();
            List<int> list2 = InputList;
            int max = 0;
            int Secondmax = 0;
            for (int i = 0; i < InputList.Count - 1; i++)
            { 
                if (InputList[i] > InputList[i + 1])
                {
                    result.Add(InputList[i]);
                    max = InputList[i];
                }   
            }
            result.Add(max);
            result.Add(Secondmax);
            return result;
        }
        public string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] totalNames = names1.Concat(names2).ToArray();
            string[] distinctArray = totalNames.Distinct().ToArray(); ;

            return distinctArray;
        }
        public int countvalley(int steps, string path)
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
        public List<int> gradingStudents(List<int> grades)
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
        public void fizzbuzz(int n)
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
        public void crewsort(List<int> crew_id, List<int> job_id)
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
        public int diagonalDifference(List<List<int>> arr)
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
        public void plusMinus(List<int> arr)
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
                else if (arr[i] == 0)
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
        public void staircase(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }
        public void miniMaxSum(List<int> arr)
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
        public int birthdayCakeCandles(List<int> candles)
        {
            int nMaxHeight = 0;
            int maxHeight = candles.Max();
            for (int i = 0; i < candles.Count; i++)
            {
                if (maxHeight == candles[i])
                {
                    nMaxHeight++;
                }

            }
            return nMaxHeight;
        }
    }
}
