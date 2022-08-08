using System;

namespace OOP_Assignment
{
    class Circle: IShape
    {
        public double Radius { get; set; }
         
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);  
        }
        public double CalculatePerimeter()
        {
            return 2 * Radius * (Math.PI); 
        }
    }
}
