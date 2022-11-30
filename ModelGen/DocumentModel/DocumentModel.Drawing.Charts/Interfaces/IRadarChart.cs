namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public interface IRadarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public DocumentModel.Drawing.Charts.RadarStyleKind? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IRadarChartSeries>? RadarChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.IRadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
