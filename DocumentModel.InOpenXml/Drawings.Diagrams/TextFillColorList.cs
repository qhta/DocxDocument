namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Text Fill Color List.
/// </summary>
[OpenXmlType(typeof(DXDD.TextFillColorList))]
public partial class TextFillColorList : ColorsType
{
  /// <summary>
  /// Rgb Color Model Percentage.
  /// </summary>
  [OpenXmlElement(typeof(DXD.RgbColorModelPercentage))]
  public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
  private RgbColorModelPercentage? _RgbColorModelPercentage;
  /// <summary>
  /// Rgb Color Model Hex.
  /// </summary>
  [OpenXmlElement(typeof(DXD.RgbColorModelHex))]
  public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
  private RgbColorModelHex? _RgbColorModelHex;
  /// <summary>
  /// Hsl Color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.HslColor))]
  public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
  private HslColor? _HslColor;
  /// <summary>
  /// System Color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.SystemColor))]
  public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
  private SystemColor? _SystemColor;
  /// <summary>
  /// Scheme Color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.SchemeColor))]
  public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
  private SchemeColor? _SchemeColor;
  /// <summary>
  /// Preset Color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.PresetColor))]
  public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
  private PresetColor? _PresetColor;
}