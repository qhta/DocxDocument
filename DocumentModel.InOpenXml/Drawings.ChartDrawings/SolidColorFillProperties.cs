namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10W.SolidColorFillProperties))]
[XmlRoot("SolidColorFillProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class SolidColorFillProperties : ModelElement<DXO10W.SolidColorFillProperties>
{
 /// <summary>
 /// Specifies the rgb color model hex.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.SolidColorFillProperties.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 /// Specifies the scheme color.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.SolidColorFillProperties.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 /// Specifies the rgb color model percentage.
 /// </summary>
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 /// Specifies the hsl color.
 /// </summary>
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 /// Specifies the system color.
 /// </summary>
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 /// Specifies the preset color.
 /// </summary>
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}