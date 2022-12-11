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
  
  public CaptionsImpl(): base() {}
  
  public CaptionsImpl(DocumentFormat.OpenXml.Wordprocessing.Captions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Caption? Caption
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
