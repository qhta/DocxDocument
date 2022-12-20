namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public partial class ParagraphPropertiesChangeImpl: ModelElementImpl, ParagraphPropertiesChange
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ParagraphPropertiesChangeImpl(): base() {}
  
  public ParagraphPropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
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
  
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphPropertiesExtended? ParagraphPropertiesExtended
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesExtended>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ParagraphPropertiesExtendedImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesExtended>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ParagraphPropertiesExtendedImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
