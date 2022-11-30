namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public interface IRadarChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IRadarChartExtension>? RadarChartExtensions { get ; set; }
  
}
