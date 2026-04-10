namespace DocumentModel.Drawings;
/// <summary>
///   Represents an inner shadow effect, including blur, offset, direction, and color options.
/// </summary>
[OpenXmlType(typeof(DXD.InnerShadow))]
[XmlRoot("InnerShadow", Namespace = "DocumentModel.Drawings")]
public partial class InnerShadow : ModelElement<DXD.InnerShadow>
{
 /// <summary>
 ///   Blur radius of the inner shadow.
 /// </summary>
 public Int64? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }

 private Int64? _BlurRadius;
 /// <summary>
 ///   Distance to offset the inner shadow from the object.
 /// </summary>
 public Int64? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }

 private Int64? _Distance;
 /// <summary>
 ///   Direction angle of the inner shadow.
 /// </summary>
 public Int32? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }

 private Int32? _Direction;
 /// <summary>
 ///   Inner shadow color specified using the RGB color model with percentage values.
 /// </summary>
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   Inner shadow color specified using the RGB color model with hexadecimal values.
 /// </summary>
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Inner shadow color specified using the hue, saturation, luminance (HSL) color model.
 /// </summary>
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   Inner shadow color specified using a system-defined color.
 /// </summary>
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Inner shadow color specified using a color scheme.
 /// </summary>
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Inner shadow color specified using a preset color.
 /// </summary>
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}