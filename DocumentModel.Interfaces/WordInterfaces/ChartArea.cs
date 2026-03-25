namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the chart area of a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea?view=word-pia"/>
public partial interface ChartArea : InteropObject
{
  /// <summary>
  /// Gets the name of the chart area object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the border formatting for the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the font formatting used in the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart area has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the height of the chart area, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// Gets the interior formatting of the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the chart area to the left edge of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the chart area to the top edge of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Gets or sets the width of the chart area, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.width?view=word-pia"/>
  public double Width { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets the chart formatting for the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
