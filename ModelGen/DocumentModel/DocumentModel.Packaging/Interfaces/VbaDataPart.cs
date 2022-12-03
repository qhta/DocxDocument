namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
[ContentMime("application/vnd.ms-word.vbaData+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/wordVbaData")]
public interface VbaDataPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.VbaSuppData? VbaSuppData { get ; set; }
  
}
