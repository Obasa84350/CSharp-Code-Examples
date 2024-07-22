using System;

namespace CSharp_Code_Examples.Basic
{
    public static class SortingAlgorithms
    {
        // Authors: Obasa Joseph
        // Demonstrating the implementation of Bubble Sort and Quick Sort algorithms
        public static void run()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            BubbleSort(array);
            Console.WriteLine("\nArray after Bubble Sort:");
            PrintArray(array);

            array = new int[] { 64, 34, 25, 12, 22, 11, 90 }; // Reset array
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("\nArray after Quick Sort:");
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j+1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    // Swap array[i] and array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            // Swap array[i+1] and array[high] (or pivot)
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
