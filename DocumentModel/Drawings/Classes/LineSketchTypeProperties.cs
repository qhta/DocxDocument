namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineSketchTypeProperties Class.
/// </summary>
public class LineSketchTypeProperties: ModelElement
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