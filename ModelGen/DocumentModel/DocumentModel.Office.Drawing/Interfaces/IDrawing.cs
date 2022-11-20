namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IShapeTree))]
public interface IDrawing // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Office.Drawing.IShapeTree? ShapeTree { get ; set; }
  
}
