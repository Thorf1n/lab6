

namespace Exercise2
{
    internal class MathOperation
    {

        private Random random = new Random();

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int[] Add(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }

        public double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions");
            }

            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public double[,,] Add(double[,,] tensor1, double[,,] tensor2)
        {
            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor1.GetLength(2);

            if (dim1 != tensor2.GetLength(0) || dim2 != tensor2.GetLength(1) || dim3 != tensor2.GetLength(2))
            {
                throw new ArgumentException("Tensors must have the same dimensions");
            }

            double[,,] result = new double[dim1, dim2, dim3];
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] + tensor2[i, j, k];
                    }
                }
            }

            return result;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int[] Subtract(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] - array2[i];
            }

            return result;
        }

        public double[,] Subtract(double[,] matrix1, double[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions");
            }

            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public double[,,] Subtract(double[,,] tensor1, double[,,] tensor2)
        {
            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor1.GetLength(2);

            if (dim1 != tensor2.GetLength(0) || dim2 != tensor2.GetLength(1) || dim3 != tensor2.GetLength(2))
            {
                throw new ArgumentException("Tensors must have the same dimensions");
            }

            double[,,] result = new double[dim1, dim2, dim3];
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] - tensor2[i, j, k];
                    }
                }
            }

            return result;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int[] Multiply(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] * array2[i];
            }

            return result;
        }

        public double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix");
            }

            double[,] result = new double[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        public double[,,] Multiply(double[,,] tensor1, double[,,] tensor2)
        {
            int dim1 = tensor1.GetLength(0);
            int dim2 = tensor1.GetLength(1);
            int dim3 = tensor1.GetLength(2);

            if (dim3 != tensor2.GetLength(2))
            {
                throw new ArgumentException("Number of dimensions in the third axis must be equal");
            }

            double[,,] result = new double[dim1, dim2, dim3];
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] * tensor2[i, j, k];
                    }
                }
            }

            return result;
        }
    }
}
