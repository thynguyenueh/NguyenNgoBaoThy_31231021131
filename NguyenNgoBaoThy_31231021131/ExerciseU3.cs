namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU3
    {
        public static void MainU3()
        {
            //Question_01();
            //Question_02();
            //Question_03();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// convert from degrees Celsius to Kelvin and Fahrenheit.
        /// </summary>
        public static void Question_01()
        {
            Console.WriteLine("Enter Celsius degree:");
            float a = float.Parse(Console.ReadLine());
            float b = (float)(a + 273);
            float c = (float)(a * 18 / 10 + 32);

            Console.WriteLine($"Kelvin = {b}");
            Console.WriteLine($"Fahrenheit = {c}");
        }
        /// <summary>
        /// calculate the surface and volume of a sphere, given its radius
        /// </summary>
        public static void Question_02()
        {
            Console.WriteLine("Enter r: ");
            float r = float.Parse(Console.ReadLine());
            float surface = (float)(4 * Math.PI * r * r);
            float volume = (float)(4 / 3 * Math.PI * r * r * r);

            Console.WriteLine($"Surface: {surface}");
            Console.WriteLine($"Volume: {volume}");
        }
        ///
        public static void Question_03()
        {
            Console.WriteLine("Enter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            float b = float.Parse(Console.ReadLine());

            float adding = (float)(a + b);
            float subtracting = (float)(a - b);
            float multiplying = (float)(a * b);
            float dividing = (float)(a / b);
            float mod = (float)(a % b);

            Console.WriteLine($"{a} + {b} = {adding}");
            Console.WriteLine($"{a} - {b} = {subtracting}");
            Console.WriteLine($"{a} * {b} = {multiplying}");
            Console.WriteLine($"{a} / {b} = {dividing}");
            Console.WriteLine($"{a} mod {b} = {mod}");

        }
    }
}
