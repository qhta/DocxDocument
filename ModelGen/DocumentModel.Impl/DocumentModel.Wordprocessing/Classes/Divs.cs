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
  
  public Collection<Div>? Items
  {
    get;
    set;
  }
  
}
