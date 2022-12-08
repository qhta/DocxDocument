namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public class CaptionsImpl: ModelElementImpl, Captions
{
  public DocumentFormat.OpenXml.Wordprocessing.Captions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Captions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Caption>? Items
  {
    get;
    set;
  }
  
  public AutoCaptions? AutoCaptions
  {
    get;
    set;
  }
  
}
