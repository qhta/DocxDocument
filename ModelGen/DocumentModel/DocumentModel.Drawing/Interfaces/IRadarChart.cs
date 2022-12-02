namespace DocumentModel.Drawing;

/// <summary>
/// Radar Charts.
/// </summary>
public interface IRadarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public DocumentModel.Drawing.RadarStyleKind? RadarStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IRadarChartSeries>? RadarChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IRadarChartExtensionList? RadarChartExtensionList { get ; set; }
  
}
