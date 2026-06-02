namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the plot area of a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea?view=word-pia"/>
public partial interface IPlotArea : IInteropObject
{
  /// <summary>
  /// Returns a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a Border object that represents the border of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns or sets a Double value that represents the height, in points, of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// Returns a Font object that represents the font of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns a FillFormat object for a specified shape or a ChartFillFormat object for a specified chart that
  /// contains fill formatting properties for the shape or chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets a Double value that represents the distance, in points, from the left edge of the object to
  /// the left edge of the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Returns or sets a Double value that represents the distance, in points, from the top edge of the object to the
  /// top of row 1 (on a worksheet) or the top of the chart area (on a chart).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Returns or sets a Double value that represents the width, in points, of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.width?view=word-pia"/>
  public double Width { get; set; }

  /// <summary>
  /// Returns or sets the distance from the chart edge to the inside left edge of the plot area, in points.
  /// Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insideleft?view=word-pia"/>
  public double InsideLeft { get; set; }

  /// <summary>
  /// Returns or sets the distance from the chart edge to the inside top edge of the plot area, in points.
  /// Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insidetop?view=word-pia"/>
  public double InsideTop { get; set; }

  /// <summary>
  /// Returns or sets the inside width of the plot area, in points. Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insidewidth?view=word-pia"/>
  public double InsideWidth { get; set; }

  /// <summary>
  /// Returns or sets the inside height of the plot area, in points. Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insideheight?view=word-pia"/>
  public double InsideHeight { get; set; }

  /// <summary>
  /// Returns or sets the position of the plot area on the chart. Read/write ChartElementPosition.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.position?view=word-pia"/>
  public ChartElementPosition Position { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
