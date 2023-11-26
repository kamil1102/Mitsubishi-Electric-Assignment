namespace Mitsubishi_Electric.Models
{
    public class Square : Widget
    {
        private int Side { get; }

        public Square(string name, int x, int y, int side) : base(name, x, y)
        {
            Side = side;
        }

        public override void Draw()
        {
            //assuming size is the area of the square 
            var size = Side * Side;
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) size={size}");
        }
    }
}