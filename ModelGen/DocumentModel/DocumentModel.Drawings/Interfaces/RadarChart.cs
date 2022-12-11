namespace DocumentModel.Drawings;

/// <summary>
/// Radar Charts.
/// </summary>
public interface RadarChart
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public RadarStyleKind? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<RadarChartSeries>? RadarChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public RadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
