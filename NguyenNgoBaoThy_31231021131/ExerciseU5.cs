namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU5
    {
        public static void Main(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            Question_04();
            //Question_05();
            //Question_06();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
        //Write a C# function to find the maximum of three numbers.- Improve the next version that accept at least 1 parameter.
        public static void Question_01()
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = max3Nums(a, b, c);
            Console.WriteLine($"Max = {max}");
        }
        static int max2Nums(int a, int b)
        {
            return a > b ? a : b; //viết ngắn gọn
            
            /*if (a > b)
                return a;
            else
                return b;*/
        }
        static int max3Nums(int a, int b, int c)
        {
            return max2Nums(a, max2Nums(b, c));
        }

        //Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        public static void Question_02()
        {
            Console.WriteLine("Enter a non-negative integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
        }
        static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Number must be a non-negative interger.");
            }
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        
        //Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        public static void Question_03()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /*Write a C# function to print
        1. all prime numbers that less than a number(enter prompt keyboard).
        2. the first N prime numbers*/
        public static void Question_04()
        {
            
        }
    }
}

