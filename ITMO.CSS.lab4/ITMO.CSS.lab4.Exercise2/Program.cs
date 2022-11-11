using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab4.Exercise2
{
    class Utils

    {

        public static int Greater(int a, int b)

        {

            if (a > b)

                return a;

            else

                return b;

        }

        public static void Swap(ref int x, ref int y)
        {

            int temp = x;
            x = y;
            y = temp;

        }
        public static int Leaving()
        {

            Console.WriteLine("Do you want to leave? Press 'ESC' to leave or any key to try again");

            ConsoleKeyInfo answerLine = Console.ReadKey();

            if (answerLine.Key == ConsoleKey.Escape)
            {

                return 0;

            }

            else
            {

                return 1;

            }



        }

        public static void Checking(string a, string b, ref int x, ref int y, ref bool er)
        {
            Console.WriteLine("Checking...");

            try
            {
                x = int.Parse(a);
                y = int.Parse(b);

            }
            catch (Exception error)
            {

                Console.WriteLine("Error!!! {0}", error.Message);
                er = true;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter x: ");
                string lineOne = Console.ReadLine();
                Console.WriteLine("Enter y: ");
                string lineTwo = Console.ReadLine();
                int x = 0;
                int y = 0;
                bool er = false;
                Utils.Checking(lineOne, lineTwo, ref x, ref y, ref er);
                if (er)
                {
                    int escape = Utils.Leaving();

                    if (escape == 0)
                    {

                        break;

                    }
                    else
                    {

                        continue;

                    }
                }

                int num = Utils.Greater(x, y);

                Console.WriteLine("Num {0} is greater", num);

                Console.WriteLine("Before swap: " + x + "," + y);

                Utils.Swap(ref x, ref y);

                Console.WriteLine("After swap: " + x + "," + y);

                int esc = Utils.Leaving();

                if (esc == 0)
                {

                    break;

                }

            }
        }
    }
}
