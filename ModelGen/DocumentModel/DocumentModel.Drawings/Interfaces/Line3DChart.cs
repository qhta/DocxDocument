namespace DocumentModel.Drawings;

/// <summary>
/// 3D Line Charts.
/// </summary>
public interface Line3DChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public Line3DChartExtensionList? Line3DChartExtensionList { get ; set; }
  
}
