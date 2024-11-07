namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU2
    {
        public static void MainU2()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// to Add / Sum Two Numbers
        /// </summary>
        public static void Question_01()
        {
            Console.WriteLine("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} * {b} = {product}");
        }
        /// <summary>
        /// to Swap Values of Two Variables
        /// </summary>
        public static void Question_02()
        {
            Console.WriteLine("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a = {b}, b = {a}");
        }
        /// <summary>
        /// . to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.WriteLine("Enter a number a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b = ");
            float b = float.Parse(Console.ReadLine());
            float product = a * b;

            Console.WriteLine($"{a} * {b} = {product}");
        }
        /// <summary>
        /// to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.WriteLine("Enter a number a (ft) = ");
            double a = double.Parse(Console.ReadLine());
            double b = (double)(0.3048 * a);

            Console.WriteLine($"{b} cm");
        }
        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.WriteLine("Enter a number a (C) = ");
            float a = float.Parse(Console.ReadLine());
            float b = (float)(33.8 * a);
            Console.WriteLine($"{b} F");

            Console.WriteLine("Enter a number a (F) = ");
            float c = float.Parse(Console.ReadLine());
            float d = (float)(c - 32) * 5 / 9;
            Console.WriteLine($"{d} C");
        }
        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"Size of short: {sizeof(short)} bytes");
            Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
            Console.WriteLine($"Size of decimal: {sizeof(decimal)} bytes");

        }
        /// <summary>
        /// to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Question_07()
        {
            Console.WriteLine("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            int asciiValue = (int)character;

            Console.WriteLine($"ASCII value of '{character}' is {asciiValue}");

        }
        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.WriteLine("Enter r to Calculate Area of Circle = ");
            float r = float.Parse(Console.ReadLine());
            float area = (float)(Math.PI * r * r);

            Console.WriteLine($"Area = {area}");
        }
        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.WriteLine("Enter c to Calculate Area of Square = ");
            float c = float.Parse(Console.ReadLine());
            float area = (float)(c * c);

            Console.WriteLine($"Area = {area}");
        }
        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.WriteLine("Enter days = ");
            int input_days = int.Parse(Console.ReadLine());
            int years = input_days / 365;
            int weeks = (input_days - 365 * years) / 7;
            int days = (input_days - 365 * years) % 7;

            Console.WriteLine($"{years} year(s) {weeks} week(s) {days} day(s)");

        }
    }
}
