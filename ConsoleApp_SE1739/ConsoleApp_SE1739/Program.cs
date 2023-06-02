using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApp_SE1739
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"tich cac thuc so: ", Factorial(10));



        }

        //Tinh Giai thua
        public static long Factorial(int n)

        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n * Factorial(n - 1);
            }

        }



    }
}




        //            //int x = 10, y = 20, z = 30;


        //            Console.WriteLine("Hello, World!");
        //            Console.WriteLine("***** My First C# Appp****");
        //            //Console.WriteLine($"Sum =  {Add(x, y, z)}");
        //            //Console.WriteLine("S(n) = 1 + 1/3 + 1/5 + 1/7 + ... + 1/(2n+1)",sum1 );
        //            Console.WriteLine($"tich cac thuc so: ", Factorial(10));
        //            Console.ReadLine();
        //        }




        //        //    public int add(int a, int b) => a + b;
        //        //    {
        //        //        return a + b;

        //        //    }

        //        //public int Add(int a, int b, int c) => add(add(a, b), c);

        //        //    public static long sum(int i)
        //        //    {
        //        //        int i = 0;
        //        //        long sum = 0;
        //        //        while (i <= n)
        //        //        {
        //        //            sum += i; // sum= sum+1
        //        //            i++;//i+1
        //        //        }
        //        //        return sum;
        //        //    }

        //        // bai tap tinh tong 1+1/3+1/5+...+1/(2n+1)
        //        public static long sum1
        //        {

        //                int g = 10;
        //        for (int i = 0; i <= n; i++)
        //        {
        //            double sum1 = 1.0 / (2 * i + 1);
        //        sum += term;
        //        }

        //}


        //public static long Factorial(int n)
        //{
        //    if (n == 1) return 0;
        //    else return n * Factorial(n - 1);
        //}


    //}