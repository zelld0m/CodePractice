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
            //Testrun();


            int i1 = 5;
            int i2 = 2; 
            int i3 = i1/i2;
            List <int>list1 = new List<int>();
             List<List<object>> list2 = new List<List<object>>();   
            Console.WriteLine(i3);
            Console.ReadLine();
        }

        public static void Testrun()
        {
            // INSERT FUNCTION HERE THAT You created in Different Class
            #region Test

            HackerRank hackerRank = new HackerRank();
            //Console.WriteLine(string.Join(", ", hacerRank.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia

            #endregion Test
        }

      
    }
}
