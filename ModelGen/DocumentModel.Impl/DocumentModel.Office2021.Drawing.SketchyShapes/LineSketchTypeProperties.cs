namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchNoneEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchCurvedEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchFreehandEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchScribbleEmpty))]
public class LineSketchTypeProperties: ILineSketchTypeProperties
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public ILineSketchNoneEmpty? LineSketchNoneEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public ILineSketchCurvedEmpty? LineSketchCurvedEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public ILineSketchFreehandEmpty? LineSketchFreehandEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public ILineSketchScribbleEmpty? LineSketchScribbleEmpty
  {
    get;
    set;
  }
  
}
