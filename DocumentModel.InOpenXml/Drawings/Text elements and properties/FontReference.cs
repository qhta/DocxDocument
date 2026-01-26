namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a font, including its identifier and color information in various color models.
/// </summary>
[OpenXmlType(typeof(DXD.FontReference))]
public partial class FontReference : ModelElement<DXD.FontReference>
{
 /// <summary>
 ///   Identifier for the font collection index.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.Index))]
 /// <summary>
 ///   Identifier for the font collection index.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public FontCollectionIndexKind? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

 private FontCollectionIndexKind? _Index;
 /// <summary>
 ///   Color specified using the RGB color model with percentage values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.RgbColorModelPercentage))]
 /// <summary>
 ///   Color specified using the RGB color model with percentage values.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   Color specified using the RGB color model with hexadecimal values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.RgbColorModelHex))]
 /// <summary>
 ///   Color specified using the RGB color model with hexadecimal values.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Color specified using the Hue, Saturation, Luminance (HSL) color model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.HslColor))]
 /// <summary>
 ///   Color specified using the Hue, Saturation, Luminance (HSL) color model.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   Color specified using a system-defined color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.SystemColor))]
 /// <summary>
 ///   Color specified using a system-defined color.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Color specified using a color scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.SchemeColor))]
 /// <summary>
 ///   Color specified using a color scheme.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Color specified using a preset color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontReference.PresetColor))]
 /// <summary>
 ///   Color specified using a preset color.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontReference))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}