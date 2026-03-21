namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the tick-mark labels associated with tick marks on a chart axis.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels?view=word-pia"/>
public partial interface TickLabels : InteropObject
{
  /// <summary>
  /// The font.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The number format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// The number format linked.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformatlinked?view=word-pia"/>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// The number format local.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformatlocal?view=word-pia"/>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.orientation?view=word-pia"/>
  public XlTickLabelOrientation Orientation { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The depth.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.depth?view=word-pia"/>
  public int Depth { get; }

  /// <summary>
  /// The offset.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.offset?view=word-pia"/>
  public int Offset { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.alignment?view=word-pia"/>
  public int Alignment { get; set; }

  /// <summary>
  /// The multi level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.multilevel?view=word-pia"/>
  public bool MultiLevel { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
