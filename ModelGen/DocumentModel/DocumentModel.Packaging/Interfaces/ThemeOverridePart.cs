namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.themeOverride+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface ThemeOverridePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ThemeOverride? ThemeOverride { get ; set; }
  
}
