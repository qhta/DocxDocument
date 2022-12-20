namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public partial class ContentPartImpl: ModelElementImpl, ContentPart
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ContentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ContentPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ContentPartImpl(): base() {}
  
  public ContentPartImpl(DocumentFormat.OpenXml.Wordprocessing.ContentPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
