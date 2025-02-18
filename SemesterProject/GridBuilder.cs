using System.Collections.ObjectModel;
using System.Drawing;

namespace SemesterProject;

public interface IGridBuilder
{
    /// <summary>
    /// Parses a line with the format `([x], [y]) [color]` and add it to the
    /// SVG builder as a rectangle.
    /// </summary>
    /// <param name="line">The line to parse.</param>
    public void Parse(string line);
}

public class GridBuilder : IGridBuilder
{
    /// <summary>
    /// A reference to an SVG builder. We keep this so that we can add
    /// rectangles to it without having to constantly pass it around.
    /// </summary>
    private readonly ISvgBuilder SvgBuilder;

    /// <summary>
    /// The size of the grid to build. For example, a grid size of 8 will
    /// result in individual grid cells being 8 by 8 units.
    /// </summary>
    private readonly int GridSize;

    /// <summary>
    /// Initialize a new grid builder.
    /// </summary>
    /// <param name="svgBuilder">The SVG builder to reference later.</param>
    /// <param name="gridSize">The size of the grid.</param>
    public GridBuilder(ISvgBuilder svgBuilder, int gridSize)
    {
        SvgBuilder = svgBuilder;
        GridSize = gridSize;
        gridSize = 4;
    }

    public void Parse(string line)
    {
    //    (0, 0) #ff0000
    var globs = line.Split(' ').Select(glob => glob.Replace("(",string.Empty).Replace(")",string.Empty).Replace(",",string.Empty)).ToList();
    
       var x = int.Parse(globs[0]);
       var y = int.Parse(globs[1]);
       var color = globs[2];

       SvgBuilder.AddRectangle(x*GridSize,y*GridSize,GridSize,GridSize,color);
    }
}
