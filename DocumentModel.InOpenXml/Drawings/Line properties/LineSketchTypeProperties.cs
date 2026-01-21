namespace DocumentModel.Drawings;
/// <summary>
///   Represents sketch type properties for a line, indicating the presence of various sketch styles.
/// </summary>
public partial class LineSketchTypeProperties : ModelElement
{
  /// <summary>
  ///   Indicates whether the "None" sketch style is present.
  /// </summary>
  public bool? LineSketchNoneEmpty { get; set; }
  /// <summary>
  ///   Indicates whether the "Curved" sketch style is present.
  /// </summary>
  public bool? LineSketchCurvedEmpty { get; set; }
  /// <summary>
  ///   Indicates whether the "Freehand" sketch style is present.
  /// </summary>
  public bool? LineSketchFreehandEmpty { get; set; }
  /// <summary>
  ///   Indicates whether the "Scribble" sketch style is present.
  /// </summary>
  public bool? LineSketchScribbleEmpty { get; set; }
}