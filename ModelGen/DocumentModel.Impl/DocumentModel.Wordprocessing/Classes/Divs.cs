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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DivImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Div>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DivImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
