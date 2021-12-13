using System;

namespace HomeWork4
{
    class Program
    {
        static int Task1(int[] array)
        {
            int minValue = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (minValue > array[i + 1])
                {
                    minValue = array[i + 1];
                }
            }

            return minValue;
        }

        static int Task2(int[] array)
        {
            int maxValue = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (maxValue < array[i + 1])
                {
                    maxValue = array[i + 1];
                }
            }

            return maxValue;
        }

        static int Task3(int[] array)
        {
            int minValue = array[0];
            int minValueIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (minValue > array[i + 1])
                {
                    minValue = array[i + 1];
                    minValueIndex = i + 1;
                }
            }

            return minValueIndex;
        }

        static int Task4(int[] array)
        {
            int maxValue = array[0];
            int maxValueIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (maxValue < array[i + 1])
                {
                    maxValue = array[i + 1];
                    maxValueIndex = i + 1;
                }
            }

            return maxValueIndex;
        }

        static int Task5(int[] array)
        {
            int summ = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                summ += array[i];
            }

            return summ;
        }

        static int[] Task6(int[] array)
        {
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }

            return array;
        }

        static int Task7(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    ++count;
                }
            }

            return count;
        }

        static int[] Task8(int[] array)
        {
            int a = array.Length / 2;
            int b = a + array.Length % 2;

            for (int i = 0; i < a; i++)
            {
                int temp = array[i];
                array[i] = array[b + i];
                array[b + i] = temp;
            }

            return array;
        }

        static int[] Task9(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        static int[] Task10(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;
                while ((j >= 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int N = 6;
            int[] array = new int[N];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Task8(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
