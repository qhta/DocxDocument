namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the plot area of a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea?view=word-pia"/>
public partial interface PlotArea : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns or sets the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// Returns the interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Returns or sets the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Returns or sets the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.width?view=word-pia"/>
  public double Width { get; set; }

  /// <summary>
  /// Returns or sets the inside left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insideleft?view=word-pia"/>
  public double InsideLeft { get; set; }

  /// <summary>
  /// Returns or sets the inside top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insidetop?view=word-pia"/>
  public double InsideTop { get; set; }

  /// <summary>
  /// Returns or sets the inside width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insidewidth?view=word-pia"/>
  public double InsideWidth { get; set; }

  /// <summary>
  /// Returns or sets the inside height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.insideheight?view=word-pia"/>
  public double InsideHeight { get; set; }

  /// <summary>
  /// Returns or sets the position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.position?view=word-pia"/>
  public XlChartElementPosition Position { get; set; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.plotarea.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
