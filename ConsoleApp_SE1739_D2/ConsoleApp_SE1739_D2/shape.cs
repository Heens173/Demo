using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SE1739_D2
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        //virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class Drawing tasks");
        }

        public void Print()
        {
            Console.WriteLine("Performing base class Printing tasks");
        }

        //Abstract method
        public abstract void Display();

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }

        public override void Display()
        {
            Console.WriteLine("Display circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override void Display()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public new void Print()
        {
            Console.WriteLine("Print Rectangle");
                    }
    }
    class shape
    {
        static void Main(string[] args) {
            Shape s = new Circle();
            s.Display();
            s.Draw();
            s = new Rectangle();
            s.Display();
            s.Draw();
            s.Print();

            Console.ReadLine();
            //Customer.cs
            ConsoleApp_SE1739_D2.Customer c = new Customer();
            c.CustomerId = 1000;
            Console.WriteLine($"ID:{c.CustomerId}, Name: {c.CustomerName}");
            c.CustomerId = 2000;
            c.CustomerName = "jakk";
            c.Print();
            Console.ReadLine();

        }
        
    }
}
