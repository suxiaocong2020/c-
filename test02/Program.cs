using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //成员变量
        private double radius;

        public void Acceptdetails()
        {
            Console.WriteLine("请输入半径：");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return radius * radius  * 3.1415;
        }

        public double GetPerimeter()
        {
            return radius * 2 * 3.1415;
        }

        public void Display()
        {
            Console.WriteLine("面积： {0}", GetArea() );
            Console.WriteLine("周长： {0}", GetPerimeter());
        }

    }//end class Rectangle    
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}