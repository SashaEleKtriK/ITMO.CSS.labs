using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab1.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool t = true;

            while (t)
            {
                try
                {
                    Console.WriteLine("Input first num");
                    string temp = Console.ReadLine();
                    double i = Int32.Parse(temp);
                    Console.WriteLine("Input second num");
                    temp = Console.ReadLine();
                    double b = Int32.Parse(temp);
                    t = false;
                    double k = i / b;
                    Console.WriteLine("The result of dividing {0} by {1} is {2}", i, b, k);
                }
                catch (Exception e)
                {
                    Console.WriteLine("input error {0}", e.Message);

                }
            }

        }
    }
}
