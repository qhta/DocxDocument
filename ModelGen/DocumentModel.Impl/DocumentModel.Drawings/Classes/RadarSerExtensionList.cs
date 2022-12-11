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
  
  public RadarSerExtensionListImpl(): base() {}
  
  public RadarSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<RadarSerExtension>? RadarSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
