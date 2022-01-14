using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec5_3_1_array
{
    internal class Program
    {
        static int[] CreateArray1(int size)
        {
            int[] array1 = new int[size];
            for (int i = 0; i < size; i++)
            {
                array1[i] = i;
            }
            return array1;
        }

        static int[,] CreateArray2(int nRow, int nCol)
        {
            int index = 0;
            int[,] array2 = new int[nRow, nCol];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    array2[i,j] = index++;
                }
                
            }
            return array2;
        }

        static void Main(string[] args)
        {
            int[] arr1;
            int[,] arr2;
            int arr1_size = 5;
            int arr2_size1 = 2;
            int arr2_size2 = 3;
            arr1 = CreateArray1(arr1_size);
            arr2 = CreateArray2(arr2_size1, arr2_size2);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }
            Console.WriteLine();
            for (int i=0; i<arr2_size1; i++)
            {
                for(int j=0;j<arr2_size2;j++)
                {
                    Console.Write(arr2[i, j]);
                }
                Console.WriteLine();


            }
        }
    }
}
