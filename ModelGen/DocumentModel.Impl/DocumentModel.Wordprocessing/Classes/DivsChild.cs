namespace DocumentModel.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public class DivsChildImpl: ModelElementImpl, DivsChild
{
  public DocumentFormat.OpenXml.Wordprocessing.DivsChild? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DivsChild?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Div>? Divs
  {
    get;
    set;
  }
  
}
