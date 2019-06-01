using System;
using System.Collections.Generic;
using System.Text;

namespace MohammedAdnanTasSol
{
	class Solution
	{
		public static int solution(int[] A)
		{
            Console.Write("Enter array's length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            if (checkArrayLength(arrayLength) == true)
            {
                A = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.Write("Enter element number {0} of the array: ", i + 1);
                    A[i] = int.Parse(Console.ReadLine());
                }

                sortingArrayAscending(A);
                Console.WriteLine(string.Join(",", A));

                int counter = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                            if (A[i] == A[j])
                            {
                            counter += 1;
                            if (counter > (arrayLength / 2))
                            {
                                return A[i];
                            }
                        }
                    }
                    counter = 0;
                }
            }
            return -1;
		}

        public static bool checkArrayLength(int arrayLength)
        {
            if ((arrayLength > 0) && (arrayLength < 100000))
            {
                return true;
            }
            Console.WriteLine("The range of the array should be only between 1 and 100,000");
            return false;
        }

        public static void sortingArrayAscending(int[] array)
        {
            Array.Sort(array);
        }
    }
}