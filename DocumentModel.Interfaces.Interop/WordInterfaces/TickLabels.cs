namespace DocumentModel.Interop;

/// <summary>
/// Represents the tick-mark labels associated with tick marks on a chart axis.
/// </summary>
public partial interface TickLabels : InteropObject
{
  /// <summary>
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

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
  /// The orientation.
  /// </summary>
  public Core.XlTickLabelOrientation Orientation { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The depth.
  /// </summary>
  public int Depth { get; }

  /// <summary>
  /// The offset.
  /// </summary>
  public int Offset { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  public int Alignment { get; set; }

  /// <summary>
  /// The multi level.
  /// </summary>
  public bool MultiLevel { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
