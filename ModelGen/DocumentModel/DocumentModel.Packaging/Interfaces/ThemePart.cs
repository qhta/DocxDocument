namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.theme+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface ThemePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Theme? Theme { get ; set; }
  
}
