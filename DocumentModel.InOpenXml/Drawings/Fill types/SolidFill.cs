namespace DocumentModel.Drawings;
/// <summary>
///   Specifies a solid color fill. The shape is filled entirely with the specified color. 
/// </summary>
[OpenXmlType(typeof(DXD.SolidFill))]
[XmlRoot("SolidFill", Namespace = "DocumentModel.Drawings")]
public partial class SolidFill : Fill<DXD.SolidFill>
{
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SolidFill.RgbColorModelPercentage))]
  public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
  private RgbColorModelPercentage? _RgbColorModelPercentage;

  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SolidFill.RgbColorModelHex))]
  public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
  private RgbColorModelHex? _RgbColorModelHex;

  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SolidFill.HslColor))]
  public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
  private HslColor? _HslColor;

  /// <summary>
  ///   System Color.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SolidFill.SystemColor))]
  public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
  private SystemColor? _SystemColor;

  /// <summary>
  ///   Scheme Color.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SolidFill.SchemeColor))]
  public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
  private SchemeColor? _SchemeColor;

  /// <summary>
  ///   Preset Color.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SolidFill.PresetColor))]
  public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
  private PresetColor? _PresetColor;
  
  /// <summary>
  /// Gets or sets the effective color value of the scheme color.
  /// <para>
  /// Gets the color value of the scheme color definition by checking each color type in a specific order and returning the first non-null color value found.
  /// The order of checking is as follows: RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant,
  /// Hue, Saturation, Luminance Color Model, System Color, SchemeColor, and finally Preset Color.
  /// This method allows for retrieving the effective color value of the scheme color definition based on the defined color types.
  /// </para>
  /// <para>
  /// Sets the color value of the scheme color definition by determining the type of the provided color value and assigning it to the corresponding color property.
  /// The method checks the type of the input color value and updates the appropriate color property
  /// (RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, SchemeColor, or Preset Color)
  /// based on the type of the input color. This allows for setting the color value of the scheme color definition
  /// using a single property while internally managing multiple color types.
  /// </para>
  /// </summary>
  public IColor? Color
  {
    get => RgbColorModelPercentage ?? RgbColorModelHex ?? HslColor ?? SystemColor ?? SchemeColor ?? (IColor?)PresetColor;
    set
    {
      RgbColorModelPercentage = value is RgbColorModelPercentage rgbPercentage ? rgbPercentage : null;
      RgbColorModelHex = value is RgbColorModelHex rgbHex ? rgbHex : null;
      HslColor = value is HslColor hsl ? hsl : null;
      SystemColor = value is SystemColor system ? system : null;
      SchemeColor = value is SchemeColor scheme ? scheme : null;
      PresetColor = value is PresetColor preset ? preset : null;
    }
  }

}