namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Bar Charts.
/// </summary>
public partial class Bar3DChart
{
  
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarDirectionKind? BarDirection { get; set; }
  
  
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarGroupingKind? BarGrouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.GapWidth? GapWidth { get; set; }
  
  public DocumentModel.Drawings.Charts.GapDepth? GapDepth { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeKind? Shape { get; set; }
  
  public DocumentModel.Drawings.Charts.Bar3DChartExtensionList? Bar3DChartExtensionList { get; set; }
  
}
