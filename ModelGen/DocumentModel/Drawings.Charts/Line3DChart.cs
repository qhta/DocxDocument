namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Line Charts.
/// </summary>
public partial class Line3DChart
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
  
  public DocumentModel.Drawings.Charts.Line3DChartExtensionList? Line3DChartExtensionList { get; set; }
  
}
