// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Brick ConstructBrick(double width, double height, double thickness)
// {
//     return new Brick()
//     {
//         Width = width,
//         Height = height,
//         Thickness = thickness,
//     };
// }

var brick = new Brick(1.2, 3.4, 5.6, "red");
var brick2 = new Brick(6.5, 4.3, 2.1, "grey");

brick.PrintColor();
brick2.PrintColor();

// var brick = new Brick()
// {
//     Width = 1.2,
//     Height = 3.4,
//     Thickness = 5.6,
// };

//brick.GetVolume();

// var brick2 = new Brick()
// {
//     Width = 9.8,
//     Height = 7.6,
//     Thickness = 5.4,
// };

//Console.WriteLine($"The color of brick 1 is {brick.PrintColor}!");
//Console.WriteLine($"The color of brick 2 is {brick2.PrintColor}!");