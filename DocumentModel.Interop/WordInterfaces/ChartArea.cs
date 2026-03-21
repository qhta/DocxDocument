namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the chart area of a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea?view=word-pia"/>
public partial interface ChartArea : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.width?view=word-pia"/>
  public double Width { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartarea.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
