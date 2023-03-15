using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            shape1.Name = "Circle";
            shape1.Sides = 0;
            Console.WriteLine(shape1);
            

            Shape shape2 = new Shape("shape 2", 0);
            shape2.Name = "Rectangle";
            Console.WriteLine(shape2);

            Square shape3 = new Square("shape 3", 4, 2);
            shape3.Name = "Square";
            Console.WriteLine(shape3);

            Rectangle shape4 = new Rectangle("shape 4", 4, 3, 5);
            shape4.Name = "Rectangle";
            Console.WriteLine(shape4);
        }
    }
}
