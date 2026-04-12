namespace DocumentModel.Drawings;
/// <summary>
/// A specific color type that represents a scheme color definition, which is used to define colors based on a color scheme in drawing elements. This class serves as a base for specific scheme color definitions that can be used in themes and color schemes within the document model. It allows for the representation of colors that are defined by a scheme, enabling consistent color usage across different drawing elements that reference the same scheme color definition.
/// </summary>
[XmlRoot("SchemeColorDef", Namespace = "DocumentModel.Drawings")]
[OpenXmlType(typeof(DXD.Color2Type))]
public class SchemeColorDef : ModelElement<DXD.Color2Type>, ISchemeBaseColor
{
  /// <summary>
  /// <para>RGB Color Model - Percentage Variant.</para>
  /// </summary>
  [OpenXmlElement(typeof(DXD.RgbColorModelPercentage))]
  public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
  private RgbColorModelPercentage? _RgbColorModelPercentage;

  /// <summary>
  /// <para>RGB Color Model - Hex Variant.</para>
  /// </summary>
  [OpenXmlElement(typeof(DXD.RgbColorModelHex))]
  public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
  private RgbColorModelHex? _RgbColorModelHex;

  /// <summary>
  /// <para>Hue, Saturation, Luminance Color Model.</para>
  /// </summary>
  [OpenXmlElement(typeof(DXD.HslColor))]
  public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
  private HslColor? _HslColor;

  /// <summary>
  /// <para>System Color.</para>
  /// </summary>
  [OpenXmlElement(typeof(DXD.SystemColor))]
  public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
  private SystemColor? _SystemColor;

  /// <summary>
  /// <para>Preset Color.</para>
  /// </summary>
  [OpenXmlElement(typeof(DXD.PresetColor))]
  public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
  private PresetColor? _PresetColor;

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelHex"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.RgbColorModelHex color) => new() { RgbColorModelHex = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelPercentage"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.RgbColorModelPercentage color) => new() { RgbColorModelPercentage = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.HslColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.HslColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.HslColor color) => new() { HslColor = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.SystemColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.SystemColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.SystemColor color) => new() { SystemColor = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.PresetColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.PresetColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.PresetColor color) => new() { PresetColor = color };

  /// <summary>
  /// Gets the color value of the scheme color definition by checking each color type in a specific order and returning the first non-null color value found. The order of checking is as follows: RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, and finally Preset Color. This method allows for retrieving the effective color value of the scheme color definition based on the defined color types.
  /// </summary>
  /// <returns>IColor interface</returns>
  public IColor? GetColorValue() => RgbColorModelPercentage ?? RgbColorModelHex ?? HslColor ?? SystemColor ?? (IColor?)PresetColor;

  /// <summary>
  /// Gets the RGB color value represented by this scheme color, if available.
  /// </summary>
  uint? ISchemeBaseColor.RGB  => GetColorValue()?.RGB;
}