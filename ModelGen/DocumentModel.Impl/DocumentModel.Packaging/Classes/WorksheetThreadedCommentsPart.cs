namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPart
/// </summary>
public partial class WorksheetThreadedCommentsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetThreadedCommentsPart
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
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
