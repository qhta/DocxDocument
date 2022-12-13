namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
public interface PieChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.PieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public DocumentModel.Drawings.Charts.PieChartExtensionList? PieChartExtensionList { get ; set; }
  
}
