namespace DocumentModel.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public class BlipExtensionListImpl: ModelElementImpl, BlipExtensionList
{
  public DocumentFormat.OpenXml.Drawing.BlipExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BlipExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<BlipExtension>? BlipExtensions
  {
    get;
    set;
  }
  
}
