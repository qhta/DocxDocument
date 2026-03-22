namespace DocumentModel.Drawings;
/// <summary>
///   Represents a preset shadow effect, including type, distance, direction, and color options.
/// </summary>
[OpenXmlType(typeof(DXD.PresetShadow))]
public partial class PresetShadow : ModelElement<DXD.PresetShadow>
{
 /// <summary>
 ///   Preset shadow type.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.Preset))]
 public PresetShadows? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }
 private PresetShadows? _Preset;
 /// <summary>
 ///   Distance to offset the shadow from the object.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.Distance))]
 public Int64? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }
 private Int64? _Distance;
 /// <summary>
 ///   Direction angle of the shadow.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.Direction))]
 public Int32? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }
 private Int32? _Direction;
 /// <summary>
 ///   Shadow color specified using the RGB color model with percentage values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   Shadow color specified using the RGB color model with hexadecimal values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Shadow color specified using the hue, saturation, luminance (HSL) color model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
 private HslColor? _HslColor;
 /// <summary>
 ///   Shadow color specified using a system-defined color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
 private SystemColor? _SystemColor;
 /// <summary>
 ///   Shadow color specified using a color scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Shadow color specified using a preset color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetShadow.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
 private PresetColor? _PresetColor;
}