// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var brick = new Brick()
{
    Width = 1.2,
    Height = 3.4,
    Thickness = 5.6,
};

brick.GetVolume();

var brick2 = new Brick()
{
    Width = 9.8,
    Height = 7.6,
    Thickness = 5.4,
};

Console.WriteLine($"The volume of brick 1 is {brick.GetVolume()}!");
Console.WriteLine($"The volume of brick 1 is {brick2.GetVolume()}!");