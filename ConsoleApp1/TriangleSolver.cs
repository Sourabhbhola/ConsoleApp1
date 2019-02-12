using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static  class TriangleSolver
    {
        


            public static string Analyze(int l, int b, int h)
            {

                int Sidea = l + b;
                int Sideb = b + h;
                int Sidec = h + l;

                if (Sidea > h && Sideb > l && Sidec > b)
                {
                    if ((l == b) && (b == h))
                        return "It is  an Equilateral Triangle";
                    else if ((l == b) || (l == h) || (b == h))
                        return "It is an Isosceles Triangle";

                    else return "It is a Scalene Triangle";
                }
                else return "Triangle cannot be formed";
            }
        }
    }