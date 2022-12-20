namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public partial interface FontTablePart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public Collection<DocumentModel.Packaging.FontPart>? FontParts { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Fonts? Fonts { get; set; }
  
  public String? RelationshipType { get; }
  
}
