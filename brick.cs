public class Brick 
{
    public double Width;
    public double Height;
    public double Thickness;
    private string Color;

    public double GetVolume ()
    {
        var width = 3;
        return Width * Height * Thickness;
    }

    public Brick(double width, double height, double thickness, string color)
{
    
    
        Width = width;
        Height = height;
        Thickness = thickness;
        Color = color;
    
}
public void SetColor(string color)
{
    Color = color;
}

public void PrintColor()
{
    Console.WriteLine($"The color of this brick is {Color}");
}
}