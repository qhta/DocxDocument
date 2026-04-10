namespace DocumentModel.Drawings;
/// <summary>
///   Custom color.
/// </summary>
[OpenXmlType(typeof(DXD.CustomColor))]
[XmlRoot("CustomColor", Namespace = "DocumentModel.Drawings")]
public partial class CustomColor : ModelElement<DXD.CustomColor>
{
 /// <summary>
 ///   Name
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   RGB Color Model - Percentage Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   RGB Color Model - Hex Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Hue, Saturation, Luminance Color Model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   System Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Scheme Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Preset Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.CustomColor.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}