using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab4.Exercise3
{
    internal class Program
    {
        public class Utils
        {
            public static bool Factorial(int n, out int answ)
            {
                int k;
                int f;
                bool ok = true;
                if (n < 0)
                {
                    ok = false;
                }

                try

                {

                    checked

                    {

                        f = 1;

                        for (k = 2; k <= n; ++k)

                        {

                            f = f * k;

                        }

                    }

                }

                catch (Exception)

                {

                    f = 0;

                    ok = false;

                }

                answ = f;


                return ok;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number and i'll show you factorial");
            string input = Console.ReadLine();
            int x = int.Parse(input);
            int f;
            bool ok;
            ok = Utils.Factorial(x, out f);
            if (ok)

                Console.WriteLine("Factorial(" + x + ") = " + f);

            else

                Console.WriteLine("Cannot compute this factorial");



        }
    }
}
