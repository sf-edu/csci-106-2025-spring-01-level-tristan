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
}