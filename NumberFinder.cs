using System;
using System.Collections.Generic;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if (number <= 0)
                throw new ArgumentException();
            List<int> digits = new List<int>();
            for (; number != 0; number /= 10)
            {
                digits.Add(number % 10);
            }
            int[] arr = digits.ToArray();
            Array.Reverse(arr);

            int i;
            for (i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    break;
                }
            }

            if (i == 0)
            {

            }
            else
            {
                int x = arr[i - 1], min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > x && arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                Swap(ref arr[i - 1], ref arr[min]);
                Array.Sort(arr, i, arr.Length-i);
            }
            return Int32.Parse(string.Join("", arr));
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
}

