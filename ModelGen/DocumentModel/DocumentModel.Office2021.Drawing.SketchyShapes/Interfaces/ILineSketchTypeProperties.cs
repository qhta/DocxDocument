namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public interface ILineSketchTypeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? LineSketchNoneEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? LineSketchCurvedEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? LineSketchFreehandEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? LineSketchScribbleEmpty { get ; set; }
  
}
