namespace DocumentModel.Drawings;
/// <summary>
///   Represents a foreground color, supporting multiple color models for fill formatting.
/// </summary>
[OpenXmlType(typeof(DXD.ForegroundColor))]
public partial class ForegroundColor : ModelElement<DXD.ForegroundColor>
{
 /// <summary>
 ///   Foreground color specified using the RGB color model with percentage values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   Foreground color specified using the RGB color model with hexadecimal values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Foreground color specified using the hue, saturation, luminance (HSL) color model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   Foreground color specified using a system-defined color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Foreground color specified using a color scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Foreground color specified using a preset color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}