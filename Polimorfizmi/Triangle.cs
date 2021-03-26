using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi
{
    class Triangle
    {  /// მეთოდების გადატვირთვა. პოლიმორფიზმი    6.4.1.
       static public int geometria(int height,int base_triangle)
        {
            return height * base_triangle / 2;
        }

        static public int geometria(int s1, int s2,int s3)
        {
            return s1 + s2 + s3;
        }
    }
}
