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
  
  public Collection<SerAxExtension>? SerAxExtensions
  {
    get;
    set;
  }
  
}
