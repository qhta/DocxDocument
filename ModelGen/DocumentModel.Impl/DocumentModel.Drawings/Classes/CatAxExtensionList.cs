namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public class CatAxExtensionListImpl: ModelElementImpl, CatAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CatAxExtensionListImpl(): base() {}
  
  public CatAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<CatAxExtension>? CatAxExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
