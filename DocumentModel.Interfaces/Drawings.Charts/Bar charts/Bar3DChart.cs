namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D Bar Charts.
/// </summary>
public interface Bar3DChart
{
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public BarDirectionKind? BarDirection { get; set; }
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public BarGroupingKind? BarGrouping { get; set; }
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public BarChartSeriesList? BarChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public UInt16? GapWidth { get; set; }
  public UInt16? GapDepth { get; set; }
  public ShapeKind? Shape { get; set; }
  public AxisIds? AxisIds { get; set; }
  public Bar3DChartExtensionList? Bar3DChartExtensionList { get; set; }
}