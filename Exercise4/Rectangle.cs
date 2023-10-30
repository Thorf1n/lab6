using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Rectangle : GraphicPrimitive
    {
        private static Random random = new Random();

        public Rectangle()
        {
            X = random.Next(100);
            Y = random.Next(100);
            Width = random.Next(1, 20);
            Height = random.Next(1, 20);
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Rectangle at ({X}, {Y}) with width {Width} and height {Height}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Width = (int)(Width * factor);
            Height = (int)(Height * factor);
        }
    }
}
