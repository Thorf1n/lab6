
namespace Exercise4
{
    internal class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives;

        public GraphicsEditor()
        {
            primitives = new List<GraphicPrimitive>();
        }

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public void MoveAll(int x, int y)
        {
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }
    }
}
