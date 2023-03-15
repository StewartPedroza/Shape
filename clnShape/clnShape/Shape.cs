using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Shape
    {
        private String name;
        private int sides;

        public Shape()
        {
        }

        public Shape(string name, int sides)
        {
            this.name = name;
            this.sides = sides;
        }

        public string Name { get => name; set => name = value; }
        public int Sides { get => sides; set => sides = value; }

        public override string ToString()
        {
            return "\nName: " + this.name +
                   "\n No. of sides: " + this.Sides + 
                   "\nArea: " + this.ComputreArea() + 
                   "\nPerimeter: " + this.perimeter();
                   
        }

        public virtual double ComputreArea()
        {
            return 0.0;
        }

        public virtual double perimeter()
        {
            return 0.0;
        }
    }
}
