namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public class FontsImpl: ModelElementImpl, Fonts
{
  public DocumentFormat.OpenXml.Wordprocessing.Fonts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Fonts?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontsImpl(): base() {}
  
  public FontsImpl(DocumentFormat.OpenXml.Wordprocessing.Fonts openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Font>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
