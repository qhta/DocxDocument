namespace DocumentModel.Drawings;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public interface Bar3DChart
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public BarDirectionKind? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public BarGroupingKind? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<BarChartSeries2>? BarChartSerieses { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public UInt16? GapWidth { get ; set; }
  
  public UInt16? GapDepth { get ; set; }
  
  public ShapeKind1? Shape { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public Bar3DChartExtensionList? Bar3DChartExtensionList { get ; set; }
  
}
