namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        // var svg = new SvgBuilder(500, 500)
        // .AddRectangle(100,50,150,200,"#FF0000")
        // .AddRectangle(40,80,10,100,"#00FFF0")
        // .AddRectangle(300,80,400,1500,"#0000FF")
        // .AddRectangle(400,100,300,200,"#FF0F00")
        // .AddRectangle(200,25,40,150,"#FFFF00")
        // .AddRectangle(100,300,150,200,"#FF00FF")

        
       


        // .Build();

        var svgBuilder = new SvgBuilder(500, 500);
        var gridBuilder = new GridBuilder(svgBuilder, 8);

        var inputPath = "../input.txt";
        using var streamReader = new StreamReader(inputPath);

        foreach (var line in streamReader.ReadToEnd().Split('\n')) {
            gridBuilder.Parse(line);
        }

        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svgBuilder.Build());
    }
}
