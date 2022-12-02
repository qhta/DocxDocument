namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public interface IRadarChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IRadarChartExtension>? RadarChartExtensions { get ; set; }
  
}
