namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Area Charts.
/// </summary>
public partial class AreaChart
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
  
  public DocumentModel.Drawings.Charts.AreaChartExtensionList? AreaChartExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
