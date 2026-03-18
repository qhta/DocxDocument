namespace DocumentModel.Interop;

/// <summary>
/// Represents a chart data table.
/// </summary>
public partial interface DataTable : InteropObject
{
  /// <summary>
  /// The show legend key.
  /// </summary>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// The has border horizontal.
  /// </summary>
  public bool HasBorderHorizontal { get; set; }

  /// <summary>
  /// The has border vertical.
  /// </summary>
  public bool HasBorderVertical { get; set; }

  /// <summary>
  /// The has border outline.
  /// </summary>
  public bool HasBorderOutline { get; set; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
