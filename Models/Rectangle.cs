namespace Mitsubishi_Electric.Models
{
    public class Rectangle : Widget
    {
        protected int Width { get; }
        protected int Height { get; }

        public Rectangle(string name, int x, int y, int width, int height) : base(name, x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            //assuming size is the area of the rectangle 
            var size = Width * Height;
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) width={Width} height={Height} size={size}");
        }
    }
}
