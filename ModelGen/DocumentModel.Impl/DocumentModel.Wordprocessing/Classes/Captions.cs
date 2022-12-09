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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public AutoCaptions? AutoCaptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
