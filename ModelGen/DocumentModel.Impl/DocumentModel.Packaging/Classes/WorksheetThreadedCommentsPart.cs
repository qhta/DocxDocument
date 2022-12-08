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
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
