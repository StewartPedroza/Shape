using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle:Shape
    {
        private double lenght;
        private double width;

        public Rectangle()
            {
            }

        public Rectangle(String name, int sides, double length, double width)
            {
                base.Name = name;
                base.Sides = sides;
                this.lenght = length;
                this.width = width;
            }

        public double Lenght { get => lenght; set => lenght = value; }
        public double Width { get => width; set => width = value; }

        public override string ToString()
        {
            return"\nName: " + base.Name +
                  "\n No. of sides: " + base.Sides +
                  "\nLength: " + this.lenght + 
                  "\nWidth: " + this.width +
                  "\nArea: " + this.ComputreArea() +
                  "\nPerimeter: " + this.perimeter();
        }
        public override double ComputreArea()
        {
            return this.lenght * this.width;
        }

        public override double perimeter()
        {
            return this.lenght * 2 + this.width * 2;
        }
    }
}
