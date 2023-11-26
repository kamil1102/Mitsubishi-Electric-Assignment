namespace Mitsubishi_Electric.Models
{
    public class Ellipse : Widget
    {
        private int HorizontalDiameter { get; }
        private int VerticalDiameter { get; }

        public Ellipse(string name, int x, int y, int horizontalDiameter, int verticalDiameter) : base(name, x, y)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public override void Draw()
        {
            var size = Math.PI * (HorizontalDiameter / 2.0) * (VerticalDiameter / 2.0);
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) diameterH={HorizontalDiameter} diameterV={VerticalDiameter} size={size}");
        }
    }
}