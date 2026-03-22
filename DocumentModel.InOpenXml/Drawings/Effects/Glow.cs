namespace DocumentModel.Drawings;
/// <summary>
///   Represents a glow effect that can be applied to a drawing object.
/// </summary>
[OpenXmlType(typeof(DXD.Glow))]
public partial class Glow : ModelElement<DXD.Glow>
{
 /// <summary>
 ///   Radius
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.Radius))]
 public Int64? Radius { get => _Radius; set => UpdateField(ref _Radius, value, nameof(Radius)); }
 private Int64? _Radius;
 /// <summary>
 ///   RGB Color Model - Percentage Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   RGB Color Model - Hex Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Hue, Saturation, Luminance Color Model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
 private HslColor? _HslColor;
 /// <summary>
 ///   System Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
 private SystemColor? _SystemColor;
 /// <summary>
 ///   Scheme Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Preset Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
 private PresetColor? _PresetColor;
}