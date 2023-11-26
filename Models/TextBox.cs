namespace Mitsubishi_Electric.Models
{
    public class TextBox : Rectangle
    {
        private string Text { get; set; }
        private string BackgroundColor { get; set; }

        public TextBox(string name, int x, int y, int width, int height, string backgroundColor, string text = "") : base(name, x, y, width, height)
        {
            Text = text;
            BackgroundColor = string.IsNullOrWhiteSpace(text) ? "red" : backgroundColor;
        }

        public override void Draw()
        {
            var size = Width * Height;
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) width={Width} height={Height} size={size} text='{Text}' bgColor={BackgroundColor}");
        }
    }
}