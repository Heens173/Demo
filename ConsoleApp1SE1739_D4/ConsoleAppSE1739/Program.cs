//namespace ConsoleAppSE1739.Programming
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int x = 10, y = 20, z = 30;//đối số (argruments)
//            Console.WriteLine($"Tong 3 so la: {Add(x, y, z)}");

//            Console.WriteLine($"Tong tu 1 den 100 la: {Sum(100)}");
//            Console.WriteLine($"Tich cac thua so cua so n la: {Factorial(100)}");

//            Console.ReadLine();
//        }

//        public static int Add(int a, int b) => a + b;

//        //overload: bodied expression
//        public static int Add(int a, int b, int c) => Add(Add(a, b), c);

//        //Tinh tong chuoi: 1+2+3+4+..+100 => sum cac phan tu chan?


//        public static long Sum(int n)
//        {
//            int i = 1;
//            long sum = 0;
//            while (i <= n)
//            {
//                if (i % 2 == 0) sum += i;// sum = sum + 1;
//                i++;  //   i = i + 1

//            }
//            return sum;

//        }

//        //Bai tap 1: tinh tong 1 + 1/3 + 1/5 + 1/7 + ... + 1/(2n+1);
//        //Bai tap 2: tinh n! voi 0!=1

//        public static long Factorial(int n)
//        {
//            if (n == 0)
//            {
//                return 1;
//            }
//            else
//            {
//                return n * Factorial(n - 1);
//            }
//        }

//    }
//}