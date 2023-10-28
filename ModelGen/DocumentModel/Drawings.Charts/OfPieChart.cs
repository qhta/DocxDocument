namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie of Pie or Bar of Pie Charts.
/// </summary>
public partial class OfPieChart
{
  
  /// <summary>
  ///   Pie of Pie or Bar of Pie Type.
  /// </summary>
  public DMDC.OfPieKind? OfPieType { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.GapWidth? GapWidth { get; set; }
  
  public DMDC.SplitKind? SplitType { get; set; }
  
  public DMDC.SplitPosition? SplitPosition { get; set; }
  
  public DMDC.CustomSplit? CustomSplit { get; set; }
  
  public UInt16? SecondPieSize { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
