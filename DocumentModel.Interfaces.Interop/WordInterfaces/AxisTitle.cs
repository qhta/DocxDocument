namespace DocumentModel.Interop;

/// <summary>
/// True if an axis title will occupy the chart layout space when a chart layout is being determined. The default value is True. Read/write
/// </summary>
public partial interface AxisTitle : InteropObject
{
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
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The include in layout.
  /// </summary>
  public bool IncludeInLayout { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  public Core.XlChartElementPosition Position { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; }

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
}
