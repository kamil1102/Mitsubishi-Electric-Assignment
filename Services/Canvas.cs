using Mitsubishi_Electric.Models;

namespace Mitsubishi_Electric.Services
{
    public class Canvas
    {
        private readonly List<Widget> _widgets = new();

        public void AddWidget(Widget widget)
        {
            _widgets.Add(widget);
        }

        public void DrawWidgets()
        {
            foreach (var widget in _widgets)
            {
                widget.Draw();
            }
        }
    }
}
