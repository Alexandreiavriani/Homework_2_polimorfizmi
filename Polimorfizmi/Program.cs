using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("amocana 1:");
            Console.WriteLine("");
            Mathem kvadrati = new Mathem(4);

            
            Mathem martkutxedi = new Mathem(7,8);

         
            Mathem samkutxedi = new Mathem(5,3,6);

            //Console.WriteLine(samkutxedi.side_2);
            
            


            kvadrati.GetInfo();
            martkutxedi.GetInfo();
            samkutxedi.GetInfo();

            Console.WriteLine("");
            Console.WriteLine("amocana 2:");

            Console.WriteLine("");
            //////////////////////
            Console.Write("Perimeter:");
            Console.WriteLine(Triangle.geometria(2,3,5));

            Console.Write("Area:");
            Console.WriteLine(Triangle.geometria(6,7));

            Console.ReadKey();
        }
    }
}
