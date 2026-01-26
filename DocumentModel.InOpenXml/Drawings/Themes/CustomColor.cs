namespace DocumentModel.Drawings;
/// <summary>
///   Custom color.
/// </summary>
[OpenXmlType(typeof(DXD.CustomColor))]
/// <summary>
///   Custom color.
/// </summary>
public partial class CustomColor : ModelElement<DXD.CustomColor>
{
 /// <summary>
 ///   FontName
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.Name))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   RGB Color Model - Percentage Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.RgbColorModelPercentage))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   RGB Color Model - Hex Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.RgbColorModelHex))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Hue, Saturation, Luminance Color Model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.HslColor))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   System Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.SystemColor))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Scheme Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.SchemeColor))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Preset Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.PresetColor))]
 [OpenXmlElement(typeof(DXD.CustomColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}