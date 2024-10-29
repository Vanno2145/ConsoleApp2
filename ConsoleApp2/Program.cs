using System;

class Program
{
    public class Matrix
    {
        private int[,] matrix;

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
        }

        public int Rows { get { return matrix.GetLength(0); } }
        public int Columns { get { return matrix.GetLength(1); } }

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public void Input()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"Введите елемент [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        
        public int FindMaxElement()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        public int FindMinElement()
        {
            int min = matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Для сложения матрицы должны иметь одинаковые размеры");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Для сложения матрицы должны иметь одинаковые размеры");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Для сложения матрицы должны иметь одинаковые размеры");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] * b[i, j];
                }
            }
            return result;
        }
        public static string operator ==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Матрицы разные");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            int c = -1;
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        continue;
                    }
                    else
                    {
                        c = 1;
                        throw new ArgumentException("Матрицы разные");
                    }
                }
            }
            if (c == -1)
            {
                return "Матрицы равны";
            }
            else
            {
                throw new ArgumentException("Матрицы разные");
            }
          
        }
        public static string operator !=(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                Console.WriteLine("Матрицы разные");
            }

            Matrix result = new Matrix(a.Rows, a.Columns);
            int c = -1;
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        continue;
                    }
                    else
                    {
                        c = 1;
                        throw new ArgumentException("Матрицы разные");
                    }
                }
            }
            if (c == -1)
            {
                return"Матрицы равны";
            }
            else
            {
                throw new ArgumentException("Матрицы разные");
            }

        }
    }

    static void Main(string[] args)
    {

    }       
}


