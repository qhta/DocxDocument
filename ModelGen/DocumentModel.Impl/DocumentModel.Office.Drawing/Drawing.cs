namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IShapeTree))]
public class Drawing: IDrawing
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Office.Drawing.IShapeTree? ShapeTree
  {
    get;
    set;
  }
  
}
