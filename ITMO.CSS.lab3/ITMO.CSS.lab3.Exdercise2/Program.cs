using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab3.Exdercise2
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
        static void Main(string[] args)
        {

            var DaysInMonth = new List<int>();
            DaysInMonth.Add(31);
            DaysInMonth.Add(28);
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
            int dayNum = 0;

            Console.Write("Please enter a day number between 1 and 365: ");

            string day = Console.ReadLine();

            try
            {
                dayNum = int.Parse(day);


                if (dayNum < 1 || dayNum > 365)
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
