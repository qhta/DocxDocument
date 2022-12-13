namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public class ParagraphMarkRunPropertiesChangeImpl: ModelElementImpl, ParagraphMarkRunPropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParagraphMarkRunPropertiesChangeImpl(): base() {}
  
  public ParagraphMarkRunPropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement): base(openXmlElement)
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
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
