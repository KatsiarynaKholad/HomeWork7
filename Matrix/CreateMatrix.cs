using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class CreateMatrix
    {
        private int[,] matrix1 { get; set; }
        private int[,] matrix2 { get; set; }
        private int[,] matrix3 { get; set; }

        Random rnd = new Random();

        public async Task GetUserInput()
        {
            Console.WriteLine("Enter please a number of lines:");
            var isLines = int.TryParse(Console.ReadLine(), out var lines);

            Console.WriteLine("Enter please a number of columns:");
            var isColumns = int.TryParse(Console.ReadLine(), out var columns);

            matrix1 = new int[lines, columns];
            matrix2 = new int[lines, columns];
            matrix3 = new int[lines, columns];

            await FirstMatrixAsync();
            await SecondMatrixAsync();
            await ThirdMatrixAsync();
        }
           
        private void CreateTheFirstMatrix()
        {
            Console.WriteLine("The first matrix:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write($"{matrix1[i, j] = rnd.Next(100)} \t");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }
        }

        private void CreateTheSecondMatrix()
        {
            Console.WriteLine("The second matrix:");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i, j] = rnd.Next(100)} \t");
                    Thread.Sleep(10);

                }
                Console.WriteLine();
            }
        }

        private void DoMultiplication()
        {
            Console.WriteLine("Multiplication matrix:");

            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write($"{(matrix1[i, j] * matrix2[i, j])} \t");
                    matrix3[i, j] = (matrix1[i, j] + matrix2[i, j]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }
        }

        private async Task FirstMatrixAsync()
        {
            await Task.Run(() => CreateTheFirstMatrix());
        }

        private async Task SecondMatrixAsync()
        {
            await Task.Run(() => CreateTheSecondMatrix());
        }

        private async Task ThirdMatrixAsync()
        {
            await Task.Run(() => DoMultiplication());
        }
    }
}
