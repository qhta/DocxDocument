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
  
  public Collection<Font>? Items
  {
    get;
    set;
  }
  
}
