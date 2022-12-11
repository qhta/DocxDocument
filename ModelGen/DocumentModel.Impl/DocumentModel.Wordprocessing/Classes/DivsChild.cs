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
  
  public DivsChildImpl(): base() {}
  
  public DivsChildImpl(DocumentFormat.OpenXml.Wordprocessing.DivsChild openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Div? Div
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
