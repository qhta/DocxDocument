namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie Charts.
/// </summary>
public partial class PieChart
{
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public UInt16? FirstSliceAngle { get; set; }
  
  public DocumentModel.Drawings.Charts.PieChartExtensionList? PieChartExtensionList { get; set; }
  
  public DM.ElementCollection<PieChartSeries>? Items { get; set; }
  
}
