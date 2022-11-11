using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab3.Exercise3
{
    enum MonthName

    {

        January,

        February,

        March,

        April,

        May,

        June,

        July,

        August,

        September,

        October,

        November,

        December

    }
    internal class Program
    {

        static int CheckYear(int userYear)
        {
            int daysInYear;

            if (userYear % 400 == 0)
            {
                daysInYear = 366;
            }
            if (userYear % 100 == 0)
            {
                daysInYear = 365;
            }
            if (userYear % 4 == 0)
            {
                daysInYear = 366;
            }
            else
            {
                daysInYear = 365;
            }
            return daysInYear;
        }
        static void Main(string[] args)
        {

            int dayNum = 0;
            int daysInYear = 0;

            Console.Write("Please enter a year number: ");

            string year = Console.ReadLine();

            try
            {
                int userYear = int.Parse(year);
                daysInYear = CheckYear(userYear);

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            var DaysInMonth = new List<int>();
            DaysInMonth.Add(31);
            if (daysInYear == 365)
            {
                DaysInMonth.Add(28);
            }
            else
            {
                DaysInMonth.Add(29);
            }
            DaysInMonth.Add(31);
            DaysInMonth.Add(30);
            DaysInMonth.Add(31);
            DaysInMonth.Add(30);
            DaysInMonth.Add(31);
            DaysInMonth.Add(31);
            DaysInMonth.Add(30);
            DaysInMonth.Add(31);
            DaysInMonth.Add(30);
            DaysInMonth.Add(31);

            Console.Write("Please enter a day number between 1 and {0}: ", daysInYear);

            string day = Console.ReadLine();

            try
            {
                dayNum = int.Parse(day);


                if (dayNum < 1 || dayNum > daysInYear)
                {

                    throw new ArgumentOutOfRangeException("Day out of range");

                }
                int monthNum = 0;

                foreach (int daysInMonth in DaysInMonth)
                {

                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;

                string monthName = temp.ToString();


                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}
