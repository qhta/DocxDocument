namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public interface RadarChart
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.RadarStyleKind? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.RadarChartSeries>? RadarChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public DocumentModel.Drawings.Charts.RadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
