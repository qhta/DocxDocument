namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public interface LineSketchTypeProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public Boolean? LineSketchNoneEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public Boolean? LineSketchCurvedEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public Boolean? LineSketchFreehandEmpty { get ; set; }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public Boolean? LineSketchScribbleEmpty { get ; set; }
  
}
