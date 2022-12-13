namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public interface ThemePart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Theme? Theme { get ; set; }
  
}
