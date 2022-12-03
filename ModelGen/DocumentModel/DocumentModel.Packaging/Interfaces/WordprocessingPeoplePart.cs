namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.people+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2011/relationships/people")]
public interface WordprocessingPeoplePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.People? People { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
