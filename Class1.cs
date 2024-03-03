using System.Reflection.PortableExecutable;

namespace ConsoleApp1
{
    public static class Work
    {
        public static void Task1()
        {
            Console.WriteLine("It's easy\r\nto win forgiveness for being wrong; being right is what gets you\r\ninto real trouble.");
        }
        public static void Task2()
        {
            int sum = 0, r = 0, d = 1;
            int max = 0, min = 99999;
            int count = 5;
            int a;
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                r = int.Parse(Console.ReadLine());
                sum += r;
                if (r > max)
                {
                    max = r;
                }
                if (r < min)
                {
                    min = r;
                }
                d *= r;
            }
            Console.WriteLine("Sum: ");
            Console.WriteLine(sum);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
            Console.WriteLine("Min: ");
            Console.WriteLine(min);
            Console.WriteLine("Product: ");
            Console.WriteLine(d);
        }
        public static void Task3()
        {
            int count = 6;
            int[] numbers = new int[count];
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                temp = int.Parse(Console.ReadLine());
                numbers[i] = temp;
            }
            Console.WriteLine(string.Concat(numbers.Reverse()));
        }
        public static void Task4()
        {
            int a = 0, b = 1, s = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                a = n;
                b = a++;
            }
            for (int i = s; s < m;)
            {
                a = b;
                b = s;
                s = a + b;
                Console.Write(s + " ");
            }
        }
        public static void Task5()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                b++;
                while (a < b)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(a+" ");
                    }
                    a++;
                    Console.WriteLine();
                }               
            }
        }
        public static void Task6()
        {
            Console.WriteLine("Choose 1 or 2: ");
            int ch = int.Parse(Console.ReadLine());
            int len = int.Parse(Console.ReadLine());
            char sig = char.Parse(Console.ReadLine());
            if(ch == 1)
            {
                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine(sig);
                }
            }
            if (ch == 2)
            {
                for (int i = 0; i < len; i++)
                {
                    Console.Write(sig);
                }
            }
        }
    }
}