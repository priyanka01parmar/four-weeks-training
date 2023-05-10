// Execercise no.1 OOP concepts
using System;
using System.Reflection.Metadata.Ecma335;

namespace Circle
{
    class Circle
    {
        public double Rad { get; private set; }

        static void Main(string[] args)
        {
            double rad = 0;
            Console.Write("Enter a Radius:");
            rad = Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(rad);
            Console.WriteLine("Area OF circle :" + c.GetArea());
            Console.WriteLine("Area of circumference:" + c.Getcircumference());
        }



        public Circle(double rad)
        {

            this.Rad = rad;
        }
        public double GetArea()
        {

            double pi = 0;
            double area = 0;
            pi = 3.14;
            area = pi * this.Rad * this.Rad;
            return area;
        }
        public double Getcircumference()
        {
            double circum = 0;
            double pi = 0;
            pi = 3.14;
            circum = 2 * pi * this.Rad;
            return circum;
        }
    }
}