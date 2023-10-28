namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Bar Charts.
/// </summary>
public partial class Bar3DChart
{
  
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public DMDC.BarDirectionKind? BarDirection { get; set; }
  
  
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public DMDC.BarGroupingKind? BarGrouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.GapWidth? GapWidth { get; set; }
  
  public DMDC.GapDepth? GapDepth { get; set; }
  
  public DMDC.ShapeKind? Shape { get; set; }
  
  public DMDC.Bar3DChartExtensionList? Bar3DChartExtensionList { get; set; }
  
}
