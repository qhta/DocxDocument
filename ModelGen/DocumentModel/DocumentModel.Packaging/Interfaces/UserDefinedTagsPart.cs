namespace DocumentModel.Packaging;

/// <summary>
/// Defines the UserDefinedTagsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.presentationml.tags+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags")]
public interface UserDefinedTagsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.TagList? TagList { get ; set; }
  
}
