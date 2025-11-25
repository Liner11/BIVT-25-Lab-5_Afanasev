using System.Globalization;

namespace Lab5
{
    public class Program
    {
        public static void Main()
        {
            int[,] input1 = {
                { 1, 2, 4, 6 },
                { 5, -6, 7, 11 },
                { -1, 4, -5, 6 },
                { 1, 4, 5, 6 }
            };
            int[,] input2 = {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 8, -9, 10, 11 },
                { 9, 10, -11, -12, -13, -14, -15 },
                { -13, -14, 15, 16, 17, 18, -19 }
            };

            MatrixShow MS = new MatrixShow();
            Purple purp = new Purple();
            purp.Task10(input1, input2);
            //Console.WriteLine(string.Join(' ', );
            
        }
    }
    public class MatrixShow()
    {

        public void ShowMatrix(int[,] matrix) 
        {
            for(int y = 0; y < matrix.GetLength(0); y++)
            {
                for(int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.Write($"{matrix[y, x]} ");
                }
                Console.WriteLine();
            }
        }
        public void ShowArrayMatrix(int[][] matrix)
        {
            for(int y = 0; y < matrix.Length; y++)
            {
                Console.WriteLine(string.Join(' ', matrix[y]));
            }
        }
    }
}
