namespace DocumentModel.Drawings;

/// <summary>
/// Pie Charts.
/// </summary>
public interface PieChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries1>? PieChartSerieses { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public PieChartExtensionList? PieChartExtensionList { get ; set; }
  
}
