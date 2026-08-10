namespace DocumentModel.Drawings;
/// <summary>
///   Custom color.
/// </summary>
[OpenXmlType(typeof(DXD.CustomColor))]
[DataContract]
[XmlRoot("CustomColor", Namespace = "DocumentModel.Drawings")]
public partial class CustomColor : ColorHolder<DXD.CustomColor>
{
  /// <summary>
  /// Name of the custom color, which can be used to identify and reference the color within the document. 
  /// </summary>
  [OpenXmlProperty(nameof(DXD.CustomColor.Name))]
  public string? Name
  {
    get => _Name ??= GetProperty<string>(GetUpdatableElement()?.Name);
    set => UpdateField(ref _Name, value, nameof(Name));
  }

  private string? _Name;

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="CustomColor"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelHex"/> value is assigned to a <see cref="CustomColor"/>, it creates a new instance of <see cref="CustomColor"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator CustomColor(DMD.ColorType color) => new() { Color = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelPercentage"/> color value directly to a <see cref="CustomColor"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="CustomColor"/>, it creates a new instance of <see cref="CustomColor"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator CustomColor(DMD.RgbColorModelPercentage color)
  {
    var schemeColorDef = new CustomColor();
    schemeColorDef.Color = new ColorType();
    schemeColorDef.Color.InternalColor = color;
    return schemeColorDef;
  }
  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="CustomColor"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="CustomColor"/>, it creates a new instance of <see cref="CustomColor"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator CustomColor(DMD.RgbColorModelHex color)
  {
    var schemeColorDef = new CustomColor();
    schemeColorDef.Color = new ColorType();
    schemeColorDef.Color.InternalColor = color;
    return schemeColorDef;
  }
  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.HslColor"/> color value directly to a <see cref="CustomColor"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.HslColor"/> value is assigned to a <see cref="CustomColor"/>, it creates a new instance of <see cref="CustomColor"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator CustomColor(DMD.HslColor color)
  {
    var schemeColorDef = new CustomColor();
    schemeColorDef.Color = new ColorType();
    schemeColorDef.Color.InternalColor = color;
    return schemeColorDef;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.SystemColor"/> color value directly to a <see cref="CustomColor"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.SystemColor"/> value is assigned to a <see cref="CustomColor"/>, it creates a new instance of <see cref="CustomColor"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator CustomColor(DMD.SystemColor color)
  {
    var schemeColorDef = new CustomColor();
    schemeColorDef.Color = new ColorType();
    schemeColorDef.Color.InternalColor = color;
    return schemeColorDef;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.PresetColor"/> color value directly to a <see cref="CustomColor"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.PresetColor"/> value is assigned to a <see cref="CustomColor"/>, it creates a new instance of <see cref="CustomColor"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator CustomColor(DMD.PresetColor color)
  {
    var schemeColorDef = new CustomColor();
    schemeColorDef.Color = new ColorType();
    schemeColorDef.Color.InternalColor = color;
    return schemeColorDef;
  }

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
  public new ColorType? Color { get => _color; set => UpdateField(ref _color, value, nameof(Color)); }
  private ColorType? _color;

  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  private new void LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    Color = ColorType.LoadColorFromOpenXmlStatic(openXmlElement) as ColorType;
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  private void UpdateColorInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    ColorType.UpdateColorInOpenXmlStatic(Color, openXmlElement);
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
  public ColorType? ColorType
  {
    get => Color as ColorType;
    set => Color = value;
  }
}