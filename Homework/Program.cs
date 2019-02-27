using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        // Метод деления матрицы А по строкам.
        static void Main()
        {
            var matrixA = new double[,]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
            };

            var matrixB = new double[,]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
            };

            var strCountTask = Console.ReadLine();
            if (!int.TryParse(strCountTask, out var countTask))
            {
                Console.WriteLine("Ожидалось чилсо");
                return;
            }

            if (countTask <= 0)
            {
                Console.WriteLine("Требуется положительное число");
                return;
            }

            var resultMatrix = MultiplicationMatrix(matrixA, matrixB, countTask);


            for (var i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write($"{resultMatrix[i, j]}, ");
                }

                Console.WriteLine();
            }
        }


        private static double[,] MultiplicationMatrix(double[,] matrixA, double[,] matrixB, int countTask)
        {
            if (matrixA == null || matrixB == null)
            {
                throw new ArgumentNullException("Матрица A или B равна нулю");
            }

            var countRowOfMatrixA = matrixA.GetLength(0);
            var countColumnOfMatrixA = matrixA.GetLength(1);

            var countRowOfMatrixB = matrixB.GetLength(0);
            var countColumnOfMatrixB = matrixB.GetLength(1);

            if (countColumnOfMatrixA != countRowOfMatrixB)
            {
                throw new ArgumentException(
                    "Количество стобцов первой матрицы не равно количеству строк второй матрицы");
            }

            var tasks = new Task[countTask];
            var resultMatrix = new double[countRowOfMatrixA, countColumnOfMatrixB];

            for (var i = 0; i < countTask; i++)
            {
                tasks[i] = Task.Factory.StartNew(() => MultiplicationPart(matrixA, matrixB, countRowOfMatrixA,
                    countColumnOfMatrixB,
                    countRowOfMatrixB, countTask, resultMatrix));
            }

            Task.WaitAll(tasks);
            return resultMatrix;
        }


        private static void MultiplicationPart(double[,] matrixA, double[,] matrixB, int countRowOfMatrixA,
            int countColumnOfMatrixB, int countRowOfMatrixB, int countTask,
            double[,] resultMatrix)
        {
            if (Task.CurrentId == null)
            {
                return;
            }

            var currentTaskId = Task.CurrentId.Value;
            var edgeOfTask = CalculateEdge(currentTaskId, countRowOfMatrixA, countTask);


            for (var i = edgeOfTask.X; i < edgeOfTask.Y; i++)
            {
                for (var j = 0; j < countColumnOfMatrixB; j++)
                {
                    for (var k = 0; k < countRowOfMatrixB; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
        }


        // Вычисляем границы для каждой таски, Если матрица не делится на равные части, то первая таска вычисляет свою часть плюс остаток от деления матрицы. 
        private static Point CalculateEdge(int currentTaskId, int countRowOfMatrixA, int countTask)
        {
            int firstRowInTask;
            int lastRowInTask;
            if (currentTaskId == 1)
            {
                firstRowInTask = 0;
                lastRowInTask = (countRowOfMatrixA / countTask) + (countRowOfMatrixA % countTask);
            }
            else
            {
                firstRowInTask = (currentTaskId - 1) * (countRowOfMatrixA / countTask) +
                                 (countRowOfMatrixA % countTask);
                lastRowInTask = firstRowInTask + (countRowOfMatrixA / countTask);
            }

            return new Point(firstRowInTask, lastRowInTask);
        }
    }
}