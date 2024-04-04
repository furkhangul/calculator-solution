using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şifreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime date = new DateTime(2004, 04, 11);
            int age;
            int ageday;
            int agemonth;
            age = now.Year - date.Year;
            agemonth = now.Month - date.Month;
            ageday = now.Day - date.Day;

            if (agemonth < 0 || (agemonth == 0 && ageday < 0))
            {
                age--;
                agemonth += 12;
            }

            if (ageday < 0)
            {
                agemonth--;
                ageday += 30;
            }

            Console.WriteLine("YOUR AGE : {0} year {1} month {2} day", age, agemonth, ageday);
            Console.ReadLine();

        }
    }
}
