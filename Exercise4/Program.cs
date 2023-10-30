namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsEditor editor = new GraphicsEditor();

            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            Group group = new Group();
            group.AddPrimitive(circle);
            group.AddPrimitive(rectangle);
            group.AddPrimitive(triangle);

            editor.AddPrimitive(circle);
            editor.AddPrimitive(rectangle);
            editor.AddPrimitive(triangle);
            editor.AddPrimitive(group);

            editor.DrawAll();

            
            editor.MoveAll(10, 10); 
            editor.DrawAll();
        }
    }
}
