namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Divs Class.
/// </summary>
public class DivsImpl: ModelElementImpl, Divs
{
  public DocumentFormat.OpenXml.Wordprocessing.Divs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Divs?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DivsImpl(): base() {}
  
  public DivsImpl(DocumentFormat.OpenXml.Wordprocessing.Divs openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.Div? Div
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
