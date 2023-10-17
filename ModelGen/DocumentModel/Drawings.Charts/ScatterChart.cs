namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Scatter Charts.
/// </summary>
public partial class ScatterChart
{
  
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.ScatterStyleKind? ScatterStyle { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.ScatterChartExtensionList? ScatterChartExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
