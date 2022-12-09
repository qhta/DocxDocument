namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public class AutoCaptionsImpl: ModelElementImpl, AutoCaptions
{
  public DocumentFormat.OpenXml.Wordprocessing.AutoCaptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AutoCaptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<AutoCaption>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
