namespace OOP_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(8, 3);
            Square square = new Square(9);
            Circle circle = new Circle(6);
                 
                IShape[] shapes = { rectangle, square, circle};
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());
            }
        }
    }
}