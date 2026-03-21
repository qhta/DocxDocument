namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the tick-mark labels associated with tick marks on a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels?view=word-pia"/>
public partial interface TickLabels : InteropObject
{
  /// <summary>
  /// Returns the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns or sets the number format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// Returns or sets whether number format linked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformatlinked?view=word-pia"/>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// Returns or sets the number format local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformatlocal?view=word-pia"/>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// Returns or sets the orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.orientation?view=word-pia"/>
  public XlTickLabelOrientation Orientation { get; set; }

  /// <summary>
  /// Returns or sets the reading order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Returns or sets the auto scale font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Returns the depth.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.depth?view=word-pia"/>
  public int Depth { get; }

  /// <summary>
  /// Returns or sets the offset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.offset?view=word-pia"/>
  public int Offset { get; set; }

  /// <summary>
  /// Returns or sets the alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.alignment?view=word-pia"/>
  public int Alignment { get; set; }

  /// <summary>
  /// Returns or sets whether multi level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.multilevel?view=word-pia"/>
  public bool MultiLevel { get; set; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
