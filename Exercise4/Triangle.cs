

namespace Exercise4
{
    internal class Triangle : GraphicPrimitive
    {
        private static Random random = new Random();

        public Triangle()
        {
            X = random.Next(100);
            Y = random.Next(100);
            Base = random.Next(1, 20);
            Height = random.Next(1, 20);
        }
        public int Base { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle at ({X}, {Y}) with base {Base} and height {Height}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Base = (int)(Base * factor);
            Height = (int)(Height * factor);
        }
    }
}
