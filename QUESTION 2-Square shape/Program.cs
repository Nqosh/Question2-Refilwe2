using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTION_2_Square_shape
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of your Square");
            double length = Convert.ToDouble(Console.ReadLine());
            Square square1 = new Square();
            square1.Side = length;
            Console.WriteLine("Perimeter of your Square = " + square1.Side * 4 + " " + "cm");
            Square square2 = new Square(length);
            Console.WriteLine("Area of your Square =" + square2.Side * square2.Side + " " + "cm");
            Console.ReadKey();
        }
    }

    public class Square
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square()
        {
        }

        public Square(double side)
        {
            this.side = side;
        }
    }
}
