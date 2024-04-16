using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    abstract public class Shape
    {
        public abstract void CalculateArea();

        public void Display()
        {

        }
    }


    public class Circle : Shape
    {
        private int radius;
        private double result;

        public Circle(int radius) {
        this.radius = radius;
        }

        public override void CalculateArea()
        {
           result =3.14 * radius * radius;
        }

        public string Print()
        {
            return $"Area of circle is{result}";
        }
    }

    public class Rectangle : Shape
    {
        private int width;
        private int length;
        private double res;

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
        public override void CalculateArea()
        {
            res=width*length;
        }
        public string Print()
        {
            return $"Area of circle is {res}";
        }
    }
}
