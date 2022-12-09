namespace DocumentModel.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public class HyperlinkExtensionListImpl: ModelElementImpl, HyperlinkExtensionList
{
  public DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<HyperlinkExtension>? HyperlinkExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
