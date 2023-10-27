using System.Net.WebSockets;
using System.Reflection.Metadata;

namespace KK13
{
    internal class Program
    {
        //Тема 13
        //Задача 2
        //static string path = "numbers.txt";

        //static void Main()
        //{
        //    // Записываем N действительных чисел в файл
        //    Console.WriteLine("Введите количество действительных чисел (N):");
        //    int N = int.Parse(Console.ReadLine());
        //    WriteNumbersToFile(N);

        //    // Читаем числа из файла и вычисляем их произведение
        //    double product = CalculateProduct();

        //    // Выводим произведение на экран
        //    Console.WriteLine($"Произведение чисел в файле: {product}");
        //}

        //static void WriteNumbersToFile(int N)
        //{
        //    using (StreamWriter sw = new StreamWriter(path))
        //    {
        //        for (int i = 0; i < N; i++)
        //        {
        //            Console.WriteLine($"Введите {i + 1}-е число:");
        //            double number = double.Parse(Console.ReadLine());
        //            sw.WriteLine(number);
        //        }
        //    }
        //}

        //static double CalculateProduct()
        //{
        //    double product = 1;

        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            double number = double.Parse(line);
        //            product *= number;
        //        }
        //    }

        //    return product;
        //}

        //Задача 3
        //static void Main(string[] args)
        //{
        //    Random random = new Random();

        //    Console.WriteLine("Введите m: ");
        //    int m = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите n: ");
        //    int n = int.Parse(Console.ReadLine());

        //    using (var f = File.Create("f"))
        //    using (var bw = new BinaryWriter(f))
        //    {
        //        for (int i = 0; i < 100; i++)
        //            bw.Write(random.Next(0, 101));
        //    }

        //    using (var f = File.OpenRead("f"))
        //    using (var g = File.Create("g"))
        //    using (var bw = new BinaryWriter(g))
        //    using (var br = new BinaryReader(f))
        //    {
        //        Console.WriteLine("Полученные числа: ");
        //        while (f.Position < f.Length)
        //        {
        //            int s = br.ReadInt32();
        //            if (s % m == 0 && s % n != 0)
        //            {
        //                bw.Write(s);
        //                Console.WriteLine(s);
        //            }
        //        }
        //    }
        //}

        //Задача 5

        //        static void Main(string[] args)
        //        {
        //            Random random = new Random();

        //            using (var f = File.Create("f"))
        //            using (var bw = new BinaryWriter(f))
        //            {
        //                for (int i = 0; i < 100; i++)
        //                    bw.Write(random.Next(0, 101));
        //            }

        //            using (var f = File.OpenRead("f"))
        //            using (var g = File.Create("g"))
        //            using (var bw = new BinaryWriter(g))
        //            using (var br = new BinaryReader(f))
        //            {
        //                List<int> numberIgnore = new List<int>();
        //                Console.WriteLine("Полученные числа: ");
        //                while (f.Position < f.Length)
        //                {
        //                    int number = br.ReadInt32();
        //                    if (!numberIgnore.Contains(number))
        //                    {
        //                        numberIgnore.Add(number);
        //                        bw.Write(number);
        //                        Console.WriteLine(number);
        //                    }
        //                }
        //            }
        //        }
        //Задание 6

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите N: ");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите K: ");
        //    int k = int.Parse(Console.ReadLine());
        //}

        //Дополнительное задание

        static void Main(string[] args)
        {
            string test = @"hot.db";
            //var fileInfo = new FileInfo(test);
            //Console.WriteLine(test.Length);
            //Console.WriteLine(fileInfo.Name);
            //Console.WriteLine(fileInfo.Extension);
            //Console.WriteLine(fileInfo.DirectoryName);
            using (var text = File.OpenRead(test))
            using (var br = new BinaryReader(text))
            {
                string oneString = br.ReadString();
                Console.WriteLine(oneString);
                int twoString = br.ReadByte();
                string[] masString = new string[twoString];
                for (int i = 0; i < twoString; i++)
                {
                    string threeString = br.ReadString();
                    string fourString = br.ReadString();
                    masString[i] = threeString+fourString;
                }
                List<byte[]> masByte = new List<byte[]>();
                for (int i = 0; i < twoString; i++)
                {
                    int fiveString = br.ReadInt32();
                    var by = br.ReadBytes(fiveString);
                    masByte.Add(by);
                }
                for (int i = 0;i < twoString; i++)
                {
                    File.WriteAllBytes(masString[i], masByte[i]);
                }
            }
        }
    }
}