namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetCommentsPart
/// </summary>
public partial class WorksheetCommentsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetCommentsPart
{
  public new DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WorksheetCommentsPartImpl(): base() {}
  
  public WorksheetCommentsPartImpl(DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart openXmlElement): base(openXmlElement)
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
