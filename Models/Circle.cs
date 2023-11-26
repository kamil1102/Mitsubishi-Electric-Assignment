namespace Mitsubishi_Electric.Models
{
    public class Circle : Widget
    {
        private int Radius { get; }

        public Circle(string name, int x, int y, int radius) : base(name, x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            var size = Math.PI * Radius * Radius;
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) size={size}");
        }
    }
}