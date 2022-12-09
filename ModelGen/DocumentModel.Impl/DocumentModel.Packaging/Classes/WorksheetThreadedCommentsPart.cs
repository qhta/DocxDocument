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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
