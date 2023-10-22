namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Area Charts.
/// </summary>
public partial class Area3DChart
{
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupingKind? Grouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get; set; }
  
  public DocumentModel.Drawings.Charts.GapDepth? GapDepth { get; set; }
  
  public DocumentModel.Drawings.Charts.Area3DChartExtensionList? Area3DChartExtensionList { get; set; }
  
}
