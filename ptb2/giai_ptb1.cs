using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptb2
{
    internal class giai_ptb1
    {
        private static double b { get; set; }
        private static double c { get; set; }
        public static string nghiem_ptb1(double b,double c)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    return "Phương trình vô sô nghiệm";

                }
                else
                    return "Phương trình vô nghiệm";
            }
            else
            {
                return "Phương trình có nghiệm:  "+ -c/b;
            }
        }

        public static void ng_ptb1(double b, double c)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("ptvsn");

                }
                else
                    Console.WriteLine("ptvn");
            }
            else
            {
                Console.WriteLine("pt co nghiêm:", -c/b);
            }
        }
    }
}
