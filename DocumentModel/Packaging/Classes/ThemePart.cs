namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public partial class ThemePart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Theme? Theme { get; set; }
  
}
