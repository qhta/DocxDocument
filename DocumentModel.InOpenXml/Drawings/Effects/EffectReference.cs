namespace DocumentModel.Drawings;
/// <summary>
/// Represents a reference to various color models and color types used in drawing effects.
/// </summary>
[OpenXmlType(typeof(DXD.EffectReference))]
public partial class EffectReference : ModelElement<DXD.EffectReference>
{
 /// <summary>
 /// RGB color model using percentage values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.RgbColorModelPercentage))]
 /// <summary>
 /// RGB color model using percentage values.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectReference))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 /// RGB color model using hexadecimal values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.RgbColorModelHex))]
 /// <summary>
 /// RGB color model using hexadecimal values.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectReference))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 /// HSL (Hue, Saturation, Lightness) color model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.HslColor))]
 /// <summary>
 /// HSL (Hue, Saturation, Lightness) color model.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectReference))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 /// System color, which refers to a color defined by the system.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.SystemColor))]
 /// <summary>
 /// System color, which refers to a color defined by the system.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectReference))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 /// Scheme color, which refers to a color defined by a color scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.SchemeColor))]
 /// <summary>
 /// Scheme color, which refers to a color defined by a color scheme.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectReference))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 /// Preset color, which refers to a predefined color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.PresetColor))]
 /// <summary>
 /// Preset color, which refers to a predefined color.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectReference))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}