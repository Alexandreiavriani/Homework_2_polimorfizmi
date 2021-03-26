using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi
{
    /// კონსტრუქტორების გადატვირთვა  6.5.2
    public class Mathem
    {
        private int side_1;
        private int side_2;
        private int side_3;
        private int Perimeter;
        private double Area;
        
        public Mathem(int side_1)
        {
            this.side_1 = side_1;
            Perimeter = 4 * side_1;
            Area =Math.Pow(side_1, 2);
        }

        public Mathem(int side_1, int side_2):this(side_1)
        {
            
            this.side_2 = side_2;
            Perimeter = 2 * (side_1 + side_2);
            Area = side_1 * side_2;
        }

        public Mathem(int side_1, int side_2, int side_3) : this(side_1,side_2)
        {
           
            this.side_3 = side_3;
            Perimeter = side_1 + side_2 + side_3;
            Area = (side_1 * side_2) /2;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Perimeter: {Perimeter}  Area: {Area}");
           
        }



    }
}
