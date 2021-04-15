using System;

namespace Task_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            TwoPowIndex();
            Console.WriteLine();
            int[] arr1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[10] { 88, 2, 3, 4, 12, 0, 7, 8, 9, 9 };
            SwapMaxAndMinElement(arr1);
            SwapMaxAndMinElement(arr2);
            Console.WriteLine(FindMeanValue(arr1));
            Console.WriteLine(FindMeanValue(arr2));

        }

        //Outputs an array of indices to the power of 2
        public static void TwoPowIndex()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Pow(2, i);
                Console.Write(arr[i] + " ");
            }
        }

        //Swap maximum and minimum elemnts in array
        public static void SwapMaxAndMinElement(int[] arr)
        {
            Console.Write("Initial array: ");
            foreach (int c in arr)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            int max = arr[0];
            int min = arr[0];
            int maxIndex = 0;
            int minIndex = 0;
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max > arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }
                if (min < arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            temp = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = temp;

            Console.Write("Modified array: ");
            foreach (int c in arr)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        //Find a mean value in array
        public static double FindMeanValue(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double meanValue = sum / arr.Length;
            return meanValue;
        }
    }
}