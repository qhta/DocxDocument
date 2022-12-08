namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public class RadarChartExtensionListImpl: ModelElementImpl, RadarChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<RadarChartExtension>? RadarChartExtensions
  {
    get;
    set;
  }
  
}
