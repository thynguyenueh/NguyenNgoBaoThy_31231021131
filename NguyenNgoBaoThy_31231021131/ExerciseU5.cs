using System.Diagnostics.Metrics;

namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU5
    {
        public static void MainU5(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
        /// <summary>
        /// Write a C# function to find the maximum of three numbers.- Improve the next version that accept at least 1 parameter.
        /// </summary>
        static void Question_01()
        {
            Console.WriteLine("Enter 3 numbers to find max:");
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

        /// <summary>
        /// Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        static void Question_02()
        {
            Console.WriteLine("Enter a non-negative integer to calculate its factorial: ");
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
        
        /// <summary>
        /// Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        static void Question_03()
        {
            Console.WriteLine("Enter a number to check prime: ");
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
            for (int i = 2; i < n; i++) //Nếu dùng for (int i = 2; i <= Math.Sqrt(n); i++) thì tối ưu hơn khi kiểm tra số lớn
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Write a C# function to print
        /// 1. all prime numbers that less than a number(enter prompt keyboard).
        /// 2. the first N prime numbers
        /// </summary>

        // In ra tất cả các số nguyên tố nhỏ hơn n
        static void PrintPrimesLessThan(int n)
        {
            Console.WriteLine($"Prime numbers less than {n}:");
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // In ra "count" số nguyên tố đầu tiên
        static void PrintFirstNPrimes(int count)
        {
            Console.WriteLine($"The first {count} prime numbers:");
            int num = 2; // Số bắt đầu để kiểm tra nguyên tố
            int printedPrimes = 0;

            while (printedPrimes < count)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                    printedPrimes++;
                }
                num++;
            }
            Console.WriteLine();
        }

        static void Question_04()
        {
            // Yêu cầu người dùng nhập một số để kiểm tra
            Console.Write("Enter a number to find primes less than it: ");
            int n = int.Parse(Console.ReadLine()); // Đổi max thành n
            PrintPrimesLessThan(n);

            // Yêu cầu người dùng nhập số lượng số nguyên tố đầu tiên cần in
            Console.Write("Enter the number of first primes to display: ");
            int count = int.Parse(Console.ReadLine());
            PrintFirstNPrimes(count);
        }

        /// <summary>
        /// Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        // Function to check if a number is a perfect number
        static void Question_05()
        {
            Console.WriteLine("Enter a number: ");
            int max = int.Parse(Console.ReadLine());
        }
        static bool IsPerfect(int number)
        {
            int sum = 0;

            // Loop through all potential divisors
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i; // Add the divisor to the sum
                }
            }

            // A number is perfect if the sum of its divisors equals the number itself
            return sum == number;
        }

        // Function to print all perfect numbers less than 1000
        static void PrintPerfectNumbers(int max)
        {
            Console.WriteLine($"Perfect numbers less than {max}:");
            for (int i = 1; i < max; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Question_06(string[] args)
        {
            PrintPerfectNumbers(1000); // Print all perfect numbers less than 1000
        }

        /// <summary>
        /// Write a C# function to check whether a string is a pangram or not.
        /// </summary>
        static bool IsPangram(string input)
        {
            // Convert the string to lowercase to handle case insensitivity
            input = input.ToLower();

            // Iterate over each letter in the alphabet
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                // Check if the current letter is not in the input string
                if (!input.Contains(letter))
                {
                    return false; // If a letter is missing, it's not a pangram
                }
            }

            // If all letters are found, return true
            return true;
        }

        static void Question_06()
        {
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();

            if (IsPangram(userInput))
            {
                Console.WriteLine("The string is a pangram.");
            }
            else
            {
                Console.WriteLine("The string is not a pangram.");
            }
        }
    }
}

