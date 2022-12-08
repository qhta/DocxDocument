namespace DocumentModel.Drawings;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public interface Pie3DChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries1>? PieChartSerieses { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public Pie3DChartExtensionList? Pie3DChartExtensionList { get ; set; }
  
}
