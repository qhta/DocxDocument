namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the data label on a chart point or trendline.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel?view=word-pia"/>
public partial interface DataLabel : InteropObject
{
  /// <summary>
  /// Gets the name of the data label object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the border formatting for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the interior formatting of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets or sets the caption text for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Gets the font formatting for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Gets or sets the horizontal alignment of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the chart area to the left edge of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Gets or sets the text orientation of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the data label has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the text of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the chart area to the top edge of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the reading order for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the text of the data label is generated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.autotext?view=word-pia"/>
  public bool AutoText { get; set; }

  /// <summary>
  /// Gets or sets the number format for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the number format is linked to the source cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.numberformatlinked?view=word-pia"/>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// Gets or sets the number format for the data label in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.numberformatlocal?view=word-pia"/>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the legend key is displayed with the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showlegendkey?view=word-pia"/>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// Gets or sets the data label type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.type?view=word-pia"/>
  public object Type { get; set; }

  /// <summary>
  /// Gets or sets the position of the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.position?view=word-pia"/>
  public DataLabelPosition Position { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the series name is displayed in the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showseriesname?view=word-pia"/>
  public bool ShowSeriesName { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the category name is displayed in the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showcategoryname?view=word-pia"/>
  public bool ShowCategoryName { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the value is displayed in the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showvalue?view=word-pia"/>
  public bool ShowValue { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the percentage is displayed in the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showpercentage?view=word-pia"/>
  public bool ShowPercentage { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the bubble size is displayed in the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showbubblesize?view=word-pia"/>
  public bool ShowBubbleSize { get; set; }

  /// <summary>
  /// Gets or sets the separator text used between data label elements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.separator?view=word-pia"/>
  public object Separator { get; set; }

  /// <summary>
  /// Gets the chart formatting for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Gets the height of the data label, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel._height?view=word-pia"/>
  public double _Height { get; }

  /// <summary>
  /// Gets the width of the data label, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel._width?view=word-pia"/>
  public double _Width { get; }

  /// <summary>
  /// Gets or sets the formula for the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// Gets or sets the formula for the data label in R1C1-style notation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// Gets or sets the formula for the data label in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// Gets or sets the formula for the data label in R1C1-style notation in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the cell range is displayed in the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showrange?view=word-pia"/>
  public bool ShowRange { get; set; }

  /// <summary>
  /// Gets or sets the height of the data label, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// Gets or sets the width of the data label, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.width?view=word-pia"/>
  public double Width { get; set; }
}
