namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public partial class Bar3DChart
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarDirectionKind? BarDirection { get; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarGroupingKind? BarGrouping { get; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.BarChartSeries>? BarChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public UInt16? GapWidth { get; set; }
  
  public UInt16? GapDepth { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeKind? Shape { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.Bar3DChartExtensionList? Bar3DChartExtensionList { get; set; }
  
}
