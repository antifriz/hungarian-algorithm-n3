using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAlgorithms;

namespace AlgorithmTesting
{
    public class Program
    {
        static int[,] generateMatrix(int size)
        {
            var matrix = new int[size, size];

            var rnd = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rnd.Next()%size;

            return matrix;
        }

        static void printMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix:");
            var size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0,5:0}", matrix[i, j]);
                Console.WriteLine();
            }
        }

        static void printArray(int[] array)
        {
            Console.WriteLine("Array:");
            var size = array.Length;
            for (int i = 0; i < size; i++)
                    Console.Write("{0,5:0}", array[i]);
            Console.WriteLine();
        }

        static int Main()
        {
            const int SIZE = 10;

            var matrix = generateMatrix(SIZE);

            printMatrix(matrix);

            var algorithm = new HungarianAlgorithm(matrix);

            var result = algorithm.Run();

            printArray(result);

            Console.ReadKey();
            return 0;
        }
    }
}
