namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public interface DiagramPersistLayoutPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Office.Drawing? Drawing { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
