using System;

namespace recruiting_exercise_1
{
    //  A multifunction program creates a 10-element list that takes two integers:
    //  1. Calculates the factorial from the first value.
    //  2. Divides the first value by the second.
    //  3. Returns the square root of the result from point 2.
    //  Every next element in the list, the algorithm repeats itself, increasing the first value by 1
    //  Sorts ascendingly using QuickSort

    class Program
    {
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Square(double n)
        {
            double root = n / 3;
            for (int i = 0; i < 32; i++)
            {
                root = (root + n / root) / 2;
            }

            return root;
        }

        public static double CollectiveFunction(int a, int b)
        {
            double firstStep = Factorial(a);
            double secondStep = Divide(firstStep, b);
            double finalStep = Square(secondStep);
            return finalStep;
        }

        public static int Partition(double[] arr, int start, int end)
        {
            double temp;
            double p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        public static void QuickSort(double[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        public static double[] Multifunction(int a, int b)
        {
            double[] array = new Double[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = CollectiveFunction(a, b);
                a++;
            }

            QuickSort(array, 0, array.Length - 1);
            return array;
        }

        public static void Main(string[] args)
        {
            //  Przykład liczący elementy:
            //  4! = 24 -> 24/6 = 4 -> (4)^(1/2) = 2
            //  następny element:
            //  5! = 120 -> 120/6 = 20 - > (20)^(1/2) = 4,47
            // itd...
            
            double[] array1 = Multifunction(4, 6);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + ", ");
            }

        }
    }
}