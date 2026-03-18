namespace DocumentModel.Interop;

/// <summary>
/// Represents the chart area of a chart.
/// </summary>
public partial interface ChartArea : InteropObject
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
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
