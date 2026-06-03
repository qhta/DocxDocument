namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the tick-mark labels associated with tick marks on a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels?view=word-pia"/>
public interface ITickLabels : IInteropObject
{
  /// <summary>
  /// Returns a ChartFont object that represents the font of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.font?view=word-pia"/>
  public IChartFont Font { get; }

  /// <summary>
  /// Returns a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns or sets a String value that represents the format code for the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// True if the number format is linked to the cells (so that the number format changes in the labels when it
  /// changes in the cells). Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformatlinked?view=word-pia"/>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// Returns or sets a Variant value that represents the format code for the object as a string in the language of
  /// the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.numberformatlocal?view=word-pia"/>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// Returns or sets a Long value that represents the text orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.orientation?view=word-pia"/>
  public TickLabelOrientation Orientation { get; set; }

  /// <summary>
  /// Returns or sets an ReadingOrder constant that represents the reading order for the specified object.
  /// Read/write Long.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Returns a Long value that represents the number of levels of category tick labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.depth?view=word-pia"/>
  public int Depth { get; }

  /// <summary>
  /// Returns or sets a Long value that represents the distance between the levels of labels, and the distance
  /// between the first level and the axis line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.offset?view=word-pia"/>
  public int Offset { get; set; }

  /// <summary>
  /// Returns or sets a Long value that represents the alignment for the specified phonetic text or tick label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.alignment?view=word-pia"/>
  public int Alignment { get; set; }

  /// <summary>
  /// Sets whether an axis is multilevel. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.multilevel?view=word-pia"/>
  public bool MultiLevel { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.format?view=word-pia"/>
  public IChartFormat Format { get; }


  #region methods

/// <summary>
  /// Deletes the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ticklabels.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
