namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the data label on a chart point or trendline.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel?view=word-pia"/>
public partial interface DataLabel : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The caption.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The horizontal alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The auto text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.autotext?view=word-pia"/>
  public bool AutoText { get; set; }

  /// <summary>
  /// The number format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.numberformat?view=word-pia"/>
  public string NumberFormat { get; set; }

  /// <summary>
  /// The number format linked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.numberformatlinked?view=word-pia"/>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// The number format local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.numberformatlocal?view=word-pia"/>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// The show legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showlegendkey?view=word-pia"/>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.type?view=word-pia"/>
  public object Type { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.position?view=word-pia"/>
  public XlDataLabelPosition Position { get; set; }

  /// <summary>
  /// The show series name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showseriesname?view=word-pia"/>
  public bool ShowSeriesName { get; set; }

  /// <summary>
  /// The show category name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showcategoryname?view=word-pia"/>
  public bool ShowCategoryName { get; set; }

  /// <summary>
  /// The show value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showvalue?view=word-pia"/>
  public bool ShowValue { get; set; }

  /// <summary>
  /// The show percentage.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showpercentage?view=word-pia"/>
  public bool ShowPercentage { get; set; }

  /// <summary>
  /// The show bubble size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showbubblesize?view=word-pia"/>
  public bool ShowBubbleSize { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.separator?view=word-pia"/>
  public object Separator { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// The _height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel._height?view=word-pia"/>
  public double _Height { get; }

  /// <summary>
  /// The _width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel._width?view=word-pia"/>
  public double _Width { get; }

  /// <summary>
  /// The formula.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// The formula r1 c1.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// The formula local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// The formula r1 c1 local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// The show range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.showrange?view=word-pia"/>
  public bool ShowRange { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.height?view=word-pia"/>
  public double Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datalabel.width?view=word-pia"/>
  public double Width { get; set; }
}
