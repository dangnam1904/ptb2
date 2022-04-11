using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptb2
{
    internal class giai_ptb2: giai_ptb1
    {
        private static double c { get; set; }

        public static string nghiem_ptb2(double a, double b, double c)
        {
            if(a == 0)
            {
                giai_ptb1.nghiem_ptb1(b, c);
            }
            else
            {
             double   deta = b * b - 4 * a * c;
                if(deta < 0)
                {
                    return "Phương trình vô nghiệm";
                }
                else if (deta == 0)
                {
                    return "Phương trình có nghiệm duy nhất" +  -b / (2 * a);
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(deta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(deta)) / (2 * a);
                    return "Phương trình có 2 nghiệm phân biệt: X1=  "+ x1+ "   X2  = "+x2;
                    
                }
            }
            return "";
        }
    }
}
