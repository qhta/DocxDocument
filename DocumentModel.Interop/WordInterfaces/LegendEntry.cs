namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry?view=word-pia"/>
public partial interface LegendEntry : InteropObject
{
  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.legendkey?view=word-pia"/>
  public LegendKey LegendKey { get; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
