namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public interface ILineSketchTypeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public ILineSketchNoneEmpty? LineSketchNoneEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public ILineSketchCurvedEmpty? LineSketchCurvedEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public ILineSketchFreehandEmpty? LineSketchFreehandEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public ILineSketchScribbleEmpty? LineSketchScribbleEmpty { get ; set; }
  
}
