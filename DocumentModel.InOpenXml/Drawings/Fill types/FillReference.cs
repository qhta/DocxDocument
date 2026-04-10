namespace DocumentModel.Drawings;
/// <summary>
///   Represents a fill color reference in DrawingML, allowing the specification of a fill color using various color models (RGB, HSL, system, scheme, or preset).
///   Enables advanced color referencing and theming for shapes, lines, and graphical elements in Office documents.
/// </summary>
[OpenXmlType(typeof(DXD.FillReference))]
[XmlRoot("FillReference", Namespace = "DocumentModel.Drawings")]
public partial class FillReference : ModelElement<DXD.FillReference>
{
 /// <summary>
 ///   Fill color specified using the RGB color model with percentage values for each channel.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillReference.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   Fill color specified using the RGB color model with hexadecimal values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillReference.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Fill color specified using the HSL (hue, saturation, lightness) color model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillReference.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   Fill color specified using a system color, referencing operating system or application theme colors.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillReference.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Fill color specified using a scheme color, referencing a color from the document's theme or color scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillReference.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Fill color specified using a preset color, selecting from a predefined set of colors.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillReference.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}