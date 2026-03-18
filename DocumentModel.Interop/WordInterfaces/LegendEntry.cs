namespace DocumentModel.Interop;

/// <summary>
/// Represents a legend entry in a chart legend.
/// </summary>
public partial interface LegendEntry : InteropObject
{
  /// <summary>
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The legend key.
  /// </summary>
  public LegendKey LegendKey { get; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
