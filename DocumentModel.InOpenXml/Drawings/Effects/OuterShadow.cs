namespace DocumentModel.Drawings;
/// <summary>
///   Represents an outer shadow effect, including blur, offset, direction, scaling, skew, alignment, rotation, and color options.
/// </summary>
[OpenXmlType(typeof(DXD.OuterShadow))]
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
 public RectangleAlignmentKind? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

 private RectangleAlignmentKind? _Alignment;
 /// <summary>
 ///   Indicates whether the shadow rotates with the shape.
 /// </summary>
 public bool? RotateWithShape { get => _RotateWithShape; set => UpdateField(ref _RotateWithShape, value, nameof(RotateWithShape)); }

 private bool? _RotateWithShape;
 /// <summary>
 ///   Shadow color specified using the RGB color model with percentage values.
 /// </summary>
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   Shadow color specified using the RGB color model with hexadecimal values.
 /// </summary>
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Shadow color specified using the hue, saturation, luminance (HSL) color model.
 /// </summary>
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   Shadow color specified using a system-defined color.
 /// </summary>
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Shadow color specified using a color scheme.
 /// </summary>
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Shadow color specified using a preset color.
 /// </summary>
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}