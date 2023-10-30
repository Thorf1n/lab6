namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Quaternion q1 = new Quaternion(random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble());
            Quaternion q2 = new Quaternion(random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble());

            // Приклади використання операцій з випадковими значеннями
            Console.WriteLine("Quaternion 1: " + q1.W + ", " + q1.X + ", " + q1.Y + ", " + q1.Z);
            Console.WriteLine("Quaternion 2: " + q2.W + ", " + q2.X + ", " + q2.Y + ", " + q2.Z);

            Quaternion sum = q1 + q2;
            Console.WriteLine("Sum: " + sum.W + ", " + sum.X + ", " + sum.Y + ", " + sum.Z);

            Quaternion difference = q1 - q2;
            Console.WriteLine("Difference: " + difference.W + ", " + difference.X + ", " + difference.Y + ", " + difference.Z);

            Quaternion product = q1 * q2;
            Console.WriteLine("Product: " + product.W + ", " + product.X + ", " + product.Y + ", " + product.Z);

            double norm = q1.Norm();
            Console.WriteLine("Norm of Quaternion 1: " + norm);

            Quaternion conjugate = q1.Conjugate();
            Console.WriteLine("Conjugate of Quaternion 1: " + conjugate.W + ", " + conjugate.X + ", " + conjugate.Y + ", " + conjugate.Z);

            Quaternion inverse = q1.Inverse();
            Console.WriteLine("Inverse of Quaternion 1: " + inverse.W + ", " + inverse.X + ", " + inverse.Y + ", " + inverse.Z);

            bool areEqual = (q1 == q2);
            Console.WriteLine("Are Equal: " + areEqual);

            bool areNotEqual = (q1 != q2);
            Console.WriteLine("Are Not Equal: " + areNotEqual);

            double[,] rotationMatrix = q1.ToRotationMatrix();
            Console.WriteLine("Rotation Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(rotationMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}