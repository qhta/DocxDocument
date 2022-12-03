namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordAttachedToolbarsPart
/// </summary>
[ContentMime("application/vnd.ms-word.attachedToolbars")]
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/attachedToolbars")]
public interface WordAttachedToolbarsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
