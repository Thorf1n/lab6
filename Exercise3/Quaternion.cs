

namespace Exercise3
{
    internal class Quaternion
    {
        public double W { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Quaternion(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }


        public double[,] ToRotationMatrix()
        {
            double[,] matrix = new double[3, 3];

            double xx = X * X;
            double xy = X * Y;
            double xz = X * Z;
            double xw = X * W;

            double yy = Y * Y;
            double yz = Y * Z;
            double yw = Y * W;

            double zz = Z * Z;
            double zw = Z * W;

            matrix[0, 0] = 1 - 2 * (yy + zz);
            matrix[0, 1] = 2 * (xy - zw);
            matrix[0, 2] = 2 * (xz + yw);

            matrix[1, 0] = 2 * (xy + zw);
            matrix[1, 1] = 1 - 2 * (xx + zz);
            matrix[1, 2] = 2 * (yz - xw);

            matrix[2, 0] = 2 * (xz - yw);
            matrix[2, 1] = 2 * (yz + xw);
            matrix[2, 2] = 1 - 2 * (xx + yy);

            return matrix;
        }
        public Quaternion Conjugate()
        {
            return new Quaternion(W, -X, -Y, -Z);
        }
        public Quaternion Inverse()
        {
            double norm = Norm();
            if (norm != 0)
            {
                double invNorm = 1.0 / norm;
                Quaternion conjugate = Conjugate();
                return new Quaternion(conjugate.W * invNorm, conjugate.X * invNorm, conjugate.Y * invNorm, conjugate.Z * invNorm);
            }
            else
            {
                throw new InvalidOperationException("Quaternion has zero norm and cannot be inverted.");
            }
        }
        public double Norm()
        {
            return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
        }
        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            double w = q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z;
            double x = q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y;
            double y = q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X;
            double z = q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W;
            return new Quaternion(w, x, y, z);
        }
        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
        }
        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
        }
    }
}
