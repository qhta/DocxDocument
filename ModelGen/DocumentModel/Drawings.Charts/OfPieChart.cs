namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie of Pie or Bar of Pie Charts.
/// </summary>
public partial class OfPieChart
{
  
  /// <summary>
  ///   Pie of Pie or Bar of Pie Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.OfPieKind? OfPieType { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.GapWidth? GapWidth { get; set; }
  
  public DocumentModel.Drawings.Charts.SplitKind? SplitType { get; set; }
  
  public DocumentModel.Drawings.Charts.SplitPosition? SplitPosition { get; set; }
  
  public DocumentModel.Drawings.Charts.CustomSplit? CustomSplit { get; set; }
  
  public UInt16? SecondPieSize { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
