using DocumentModel.Interop.Core;

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the legend in a chart. Each chart can have only one legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend?view=word-pia"/>
public partial interface Legend : InteropObject
{
  /// <summary>
  /// Returns the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a border object that represents the legend border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns a font object that represents the legend font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Returns or sets the position of the legend on the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.position?view=word-pia"/>
  public LegendPosition Position { get; set; }

  /// <summary>
  /// Returns or sets whether the legend has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Returns or sets the height of the legend, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// Returns an interior object that represents the interior of the legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns fill formatting properties for the legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets the distance, in points, from the left edge of the chart area to the left edge of the legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Returns or sets the distance, in points, from the top edge of the chart area to the top edge of the legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Returns or sets the width of the legend, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.width?view=word-pia"/>
  public double Width { get; set; }

  /// <summary>
  /// Returns or sets whether the legend text scales automatically when the chart size changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Returns or sets whether the legend is included in the chart layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.includeinlayout?view=word-pia"/>
  public bool IncludeInLayout { get; set; }

  /// <summary>
  /// Returns the chart format properties for the legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legend.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
