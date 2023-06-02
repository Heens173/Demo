namespace ConsoleApp_SE1739_D2
{
    class Customer {
        public int Id;
        public int CustomerID
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        //automatic properties
        public string CustomerName { get; set; } = "New customer";
        public void Print()
        {
            Console.WriteLine($"ID:{CustomerID}, Name: {CustomerName}");
        }
    }
    
    
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.CustomerID = 1;
            Console.WriteLine($"ID:{obj.CustomerID}, Name: {obj.CustomerName}");
            obj.CustomerID = 2000;
            obj.CustomerName = "Jack";
            obj.Print();
            Console.ReadLine();
            
        }
    }
}