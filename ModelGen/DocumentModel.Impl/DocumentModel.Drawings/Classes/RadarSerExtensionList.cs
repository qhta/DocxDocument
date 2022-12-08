namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public class RadarSerExtensionListImpl: ModelElementImpl, RadarSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<RadarSerExtension>? RadarSerExtensions
  {
    get;
    set;
  }
  
}
