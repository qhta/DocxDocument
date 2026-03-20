namespace DocumentModel.Interop;

/// <summary>
/// A collection of all the DataLabel objects for the specified series.
/// </summary>
public partial interface DataLabels : InteropObject, InteropCollection<DataLabel>
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
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The horizontal alignment.
  /// </summary>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  public object Orientation { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

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
  public Core.XlDataLabelPosition Position { get; set; }

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
  /// The show range.
  /// </summary>
  public bool ShowRange { get; set; }
}
