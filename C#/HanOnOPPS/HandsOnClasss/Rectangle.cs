using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnClasss
{
    class Rectangle
    {
        private int length;
        private int width;
        public Rectangle() //default construnctor
        {
            length = 10;
            width = 20;
        }
        
        public Rectangle(int length,int width) //parameter constructor
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle(int length)
        {
            this.length = length;
            this.width = 2 * this.length;
        }
        public Rectangle(Rectangle rectangle) //copy construnctor
        {
            length = rectangle.length;
            width = rectangle.width;
        }
        public void Area()
        {
            Console.WriteLine("Area of Rectangle " + (length * width));
        }

    }
    class Test_Rectangle
    {
        static void Main()
        {
            Rectangle r = new Rectangle(); //invoke default constructor
            Rectangle r1 = new Rectangle(12, 4);//parametized consturctor
            Rectangle r2 = new Rectangle(r);//copy construnctor
            Rectangle r3 = new Rectangle(r1); //copy construnctor
            Rectangle r4 = new Rectangle(12);
            Rectangle[] list = new Rectangle[5] { r, r1, r2, r3,r4 };
            foreach (Rectangle r11 in list)
                r11.Area();
        }
    }

}
