using System;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;

        public Rectangle (double lengthx, double widthx)
        {
            length = lengthx;
            width = widthx;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length is: {0}", length);
            Console.WriteLine("Width is: {0}", width);
            Console.WriteLine("Area is: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(15, 20);
            rect.Display();
            Console.ReadLine();
        }
    }
}
