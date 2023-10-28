namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Area Charts.
/// </summary>
public partial class Area3DChart
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
  
  public DMDC.Area3DChartExtensionList? Area3DChartExtensionList { get; set; }
  
}
