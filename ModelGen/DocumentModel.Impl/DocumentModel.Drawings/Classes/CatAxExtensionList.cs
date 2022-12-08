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
  
  public Collection<CatAxExtension>? CatAxExtensions
  {
    get;
    set;
  }
  
}
