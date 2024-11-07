namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU4_2
    {
        public static void Main(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        static void Question_01()
        {
            // Prompt the user to enter the sides of the triangle
            Console.WriteLine("Enter the length of side 1:");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side 2:");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side 3:");
            double side3 = double.Parse(Console.ReadLine());

            // Check if the sides can form a valid triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                // Check the type of triangle
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
        }

        // Function to check if the given sides form a valid triangle
        static bool IsValidTriangle(double a, double b, double c)
        {
            // Triangle inequality theorem: sum of any two sides must be greater than the third
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        /// <summary>
        /// Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        static void Question_02()
        {
            int[] numbers = new int[10];
            int sum = 0;

            Console.WriteLine("Enter 10 numbers:");

            // Loop to read 10 numbers from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i]; // Add each number to the sum
            }

            // Calculate the average
            double average = (double)sum / 10;

            // Print the sum and average
            Console.WriteLine($"\nSum of the numbers: {sum}");
            Console.WriteLine($"Average of the numbers: {average}");
        }

        /// <summary>
        /// Write a program to display the multiplication table of a given integer.
        /// </summary>
        static void Question_03()
        {
            Console.Write("Enter an integer to display its multiplication table: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table for {number}:\n");

            // Loop to print the multiplication table from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        /// <summary>
        /// Write a program to display a pattern like triangles with a number.
        /// </summary>
        static void Question_04()
        {
            Console.WriteLine("Pattern 1:");
            PrintPattern1(4);

            Console.WriteLine("\nPattern 2:");
            PrintPattern2(4);

            Console.WriteLine("\nPattern 3:");
            PrintPattern3(4);
        }

        // Function to print Pattern 1
        static void PrintPattern1(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // Function to print Pattern 2
        static void PrintPattern2(int rows)
        {
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }

        // Function to print Pattern 3
        static void PrintPattern3(int rows)
        {
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces for alignment
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        /// </summary>
        static void Question_05()
        {
            // Prompt the user for input
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            // Initialize the sum of the harmonic series
            double sum = 0;

            // Display the harmonic terms and calculate the sum
            Console.WriteLine("The first " + n + " terms of the harmonic series are:");
            for (int i = 1; i <= n; i++)
            {
                double term = 1.0 / i;
                Console.Write(term + " ");
                sum += term; // Add the term to the sum
            }

            // Display the sum of the harmonic series
            Console.WriteLine("\nSum of the harmonic series up to " + n + " terms is: " + sum);
        }

        /// <summary>
        /// Write a program to find the ‘perfect’ numbers within a given number range
        /// </summary>
        static void Question_06()
        {
            // Prompt the user for input range
            Console.Write("Enter the lower bound of the range: ");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound of the range: ");
            int upperBound = int.Parse(Console.ReadLine());

            // Display perfect numbers in the given range
            Console.WriteLine($"Perfect numbers between {lowerBound} and {upperBound} are:");

            for (int number = lowerBound; number <= upperBound; number++)
            {
                if (IsPerfect(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        // Function to check if a number is perfect
        static bool IsPerfect(int number)
        {
            int sumOfDivisors = 0;

            // Find divisors of the number (excluding the number itself)
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)  // If i is a divisor
                {
                    sumOfDivisors += i;
                }
            }

            // A number is perfect if the sum of its divisors is equal to the number
            return sumOfDivisors == number;
        }

        /// <summary>
        /// Write a program to determine whether a given number is prime or not.
        /// </summary>
        static void Question_07()
        {
            // Prompt the user to input a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is prime and display the result
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            // 0 and 1 are not prime numbers
            if (number <= 1)
            {
                return false;
            }

            // Check divisibility from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)  // If divisible, it's not prime
                {
                    return false;
                }
            }

            return true;  // If no divisors were found, the number is prime
        }
    }
}
