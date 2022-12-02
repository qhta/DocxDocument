namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Drawing.IShapeTree? ShapeTree { get ; set; }
  
}
