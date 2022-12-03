namespace DocumentModel.Drawings;

/// <summary>
/// Radar Charts.
/// </summary>
public interface RadarChart // : DocumentModel.BaseTypes.ModelElement
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
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public RadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
