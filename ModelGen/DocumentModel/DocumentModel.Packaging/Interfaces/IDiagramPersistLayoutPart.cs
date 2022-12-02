namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public interface IDiagramPersistLayoutPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.IDrawing? Drawing { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
