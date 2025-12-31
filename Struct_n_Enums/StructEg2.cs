using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_n_Enums
{
    public interface IShape
    {
        double GetArea();
    }

    public struct Rectangle : IShape
    {
        public double Breadth { get; set; }
        public double Length { get; set; }

        public Rectangle(double l, double b)
        {
            Length = l;
            Breadth = b;
        }

        public double GetArea()
        {
            return Length * Breadth;
        }
    }


    public class StructEg2
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(5.0, 4.0);
            double area = r.GetArea();
            Console.WriteLine("Area of rectangle : " + area);

            Console.WriteLine("*******************Enum Output******************");
            EnumEg.EnumOps();
            Console.Read();
        }

    }
}
