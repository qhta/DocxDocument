namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo")]
public interface SlideSyncDataPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.SlideSyncProperties? SlideSyncProperties { get ; set; }
  
}
