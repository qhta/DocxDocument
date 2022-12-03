namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
[ContentMime("application/vnd.ms-office.documenttasks+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2019/05/relationships/documenttasks")]
public interface DocumentTasksPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Tasks? Tasks { get ; set; }
  
}
