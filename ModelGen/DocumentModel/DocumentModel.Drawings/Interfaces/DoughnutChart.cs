namespace DocumentModel.Drawings;

/// <summary>
/// Doughnut Charts.
/// </summary>
public interface DoughnutChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries1>? PieChartSerieses { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public Byte? HoleSize { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
