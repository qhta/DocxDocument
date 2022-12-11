namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetCommentsPart
/// </summary>
public class WorksheetCommentsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetCommentsPart
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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
