using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square :Shape
    {
        private String name;
        private int sides;
        private double side1;

        public Square()
        {
        }

        public Square(string name, int sides, double side1)
        {
            this.name = name;
            this.sides = sides;
            this.side1 = side1;
        }

        public string Name { get => name; set => name = value; }
        public int Sides { get => sides; set => sides = value; }
        public double Side1 { get => side1; set => side1 = value; }

        public override string ToString()
        {
            return "\nName: " + this.name +
                  "\n No. of sides: " + this.Sides +
                  "\nArea: " + this.ComputreArea() +
                  "\nPerimeter: " + this.perimeter();
        }

        public override double ComputreArea()
        {
            return Math.Pow(this.side1, 2);
        }

        public override double perimeter()
        {
            return side1 * 4;
        }
    }
}
