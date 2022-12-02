namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public interface IRadarChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IRadarChartExtension>? RadarChartExtensions { get ; set; }
  
}
