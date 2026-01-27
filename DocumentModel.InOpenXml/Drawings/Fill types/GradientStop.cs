namespace DocumentModel.Drawings;
/// <summary>
///   Gradient stops.
/// </summary>
[OpenXmlType(typeof(DXD.GradientStop))]
public partial class GradientStop : ModelElement<DXD.GradientStop>
{
 /// <summary>
 ///   Position
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.Position))]
 public Int32? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private Int32? _Position;
 /// <summary>
 ///   RGB Color Model - Percentage Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.RgbColorModelPercentage))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 ///   RGB Color Model - Hex Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.RgbColorModelHex))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 ///   Hue, Saturation, Luminance Color Model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.HslColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 ///   System Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.SystemColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 ///   Scheme Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 ///   Preset Color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.PresetColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
}