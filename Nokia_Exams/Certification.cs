using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nokia_Exams
{
    #region
    internal class Certification
    {
    }
    public class Team
    {
        public string teamName;
        public int noOfPlayers;
        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }
        public bool RemovePlayer(int count)
        {
            if ((noOfPlayers - count) < 0)
            {
                return false;
            }
            else
            {
                noOfPlayers -= count;
                return true;
            }
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers) :
        base(teamName, noOfPlayers)
        {
        }
        public void ChangeTeamName(string name)
        {
            this.teamName = name;
        }
    }

    public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
    {
        return employees.
  GroupBy(e => e.Company).
  OrderBy(e => e.Key).
  Select(grp => new
  {
      CompanyName = grp.Key,
      Average = (int)Math.Round(grp.Average(e => e.Age))
  }).
  ToDictionary(item => item.CompanyName.ToString(), item => item.Average);
    }

    public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
    {
        return employees.
        GroupBy(e => e.Company).
        OrderBy(e => e.Key).
        Select(grp => new
        {
            CompanyName = grp.Key,
            Count = (int)grp.Count()
        }).
        ToDictionary(item => item.CompanyName.ToString(), item => item.Count);
    }

    public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
    {
        return employees.
        GroupBy(e => e.Company).
        OrderBy(e => e.Key).
        Select(grp => new
        {
            CompanyName = grp.Key,
            Emp = employees.Where
                    (p => p.Company == grp.Key && p.Age == (int)grp.Max(e => e.Age)).FirstOrDefault()
        }).ToDictionary(item => item.CompanyName.ToString(), item => item.Emp);
    }
#endregion

}
