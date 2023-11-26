namespace Mitsubishi_Electric.Models
{
    public abstract class Widget
    {
        protected string Name { get; }
        protected int X { get; }
        protected int Y { get; }

        protected Widget(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public abstract void Draw();
    }
}