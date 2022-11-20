namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.INonVisualDrawingShapeProperties))]
public class ShapeNonVisualProperties: IShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.INonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get;
    set;
  }
  
}
