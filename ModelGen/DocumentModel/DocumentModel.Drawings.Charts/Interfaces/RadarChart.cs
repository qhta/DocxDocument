namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public partial interface RadarChart
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.RadarStyleKind? RadarStyle { get; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.RadarChartSeries>? RadarChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.RadarChartExtensionList? RadarChartExtensionList { get; set; }
  
}
