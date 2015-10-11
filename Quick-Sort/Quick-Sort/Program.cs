using System;


namespace Quick_Sort
{
    public class RandomProportional : Random
    {
        // The Sample method generates a distribution proportional to the value 
        // of the random numbers, in the range [0.0, 1.0].
        protected override double Sample()
        {
            return Math.Sqrt(base.Sample());
        }

        public override int Next()
        {
            return (int)(Sample() * int.MaxValue);
        }
    }
    class Quicksort
    {
        public static void qsortI(int[] items)
        {
            qsi(items, 0, items.Length - 1);
        }
        static void qsi(int[] items, int left, int right)
        {
            int i, j;
            int x, y;

            i = left; j = right;
            x = items[(left + right) / 2];

            do
            {
                while ((items[i] < x) && (i < right)) i++;
                while ((x < items[j]) && (j > left)) j--;

                if (i <= j)
                {
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) qsi(items, left, j);
            if (i < right) qsi(items, i, right);
        }
        public static void qsort(char[] items)
        {
        qs(items, 0, items.Length - 1);
        }
        static void qs(char[] items, int left, int right)
        {
            int i, j;
            char x, y;

            i = left; j = right;
            x = items[(left + right) / 2];

            do
            {
                while ((items[i] < x) && (i < right)) i++;
                while ((x < items[j]) && (j > left)) j--;

                if (i <= j)
                {
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++;j--;
                } 
            } while (i <=j);
            if (left < j) qs(items, left, j);
            if (i < right) qs(items, i, right);
        }
             
    }
    class Program
    {
        static void Main()
        {
            char[] a = {'d','h','t','e','q','j','k','y','l','m' };
            int i;
            int[] mas=new int[100];
            RandomProportional randObj = new RandomProportional();

            Console.WriteLine("Первоначальный масив: ");
            Console.WriteLine();
            for (i = 0; i < a.Length;)
            {
                
                    for (int j = 0; j < 5; j++)
                    {
                    if (i != a.Length)
                    {
                        Console.Write("| {0} |", a[i]);
                        i++;
                    }
                    else break;
                    }
                    i++;
                    Console.WriteLine();
                

            }

            Console.WriteLine();
            //Виполнение сортировки Char масива
            Quicksort.qsort(a);
            Console.WriteLine("Отсортированый масив: ");

            for (i = 0; i < a.Length;)
            {

                for (int j = 0; j < 5; j++)
                {
                    if (i != a.Length)
                    {
                        Console.Write("| {0} |", a[i]);
                        i++;
                    }
                    else break;
                }
                i++;
                Console.WriteLine();
            }
            //Иницыализация масива рандомными значениями
            for (i = 0; i < mas.Length; i++)
            {
                mas[i] = randObj.Next();
            }
            //Вывод масива на екран
            Console.WriteLine();
            Console.WriteLine("Первоначальный масив int: ");
            for (i = 0; i < mas.Length;)
            {

                for (int j = 0; j < 10; j++)
                {
                    if (i != mas.Length)
                    {
                        Console.Write("| {0} |", mas[i]);
                        i++;
                    }
                    else break;
                }
                i++;
                Console.WriteLine();
            }
            //Сортировка масива Int
            Quicksort.qsortI(mas);

            //Вывод масива на екран
            Console.WriteLine();
            Console.WriteLine("Сортированый масив int: ");
            for (i = 0; i < mas.Length;)
            {

                for (int j = 0; j < 10; j++)
                {
                    if (i != mas.Length)
                    {
                        Console.Write("| {0} |", mas[i]);
                        i++;
                    }
                    else break;
                }
                i++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
