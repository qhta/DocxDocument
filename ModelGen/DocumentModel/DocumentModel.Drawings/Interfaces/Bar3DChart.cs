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
  
  public DataLabels1? DataLabels { get ; set; }
  
  public ShapeKind2? Shape { get ; set; }
  
  public Bar3DChartExtensionList? Bar3DChartExtensionList { get ; set; }
  
}
