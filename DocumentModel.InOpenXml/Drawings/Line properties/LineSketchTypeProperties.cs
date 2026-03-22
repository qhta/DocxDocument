namespace DocumentModel.Drawings;
/// <summary>
///   Represents sketch type properties for a line, indicating the presence of various sketch styles.
/// </summary>
[OpenXmlType(typeof(DXO21DSS.LineSketchTypeProperties))]
public partial class LineSketchTypeProperties : ModelElement<DXO21DSS.LineSketchTypeProperties>
{
 /// <summary>
 ///   Indicates whether the "None" sketch style is present.
 /// </summary>
 public bool? LineSketchNoneEmpty { get => _LineSketchNoneEmpty; set => UpdateField(ref _LineSketchNoneEmpty, value, nameof(LineSketchNoneEmpty)); }
 private bool? _LineSketchNoneEmpty;
 /// <summary>
 ///   Indicates whether the "Curved" sketch style is present.
 /// </summary>
 public bool? LineSketchCurvedEmpty { get => _LineSketchCurvedEmpty; set => UpdateField(ref _LineSketchCurvedEmpty, value, nameof(LineSketchCurvedEmpty)); }
 private bool? _LineSketchCurvedEmpty;
 /// <summary>
 ///   Indicates whether the "Freehand" sketch style is present.
 /// </summary>
 public bool? LineSketchFreehandEmpty { get => _LineSketchFreehandEmpty; set => UpdateField(ref _LineSketchFreehandEmpty, value, nameof(LineSketchFreehandEmpty)); }
 private bool? _LineSketchFreehandEmpty;
 /// <summary>
 ///   Indicates whether the "Scribble" sketch style is present.
 /// </summary>
 public bool? LineSketchScribbleEmpty { get => _LineSketchScribbleEmpty; set => UpdateField(ref _LineSketchScribbleEmpty, value, nameof(LineSketchScribbleEmpty)); }
 private bool? _LineSketchScribbleEmpty;
}