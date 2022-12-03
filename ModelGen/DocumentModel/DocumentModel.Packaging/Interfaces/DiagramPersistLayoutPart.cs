namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
[ContentMime("application/vnd.ms-office.drawingml.diagramDrawing+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2007/relationships/diagramDrawing")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface DiagramPersistLayoutPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Drawing? Drawing { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
