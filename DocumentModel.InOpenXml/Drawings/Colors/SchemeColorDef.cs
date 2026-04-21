namespace DocumentModel.Drawings;
/// <summary>
/// A specific color type that represents a scheme color definition, which is used to define colors based on a color scheme in drawing elements. This class serves as a base for specific scheme color definitions that can be used in themes and color schemes within the document model. It allows for the representation of colors that are defined by a scheme, enabling consistent color usage across different drawing elements that reference the same scheme color definition.
/// </summary>
[XmlRoot("SchemeColorDef", Namespace = "DocumentModel.Drawings")]
[OpenXmlType(typeof(DXD.Color2Type))]
public class SchemeColorDef : ModelElement<DXD.Color2Type>, IColorHolder
{
  //  /// <summary>
  //  /// <para>RGB Color Model - Percentage Variant.</para>
  //  /// </summary>
  //  [OpenXmlElement(typeof(DXD.RgbColorModelPercentage))]
  //  public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }
  //  private RgbColorModelPercentage? _RgbColorModelPercentage;

  //  /// <summary>
  //  /// <para>RGB Color Model - Hex Variant.</para>
  //  /// </summary>
  //  [OpenXmlElement(typeof(DXD.RgbColorModelHex))]
  //  public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
  //  private RgbColorModelHex? _RgbColorModelHex;

  //  /// <summary>
  //  /// <para>Hue, Saturation, Luminance Color Model.</para>
  //  /// </summary>
  //  [OpenXmlElement(typeof(DXD.HslColor))]
  //  public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }
  //  private HslColor? _HslColor;

  //  /// <summary>
  //  /// <para>System Color.</para>
  //  /// </summary>
  //  [OpenXmlElement(typeof(DXD.SystemColor))]
  //  public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }
  //  private SystemColor? _SystemColor;

  //  /// <summary>
  //  /// <para>Preset Color.</para>
  //  /// </summary>
  //  [OpenXmlElement(typeof(DXD.PresetColor))]
  //  public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }
  //  private PresetColor? _PresetColor;

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelHex"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.RgbColorModelHex color) => new() { Color = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelPercentage"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.RgbColorModelPercentage color) => new() { Color = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.HslColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.HslColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.HslColor color) => new() { Color = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.SystemColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.SystemColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.SystemColor color) => new() { Color = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.PresetColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.PresetColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.PresetColor color) => new() { Color = color };

  /// <summary>
  /// A color that can be held in the color scheme definition, including:
  /// <list type="">
  /// <item>RGB Color Model - Percentage Variant</item>
  /// <item>RGB Color Model - Hex Variant</item>
  /// <item>Hue, Saturation, Luminance Color Model</item>
  /// <item>System Color</item>
  /// <item>Preset Color</item>
  /// </list>
  /// </summary>
  [OpenXmlLoadData(nameof(LoadColorFromOpenXml))]
  [OpenXmlUpdateData(nameof(UpdateColorInOpenXml))]
  [JsonIgnore]
  public ModelElement? Color { get => _color; set => UpdateField(ref _color, value, nameof(Color)); }
  private ModelElement? _color;

  /// <summary>
  /// Needed for JSON serialization only
  /// </summary>
  [XmlIgnore]
  public IDrawingColor? DrawingColor { get => Color as IDrawingColor; set => Color = value as ModelElement; }

  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  private void LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    (this as IColorHolder).Color =  IColorHolder.LoadColorFromOpenXml(openXmlElement);
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  private void UpdateColorInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    IColorHolder.UpdateColorInOpenXml(Color, openXmlElement);
  }

  /// <summary>
  /// Gets or sets the effective color value of the scheme color
  /// <para>
  /// Gets the color value of the scheme color definition by checking each color type in a specific order and returning the first non-null color value found. The order of checking is as follows: RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, and finally Preset Color. This method allows for retrieving the effective color value of the scheme color definition based on the defined color types.
  /// </para>
  /// <para>
  /// Sets the color value of the scheme color definition by determining the type of the provided color value and assigning it to the corresponding color property. The method checks the type of the input color value and updates the appropriate color property (RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, or Preset Color) based on the type of the input color. This allows for setting the color value of the scheme color definition using a single property while internally managing multiple color types.
  /// </para>
  /// </summary>
  IColor? IColorHolder.Color
  {
    get => Color as IColor;
    set => Color = value as ModelElement;
  }

  /// <summary>
  /// Gets the RGB color value represented by this scheme color, if available.
  /// </summary>
  public uint? RGB  => (Color as IColor)?.RGB;
}