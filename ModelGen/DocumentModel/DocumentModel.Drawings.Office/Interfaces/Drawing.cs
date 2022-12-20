namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public partial interface Drawing
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeTree? ShapeTree { get; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.DiagramPersistLayoutPart? DiagramPersistLayoutPart { get; set; }
  
}
