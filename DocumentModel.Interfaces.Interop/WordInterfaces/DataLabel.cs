namespace DocumentModel.Interop;

/// <summary>
/// Represents the data label on a chart point or trendline.
/// </summary>
public partial interface DataLabel : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The caption.
  /// </summary>
  public string Caption { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The horizontal alignment.
  /// </summary>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  public object Orientation { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The auto text.
  /// </summary>
  public bool AutoText { get; set; }

  /// <summary>
  /// The number format.
  /// </summary>
  public string NumberFormat { get; set; }

  /// <summary>
  /// The number format linked.
  /// </summary>
  public bool NumberFormatLinked { get; set; }

  /// <summary>
  /// The number format local.
  /// </summary>
  public object NumberFormatLocal { get; set; }

  /// <summary>
  /// The show legend key.
  /// </summary>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public object Type { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  public XlDataLabelPosition Position { get; set; }

  /// <summary>
  /// The show series name.
  /// </summary>
  public bool ShowSeriesName { get; set; }

  /// <summary>
  /// The show category name.
  /// </summary>
  public bool ShowCategoryName { get; set; }

  /// <summary>
  /// The show value.
  /// </summary>
  public bool ShowValue { get; set; }

  /// <summary>
  /// The show percentage.
  /// </summary>
  public bool ShowPercentage { get; set; }

  /// <summary>
  /// The show bubble size.
  /// </summary>
  public bool ShowBubbleSize { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  public object Separator { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }

  /// <summary>
  /// The _height.
  /// </summary>
  public double _Height { get; }

  /// <summary>
  /// The _width.
  /// </summary>
  public double _Width { get; }

  /// <summary>
  /// The formula.
  /// </summary>
  public string Formula { get; set; }

  /// <summary>
  /// The formula r1 c1.
  /// </summary>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// The formula local.
  /// </summary>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// The formula r1 c1 local.
  /// </summary>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// The show range.
  /// </summary>
  public bool ShowRange { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; set; }
}
