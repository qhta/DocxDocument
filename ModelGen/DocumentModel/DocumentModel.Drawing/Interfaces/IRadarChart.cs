namespace DocumentModel.Drawing;

/// <summary>
/// Radar Charts.
/// </summary>
public interface IRadarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public RadarStyleKind? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IRadarChartSeries>? RadarChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IRadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
