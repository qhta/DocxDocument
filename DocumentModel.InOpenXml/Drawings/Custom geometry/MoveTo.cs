namespace DocumentModel.Drawings;
/// <summary>
///   Represents a command to move the current path to a specified point without drawing a line.
/// </summary>
[OpenXmlType(typeof(DXD.MoveTo))]
public partial class MoveTo : ModelElement<DXD.MoveTo>
{
 /// <summary>
 ///   Destination point for the move operation.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.MoveTo.Point))]
 /// <summary>
 ///   Destination point for the move operation.
 /// </summary>
 [OpenXmlElement(typeof(DXD.MoveTo))]
 public AdjustPoint2DType? Point { get => _Point; set => UpdateField(ref _Point, value, nameof(Point)); }

 private AdjustPoint2DType? _Point;
}