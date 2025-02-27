namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public partial class DocumentImpl: ModelElementImpl, Document
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Document? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Document?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocumentImpl(): base() {}
  
  public DocumentImpl(DocumentFormat.OpenXml.Wordprocessing.Document openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentConformance? Conformance
  {
    get => (DocumentModel.Wordprocessing.DocumentConformance?)OpenXmlElement?.Conformance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Conformance = (DocumentFormat.OpenXml.Wordprocessing.DocumentConformance?)value;
    }
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentBackground? DocumentBackground
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocumentBackgroundImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocumentBackgroundImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Body.
  /// </summary>
  public DocumentModel.Wordprocessing.Body? Body
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Body>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BodyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Body>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BodyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
