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
  
  public DataLabels1? DataLabels { get ; set; }
  
  public RadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
