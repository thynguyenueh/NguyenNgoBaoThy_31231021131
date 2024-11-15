namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU6
    {
        static void MainU6(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //nhapmang(a);//1
            SinhMangNgauNhien(a);
            InMang(a);//2
            increaseItems(a, 10);//3
            InMang(a);//4
            int sum = Sum(a);
            Console.WriteLine($"Sum = {sum}");
        }
        static void nhapmang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu #{i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void SinhMangNgauNhien(int[]a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
        }
        static void InMang(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        static void increaseItems(int[]a, int val)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] += val;
        }
        static int Sum(int[] a)
        {
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            return total;
        }
    }
}
