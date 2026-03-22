namespace DocumentModel.Drawings;
/// <summary>
/// Represents the background color, supporting multiple color models and types for flexible color specification.
/// </summary>
[OpenXmlType(typeof(DXD.BackgroundColor))]
public partial class BackgroundColor : ModelElement<DXD.BackgroundColor>
{
 /// <summary>
 /// Gets or sets the RGB color model using percentage values for the background color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BackgroundColor.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 /// Gets or sets the RGB color model using hexadecimal values for the background color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BackgroundColor.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 /// Gets or sets the HSL (Hue, Saturation, Lightness) color model for the background color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BackgroundColor.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
 private HslColor? _HslColor;
 /// <summary>
 /// Gets or sets the system color for the background color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BackgroundColor.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
 private SystemColor? _SystemColor;
 /// <summary>
 /// Gets or sets the scheme color for the background color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BackgroundColor.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;
 /// <summary>
 /// Gets or sets the preset color for the background color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BackgroundColor.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
 private PresetColor? _PresetColor;
}