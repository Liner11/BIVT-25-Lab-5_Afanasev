using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Purple
    {
        MatrixShow MS = new MatrixShow();
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            answer = new int[matrix.GetLength(1)];
            int currentcount;
            for(int y = 0; y < matrix.GetLength(1); y++)
            {
                currentcount = 0;
                for (int x = 0; x < matrix.GetLength(0); x++) if (matrix[x, y] < 0) currentcount++;
                answer[y] = currentcount;
            }
            //YES
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int minEl;
            int temp;
            int temp1;
            int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                minEl = matrix[x, 0];
                for (int y = 0; y < matrix.GetLength(1); y++) 
                {
                    if (matrix[x, y] < minEl) 
                    {
                        minEl = matrix[x, y];
                    }
                }
                if(minEl != matrix[x, 0])
                {
                    temp = matrix[x, 0];
                    matrix[x, 0] = minEl;
                    for (int y = 1; y < matrix.GetLength(1); y++)
                    {
                        if (matrix[x, y] != minEl)
                        {
                            temp1 = matrix[x, y];
                            matrix[x, y] = temp;
                            temp = temp1;
                        }
                        else if (matrix[x, y] == minEl)
                        {
                            matrix[x, y] = temp;
                            break;
                        }
                    }
                }
            }
            //YES
            // end

        }
        public int[,] Task3(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int maxEl;
            bool isA;
            answer = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                maxEl = matrix[x, 0];
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] > maxEl)
                    {
                        maxEl = matrix[x, y];
                    }
                }
                isA = false;
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] == maxEl && !isA)
                    {
                        isA = true;
                        answer[x, y] = matrix[x, y];
                        answer[x, y + 1] = maxEl;
                    }
                    else if (!isA) answer[x, y] = matrix[x, y];
                    else answer[x, y + 1] = matrix[x, y];
                }
            }
            //YES
            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here
            
            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here
            int[] maxLine = new int[matrix.GetLength(0)];
            int maxEl;
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                maxEl = matrix[x, 0];
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] > maxEl)
                    {
                        maxEl = matrix[x, y];
                    }
                }
                maxLine[x] = maxEl;
            }
            for(int y = matrix.GetLength(0) - 1; y >= 0; y--)
            {
                matrix[y, k] = maxLine[matrix.GetLength(0) - y - 1];
            }
            
            //YES
            // end

            }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here
            int maxEl;
            for(int x = 0; x < array.Length; x++)
            {
                maxEl = matrix[0, x];
                for(int y = 0; y < matrix.GetLength(0); y++)
                {
                    if (maxEl < matrix[y, x]) maxEl = matrix[y, x];
                }
                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    if (matrix[y, x] == maxEl && matrix[y, x] < array[x])
                    {
                        matrix[y, x] = array[x];
                        break;
                    }
                }
            }
            //YES
            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here
            int[] indexDependence = new int[matrix.GetLength(0)];
            int[] minDependence = new int[matrix.GetLength(0)];
            int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int minEl;
            int temp;
            int indexTemp;
            for(int y = 0; y < matrix.GetLength(0); y++)
            {
                minEl = matrix[y, 0];
                for(int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] < minEl)
                    {
                        minEl = matrix[y, x];
                    }
                }
                indexDependence[y] = y;
                minDependence[y] = minEl;
            }
            temp = minDependence[0];
            indexTemp = 0;
            for (int i = 0; i < minDependence.Length; i++)
            {
                for(int j = 0; j < minDependence.Length - i - 1; j++)
                {
                    if (minDependence[j + 1] > minDependence[j])
                    {
                        temp = minDependence[j];
                        minDependence[j] = minDependence[j + 1];
                        minDependence[j + 1] = temp;
                        indexTemp = indexDependence[j];
                        indexDependence[j] = indexDependence[j + 1];
                        indexDependence[j + 1] = indexTemp;
                    }
                }
            }
            for(int y = 0; y < answer.GetLength(0); y++)
            {
                for(int x = 0; x < answer.GetLength(1); x++)
                {
                    answer[y, x] = matrix[indexDependence[y], x];
                }
            }
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    matrix[y, x] = answer[y, x];
                }
            }
            
            //YES
            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int n = matrix.GetLength(0);
            int sum = 0;
            if(n == matrix.GetLength(1))
            {
                answer = new int[(n * 2) - 1];
                for(int x = 0; x < matrix.GetLength(0); x++)
                {
                    
                }
                answer[0] = sum;
            }
            
            
            MS.ShowMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine(string.Join(' ', answer));
            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here



            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here
            int n;
            int z;
            answer = new int[matrix.GetLength(0)][];
            for(int y = 0; y < matrix.GetLength(0); y++)
            {
                n = 0;
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] >= 0) n++;
                }
                answer[y] = new int[n];
            }
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                z = 0;
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] >= 0) answer[y][z++] = matrix[y, x];
                }
            }
            //YES
            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here

            int n = 0;
            for(int x = 0; x < array.Length; x++)
            {
                for(int y = 0; y < array[x].Length; y++)
                {
                    n++;
                }
            }
            n = (int)Math.Ceiling(Math.Sqrt(n));
            answer = new int[n, n];
            int i = 0, j = 0;
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    if(i == n)
                    {
                        i = 0;
                        j++;
                    }
                    answer[j, i++] = array[x][y];
                }
            }
            //YES
            // end

            return answer;
        }
    }
}