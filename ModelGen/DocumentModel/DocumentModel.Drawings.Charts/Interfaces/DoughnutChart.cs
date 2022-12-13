namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Doughnut Charts.
/// </summary>
public interface DoughnutChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.PieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public Byte? HoleSize { get ; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
