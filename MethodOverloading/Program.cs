namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool iscurrency)
        {
            var sum = a + b;

            if (iscurrency == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (iscurrency == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (iscurrency == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
        {
                return sum.ToString();
        }
        }

        public static void Main(string[] args) // Fixed 'void' to 'static void'
        {
           // Console.WriteLine(Add(1, 2)); // Output: 3
           // Console.WriteLine(Add(1.5m, 2.5m)); // Output: 4.0
           // Console.WriteLine(Add(1, 2, true)); // Output: 3 dollars
           // Console.WriteLine(Add(4, 2, false)); // Output: 4
    }
}
}