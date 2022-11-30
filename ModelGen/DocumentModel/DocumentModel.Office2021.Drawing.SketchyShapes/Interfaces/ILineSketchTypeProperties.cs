namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public interface ILineSketchTypeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public System.Boolean? LineSketchNoneEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public System.Boolean? LineSketchCurvedEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public System.Boolean? LineSketchFreehandEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public System.Boolean? LineSketchScribbleEmpty { get ; set; }
  
}
