namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public partial interface Pie3DChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.PieChartSeries>? PieChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.Pie3DChartExtensionList? Pie3DChartExtensionList { get; set; }
  
}
