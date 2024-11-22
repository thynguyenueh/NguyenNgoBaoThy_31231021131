namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU7
    {
        static void MainU7(string[] args)
        {
            int[,] a;//khai bao mot mang 2 chieu
            Console.WriteLine("So dong = "); int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("So cot = "); int cols = int.Parse(Console.ReadLine());
            
            //cap nhat vng nho cho mang 2 chieu
            a = new int[rows, cols];

            //Nhapmang2chieuBangCom(a);
            Nhapmang2chieuNgauNhien(a);
            XuatMang(a);
            Console.WriteLine("Muon in cot nao?"); int selCol = int.Parse(Console.ReadLine());
            XuatMangColIndex(a, selCol);
        }

        /*static void Nhapmang2chieuBangCom(int[,] a)
        {
            //a.GetLength(0): tra ve so dong cua mang 2 chieu
            //a.GetLength(0): tra ve so cot cua mang 2 chieu
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"a[{i},{j} = ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }*/
        static void Nhapmang2chieuNgauNhien(int[,] a)
        {
            Random random = new Random();
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for(int j = 0;j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void XuatMangColIndex(int[,] a, int ColIndex)
        {
            if(ColIndex < 0 ||ColIndex > a.GetLength(0) - 1)
            {
                Console.WriteLine("???");
                return;
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                    Console.WriteLine($"{a[i, ColIndex]}\t");
            }
        }
    }
}
