namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha inverse effect, which inverts the alpha channel of an image or shape and supports various color models.
/// </summary>
[OpenXmlType(typeof(DXD.AlphaInverse))]
public partial class AlphaInverse : ModelElement<DXD.AlphaInverse>
{
 /// <summary>
 /// RGB color model using percentage values for the alpha inverse effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaInverse.RgbColorModelPercentage))]
 [OpenXmlElement(typeof(DXD.AlphaInverse))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 /// RGB color model using hexadecimal values for the alpha inverse effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaInverse.RgbColorModelHex))]
 [OpenXmlElement(typeof(DXD.AlphaInverse))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 /// HSL (Hue, Saturation, Luminance) color model for the alpha inverse effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaInverse.HslColor))]
 [OpenXmlElement(typeof(DXD.AlphaInverse))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 /// System color for the alpha inverse effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaInverse.SystemColor))]
 [OpenXmlElement(typeof(DXD.AlphaInverse))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 /// Scheme color for the alpha inverse effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaInverse.SchemeColor))]
 [OpenXmlElement(typeof(DXD.AlphaInverse))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 /// Preset color for the alpha inverse effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaInverse.PresetColor))]
 [OpenXmlElement(typeof(DXD.AlphaInverse))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}