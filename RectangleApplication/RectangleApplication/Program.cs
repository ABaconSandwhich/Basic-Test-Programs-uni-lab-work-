using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{
    class RectanglesApplication
    {

        static void pause(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int width, height;
            Rectangle rec1, rec2;

            string s1;

            s1 = "Program to test the Rectangle class.\n\n";
            s1 += "\nThe program creates two rectangles,";
            s1 += "\nwith dimensions specified by the user.";

            Console.WriteLine(s1);

            Console.WriteLine("\nFor the first rectangle:-");
            Console.WriteLine("\nEnter width : ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter height : ");
            height = int.Parse(Console.ReadLine());

            rec1 = new Rectangle(width, height);
            rec1.PrintRectangle();
            Console.WriteLine("\nArea of first rectangle is {0} ", rec1.CalculateArea());
            Console.WriteLine("\nPerimeter is {0} ", rec1.CalculatePerimeter());

            Console.WriteLine("\nFor the second rectangle:-");
            Console.WriteLine("\nEnter width : ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter height : ");
            height = int.Parse(Console.ReadLine());

            rec2 = new Rectangle(width, height);
            rec2.PrintRectangle();
            Console.WriteLine("\nArea of second rectangle is {0} ", rec2.CalculateArea());
            Console.WriteLine("\nPerimeter is {0} ", rec2.CalculatePerimeter());

            RectanglesApplication.pause("\nPress any key to exit ...");
        }
    }

    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public int CalculateArea()
        {
            return this.width * this.height;
        }

        public int CalculatePerimeter()
        {
            return 2 * (this.width + this.height);
        }

        public void PrintRectangle()
        {
            Console.WriteLine("\nRectangle of width {0} and height {1}", this.width, this.height);
        }
    }
}
