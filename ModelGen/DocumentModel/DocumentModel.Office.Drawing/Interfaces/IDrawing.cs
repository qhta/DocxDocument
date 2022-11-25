namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Office.Drawing.IGroupShapeType? ShapeTree { get ; set; }
  
}
