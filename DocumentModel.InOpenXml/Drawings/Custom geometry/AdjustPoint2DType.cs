namespace DocumentModel.Drawings;
/// <summary>
/// Represents a two-dimensional adjustment point with X and Y coordinates, used for shape geometry manipulation.
/// <para>
/// Specifies a position coordinate within the shape bounding box.
/// It should be noted that this coordinate is placed within the shape bounding box using the transform coordinate system
/// which is also called the shape coordinate system, as it encompasses the entire shape.
/// The width and height for this coordinate system are specified within the ext transform element.
/// </para>
/// </summary>
/// <remarks>
/// When specifying a point coordinate in path coordinate space it should be noted that the top left of the coordinate space is x=0, y=0
/// and the coordinate points for x grow to the right and for y grow down.
/// </remarks>

[OpenXmlType(typeof(DXD.AdjustPoint2DType))]
public partial class AdjustPoint2DType : ModelElement<DXD.AdjustPoint2DType>
{
 /// <summary>
 /// X-coordinate of the adjustment point.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustPoint2DType.X))]
 public EMU? X { get => _X; set => UpdateField(ref _X, value, nameof(X)); }

 private EMU? _X;
 /// <summary>
 /// Y-coordinate of the adjustment point.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustPoint2DType.Y))]
 public EMU? Y { get => _Y; set => UpdateField(ref _Y, value, nameof(Y)); }

 private EMU? _Y;
}