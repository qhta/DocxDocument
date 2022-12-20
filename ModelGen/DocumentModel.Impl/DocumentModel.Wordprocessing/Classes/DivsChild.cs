namespace DocumentModel.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public partial class DivsChildImpl: ModelElementImpl, DivsChild
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.DivsChild? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DivsChild?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DivsChildImpl(): base() {}
  
  public DivsChildImpl(DocumentFormat.OpenXml.Wordprocessing.DivsChild openXmlElement): base(openXmlElement)
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
