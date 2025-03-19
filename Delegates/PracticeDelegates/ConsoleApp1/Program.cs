using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        public delegate void RectDelegate(double Width, double Height);
        public void GetArea(double Width,double Height)
        {
            Console.WriteLine(Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2*(Width + Height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj += rect.GetPerimeter;

            obj(12.34, 56.78);


            Console.ReadLine();
        }
    }
}
