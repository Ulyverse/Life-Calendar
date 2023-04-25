using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Calendar_Prototype
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        private const int AverageLifespan = 80;
        private static DateTime birthdate;

        static void Main(string[] args)
        {
            Console.Write("Enter Birthday here(mm/dd/yyyy): ");

            string input = Console.ReadLine();
            birthdate = DateTime.ParseExact(input, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan totalTimeSpent = DateTime.Now - birthdate;
            double totalDaysSpent = totalTimeSpent.TotalDays;

            Console.WriteLine($"\nTotal life spent(days): {totalDaysSpent:.##}"); 
            Console.WriteLine($"Total life spent(weeks): {totalDaysSpent / 7:.##}");
            Console.WriteLine($"Life remaning on average(days): {AverageLifespan * 365 - totalDaysSpent:.##}");
            Console.WriteLine($"Life remaning on average(weeks): {(AverageLifespan * 365 - totalDaysSpent) / 7:.##}");

            Console.ReadKey();
        }
    }
}
