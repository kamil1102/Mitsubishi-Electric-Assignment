using Mitsubishi_Electric.Models;
using Mitsubishi_Electric.Services;

var canvas = new Canvas();

//Assuming that "size" refers to the area oth the widget

canvas.AddWidget(new Square("Square1", 10, 10, 10));
canvas.AddWidget(new Rectangle("Rectangle1", 15, 30, 40, 60));
canvas.AddWidget(new Circle("Circle1", 5, 5, 15));
canvas.AddWidget(new Ellipse("Ellipse1", 100, 150, 300, 200));
canvas.AddWidget(new TextBox("TextBox1", 10, 200, 80, 50,"yellow", "Sample Text"));
canvas.AddWidget(new TextBox("TextBox1", 50, 50, 100, 20, "yellow"));


canvas.DrawWidgets();