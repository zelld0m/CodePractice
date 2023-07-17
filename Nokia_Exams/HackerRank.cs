using System;
using System.Collections;
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
            }
        }
        public int diagonalDifference(List<List<int>> arr)
        {
            int diag1 = 0;
            int diag2 = 0;
            int total = 0;
            for (int i = 0; i <= arr.Count - 1; i++)
            {
                diag1 += arr[arr.Count() - 1 - i][i];
                diag2 += arr[i][i];
            }
            total = Math.Abs(diag1 - diag2);
            return total;
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
        public string timeConversion(string s)
        {
            DateTime d = DateTime.Parse(s);
            string x = d.ToString("HH:mm:ss");
            return x;
        }
        public int median(List<int> arr) 
        {
            int holdNumber = 0;
            int size = arr.Count;
            int mid = size / 2;
            arr.Sort();
        
            if (size % 2 != 0)
            {
                return arr[mid];
            }
            else
            {
                int value1 = arr[mid];
                int value2 = arr[mid - 1];
                return (value1 + value2) / 2;

            }
        }
        public int lonelyInteger(List<int> a)
        {
            var numberGroups = a.GroupBy(i => i);
            foreach (var grp in numberGroups)
            {
                if (grp.Count() == 1)
                {
                    return grp.Key;
                }
            }
            return 0;
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            //a0 b0
            //a1 b1
            //a2 b2
            //If a[i] > b[i], then Alice is awarded 1 point.
            //If a[i] < b[i], then Bob is awarded 1 point.
            //If a[i] = b[i], then neither person receives a point.
            List<int> result = new List<int>();
            int alice = 0;
            int bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (b[i] > a[i])
                {
                    bob++;
                }
            }
            result.Add(alice);
            result.Add(bob);

            return result;
        }
        public static int beautifulDays(int i, int j, int k)
        {
            var reverseNumber = "";
            int number = 0;
            var tempNumber = 0;
            int beautifulDay = 0;
            for (i = i; i <= j; i++)
            {
                tempNumber = i;
                reverseNumber = "";
                while (tempNumber > 0)
                {
                    number = tempNumber % 10;
                    tempNumber = tempNumber / 10;
                    var deneme = number.ToString();
                    reverseNumber += deneme;
                }
                var convertedNumber = Convert.ToInt32(reverseNumber);
                var lastNumber = i - convertedNumber;
                if (lastNumber % k == 0)
                    beautifulDay++;
            }
            return beautifulDay;
        }

        public int getTotalX(List<int> a,List<int> b)
        {
            int total = 0;


            for (int i = 0; i < a.Count ; i++)
            {
                if (a[i] % 2 == 0)
                {

                } 
            }
            return total;
        }
        public static List<int> countingSort(List<int> arr)
        {

            var fa = new int[100];
            foreach (var n in arr)
            { //can check if v is in range.
                fa[n] += 1;
            }
            return fa.ToList();
        }

        public int closestNumber(List <int> arr)
        {

            /*-20 - 3916237 - 357920 - 3620601 7374819 - 7330761 30 6246457 - 6461594 266854 - 520 - 470*/
            int x = 0;
            arr.Add(-20);
            arr.Add(- 3916237);
            arr.Add(-357920);
            arr.Add(7374819);
            arr.Add(-7330761);
            arr.Add(30);
            arr.Add(6246457);
            arr.Add(-6461594);
            arr.Add(266854);
            arr.Add(-520);
            arr.Add(-470);

            arr.Sort();

            return x;
        }
        public int countValueInArray(List<int> arr)
        {
            int x = 0;
            x = arr.Count;

            return x;
        }

        public  List<int> oddNumbers(int l, int r)
        {
            List<int> odds = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds;
        }

        public  string findNumber(List<int> arr, int k)
        {
            String x = "No";

            for (int i = 0; i < arr.Count; i++)
            {

                if (arr[i] == k)
                {
                    x = "YES";
                    break;
                }
                else
                {
                    x = "NO";
                }
            }
            return x;

        }

        public  string CompressString(String str)
        {
            string newX = string.Empty;
            int count = 1;
            int charPos = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((charPos + 1) < str.Length)
                {
                    if (str[charPos] == str[charPos + 1])
                    {
                        count++;
                        charPos++;
                    }
                    else if (count == 1)
                    {
                        newX += str[i];
                        charPos++;
                    }
                    else
                    {
                        newX += str[i] + "" + count;
                        count = 1;
                        charPos++;
                    }
                }
                else
                {
                    if (count == 1)
                    {
                        newX += str[i];
                    }
                    else
                    {
                        newX += str[i] + "" + count;
                        count = 1;
                    }

                }
            }
            Console.WriteLine(str);
            Console.WriteLine(newX);
            return newX;
        }
    

    }
  
}
