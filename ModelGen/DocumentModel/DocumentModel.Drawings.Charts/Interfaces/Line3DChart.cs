namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public interface Line3DChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.LineChartSeries>? LineChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get ; set; }
  
  public UInt16? GapDepth { get ; set; }
  
  public Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawings.Charts.Line3DChartExtensionList? Line3DChartExtensionList { get ; set; }
  
}
