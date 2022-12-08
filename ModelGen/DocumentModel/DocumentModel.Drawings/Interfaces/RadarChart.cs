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
  
  public Collection<RadarChartSeries1>? RadarChartSerieses { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public RadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
