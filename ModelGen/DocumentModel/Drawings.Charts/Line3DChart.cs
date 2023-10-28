namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Line Charts.
/// </summary>
public partial class Line3DChart
{
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  public DMDC.GroupingKind? Grouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.DropLines? DropLines { get; set; }
  
  public DMDC.GapDepth? GapDepth { get; set; }
  
  public DMDC.Line3DChartExtensionList? Line3DChartExtensionList { get; set; }
  
}
