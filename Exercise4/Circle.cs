

namespace Exercise4
{
    internal class Circle : GraphicPrimitive
    {
        private static Random random = new Random();

        public Circle()
        {
            X = random.Next(100);
            Y = random.Next(100); 
            Radius = random.Next(1, 20); 
        }
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle at ({X}, {Y}) with radius {Radius}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            Radius = (int)(Radius * factor);
        }
    }
}
