namespace DocumentModel.Drawings;
/// <summary>
///   Represents an outer shadow effect, including blur, offset, direction, scaling, skew, alignment, rotation, and color options.
/// </summary>
[OpenXmlType(typeof(DXD.OuterShadow))]
[DataContract]
[XmlRoot("OuterShadow", Namespace = "DocumentModel.Drawings")]
public partial class OuterShadow : ModelElement<DXD.OuterShadow>
{
 /// <summary>
 ///   Blur radius of the shadow.
 /// </summary>
 public Int64? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }
 private Int64? _BlurRadius;

 /// <summary>
 ///   Distance to offset the shadow from the object.
 /// </summary>
 public Int64? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }
 private Int64? _Distance;

 /// <summary>
 ///   Direction angle of the shadow.
 /// </summary>
 public Int32? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }
 private Int32? _Direction;

 /// <summary>
 ///   Horizontal scaling factor for the shadow.
 /// </summary>
 public Int32? HorizontalRatio { get => _HorizontalRatio; set => UpdateField(ref _HorizontalRatio, value, nameof(HorizontalRatio)); }
 private Int32? _HorizontalRatio;

 /// <summary>
 ///   Vertical scaling factor for the shadow.
 /// </summary>
 public Int32? VerticalRatio { get => _VerticalRatio; set => UpdateField(ref _VerticalRatio, value, nameof(VerticalRatio)); }
 private Int32? _VerticalRatio;

 /// <summary>
 ///   Horizontal skew of the shadow.
 /// </summary>
 public Int32? HorizontalSkew { get => _HorizontalSkew; set => UpdateField(ref _HorizontalSkew, value, nameof(HorizontalSkew)); }
 private Int32? _HorizontalSkew;

 /// <summary>
 ///   Vertical skew of the shadow.
 /// </summary>
 public Int32? VerticalSkew { get => _VerticalSkew; set => UpdateField(ref _VerticalSkew, value, nameof(VerticalSkew)); }
 private Int32? _VerticalSkew;

 /// <summary>
 ///   Alignment of the shadow relative to the object.
 /// </summary>
 public RectangleAlignment? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }
 private RectangleAlignment? _Alignment;

 /// <summary>
 ///   Indicates whether the shadow rotates with the shape.
 /// </summary>
 public bool? RotateWithShape { get => _RotateWithShape; set => UpdateField(ref _RotateWithShape, value, nameof(RotateWithShape)); }
 private bool? _RotateWithShape;

 /// <summary>
 ///   Shadow color specified using the RGB color model with percentage values.
 /// </summary>
 public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private ColorType? _Color;


}