namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public IShapeTree? ShapeTree { get ; set; }
  
}
