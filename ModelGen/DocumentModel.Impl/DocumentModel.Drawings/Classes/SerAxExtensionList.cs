namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public class SerAxExtensionListImpl: ModelElementImpl, SerAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SerAxExtensionListImpl(): base() {}
  
  public SerAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<SerAxExtension>? SerAxExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
