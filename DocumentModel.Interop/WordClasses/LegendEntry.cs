namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry?view=word-pia"/>
public partial class LegendEntry : InteropObject
{
  /// <summary>
  /// Returns a font object that represents the font of the legend entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.font?view=word-pia"/>
  public ChartFont Font { get; set; }

  /// <summary>
  /// Returns the index number of the legend entry in the legend entries collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns a legend key object for the legend entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.legendkey?view=word-pia"/>
  public LegendKey LegendKey { get; set; }

  /// <summary>
  /// Returns or sets whether the legend entry text scales automatically when the chart size changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Returns the distance, in points, from the left edge of the chart area to the left edge of the legend entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Returns the distance, in points, from the top edge of the chart area to the top edge of the legend entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Returns the width of the legend entry, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.width?view=word-pia"/>
  public double Width { get; set; }

  /// <summary>
  /// Returns the height of the legend entry, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// Returns the chart format properties for the legend entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.format?view=word-pia"/>
  public ChartFormat Format { get; set; }
}
