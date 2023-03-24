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
  public Boolean? LineSketchNoneEmpty { get; set; }

  /// <summary>
  ///   LineSketchCurvedEmpty.
  /// </summary>
  public Boolean? LineSketchCurvedEmpty { get; set; }

  /// <summary>
  ///   LineSketchFreehandEmpty.
  /// </summary>
  public Boolean? LineSketchFreehandEmpty { get; set; }

  /// <summary>
  ///   LineSketchScribbleEmpty.
  /// </summary>
  public Boolean? LineSketchScribbleEmpty { get; set; }
}