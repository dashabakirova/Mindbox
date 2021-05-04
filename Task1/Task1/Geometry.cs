using System;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Triangle myTriangle = new Triangle(6,5,5);             
                myTriangle.ShowName();
                myTriangle.Square();
                Circle myCircle = new Circle(5);
                myCircle.ShowName();
                myCircle.Square();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    abstract public class Shape
    {
        private string name;
        public Shape(string n)
        {
            name = n;
        }      
        public abstract double Square();
        public void ShowName()
        {
            Console.WriteLine(name);
        }

    }

    public class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
            : base("Треугольник")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Square()
        {
            double P = (a + b + c) / 2;
            double s = Math.Sqrt(P * (P - a) * (P - c) * (P - b));
            return s;
            Console.WriteLine("Площадь треугольника равна {0} ", s);
        }
        public bool IsRightTriangle()
        {
            return (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }

    public class Circle : Shape
    {
        double radius;
        public Circle(double radius)
            : base("Круг")
        {
            this.radius = radius;
        }

        public override double Square()
        { 
            double s = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            return s;
            Console.WriteLine("Площадь круга равна {0} ", s);
        }
    }
}
