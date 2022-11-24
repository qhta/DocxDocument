namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public IShapeTree? ShapeTree { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutPart associated with this element.
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutPart { get ; set; }
  
}
