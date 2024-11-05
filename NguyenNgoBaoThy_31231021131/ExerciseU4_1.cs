namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU4_1
    {
        public static void MainU4_1()
        {
            //Question_02();
            //Question_03();
            //Question_05();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
        /// <summary>
        /// display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5)
        /// </summary>
        public static void Question_02()
        {
            Console.WriteLine("Enter y ranging from -5 to +5 = ");
            int y = int.Parse(Console.ReadLine());
            int x = (int)(Math.Pow(y, 2) + 2 * y + 1);

            Console.WriteLine($"y = {x}");
        }

        /// <summary>
        /// takes distance (m) and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h)
        /// </summary>
        public static void Question_03()
        {
            Console.WriteLine("Enter distance (m) = ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours = ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes = ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconds = ");
            double s = double.Parse(Console.ReadLine());

            double km = (double)(d / 1000); //m to km
            double miles = (double)(d * 0.000621371192); //m to miles
            double out_h = (double)(h + m / 60 + s / 3600);
            double km_h = (double)(km / out_h);
            double miles_h = (double)(miles / out_h);

            Console.WriteLine($"km/h = {km_h}");
            Console.WriteLine($"miles/h = {miles_h}");
        }

        /// <summary>
        /// takes a character as input and checks if it is a vowel, a digit, or any other symbol
        /// </summary>
        public static void Question_05()
        {
            // Prompt the user to enter a character
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar; // Read a single character from the user
            Console.WriteLine(); // Move to the next line

            // Check if the character is a vowel
            if ("aeiouAEIOU".IndexOf(input) >= 0)
            {
                Console.WriteLine($"{input} is a vowel.");
            }
            // Check if the character is a digit
            else if (char.IsDigit(input))
            {
                Console.WriteLine($"{input} is a digit.");
            }
            // If not a vowel or digit, it's an other symbol
            else
            {
                Console.WriteLine($"{input} is an other symbol.");
            }

        }

    }
}
