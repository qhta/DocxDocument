namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the DataLabel objects for the specified series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels?view=word-pia"/>
public partial interface IDataLabels : IInteropObject, IInteropCollection<DataLabel>
{
  /// <summary>
  /// Gets the name of the `DataLabels` object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the border formatting for the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the interior formatting of the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets the font formatting for the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Gets or sets the horizontal alignment of the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the text orientation of the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the data labels have a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the reading order for the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the text of the data labels is generated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.autotext?view=word-pia"/>
  public bool AutoText { get; set; }

  /// <summary>
  /// Gets or sets the number format for the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the number format is linked to source cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.numberformatlinked?view=word-pia"/>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// Gets or sets the number format for the data labels in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.numberformatlocal?view=word-pia"/>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the legend key is displayed with the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showlegendkey?view=word-pia"/>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// Gets or sets the data label type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.type?view=word-pia"/>
  public object Type { get; set; }

  /// <summary>
  /// Gets or sets the position of the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.position?view=word-pia"/>
  public DataLabelPosition Position { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the series name is displayed in the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showseriesname?view=word-pia"/>
  public bool ShowSeriesName { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the category name is displayed in the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showcategoryname?view=word-pia"/>
  public bool ShowCategoryName { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the value is displayed in the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showvalue?view=word-pia"/>
  public bool ShowValue { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the percentage is displayed in the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showpercentage?view=word-pia"/>
  public bool ShowPercentage { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the bubble size is displayed in the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showbubblesize?view=word-pia"/>
  public bool ShowBubbleSize { get; set; }

  /// <summary>
  /// Gets or sets the separator text used between data label elements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.separator?view=word-pia"/>
  public object Separator { get; set; }

  /// <summary>
  /// Gets the chart formatting for the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the cell range is displayed in the data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.showrange?view=word-pia"/>
  public bool ShowRange { get; set; }


  #region methods

/// <summary>
  /// Selects the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabels.select?view=word-pia"/>
  public object Select();

  #endregion methods
}
