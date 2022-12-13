namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPart
/// </summary>
public class WorksheetThreadedCommentsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetThreadedCommentsPart
{
  public new DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WorksheetThreadedCommentsPartImpl(): base() {}
  
  public WorksheetThreadedCommentsPartImpl(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
