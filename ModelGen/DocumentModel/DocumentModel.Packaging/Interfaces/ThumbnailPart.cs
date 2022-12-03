namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThumbnailPart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail")]
public interface ThumbnailPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}
