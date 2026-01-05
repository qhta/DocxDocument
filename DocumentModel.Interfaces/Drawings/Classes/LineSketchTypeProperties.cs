namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LineSketchTypeProperties interface.
/// </summary>
public interface LineSketchTypeProperties:
{
  /// <summary>
  ///   LineSketchNoneEmpty.
  /// </summary>
  public bool? LineSketchNoneEmpty { get; set; }
  /// <summary>
  ///   LineSketchCurvedEmpty.
  /// </summary>
  public bool? LineSketchCurvedEmpty { get; set; }
  /// <summary>
  ///   LineSketchFreehandEmpty.
  /// </summary>
  public bool? LineSketchFreehandEmpty { get; set; }
  /// <summary>
  ///   LineSketchScribbleEmpty.
  /// </summary>
  public bool? LineSketchScribbleEmpty { get; set; }
}