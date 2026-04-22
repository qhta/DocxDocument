namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the OpenXmlSolidColorFillPropertiesElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement))]
[XmlRoot("OpenXmlSolidColorFillPropertiesElement", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class OpenXmlSolidColorFillPropertiesElement : ModelElement<DXO16DCD.OpenXmlSolidColorFillPropertiesElement>
{
 /// <summary>
 /// Specifies the rgb color model percentage.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
 private RgbColorModelPercentage? _RgbColorModelPercentage;

 /// <summary>
 /// Specifies the rgb color model hex.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
 private RgbColorModelHex? _RgbColorModelHex;

 /// <summary>
 /// Specifies the hsl color.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
 private HslColor? _HslColor;

 /// <summary>
 /// Specifies the system color.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
 private SystemColor? _SystemColor;

 /// <summary>
 /// Specifies the scheme color.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;

 /// <summary>
 /// Specifies the preset color.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
 private PresetColor? _PresetColor;
}