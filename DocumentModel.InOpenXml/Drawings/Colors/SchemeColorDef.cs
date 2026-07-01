namespace DocumentModel.Drawings;
/// <summary>
/// A specific color type that represents a scheme color definition, which is used to define colors based on a color scheme in drawing elements. This class serves as a base for specific scheme color definitions that can be used in themes and color schemes within the document model. It allows for the representation of colors that are defined by a scheme, enabling consistent color usage across different drawing elements that reference the same scheme color definition.
/// </summary>
[XmlRoot("SchemeColorDef", Namespace = "DocumentModel.Drawings")]
[OpenXmlType(typeof(DXD.Color2Type))]
public class SchemeColorDef : ColorHolder<DXD.Color2Type>
{

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelHex"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.ColorType color) => new() { Color = color };

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelPercentage"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.RgbColorModelPercentage color)
  {
    var schemeColorDef = new SchemeColorDef();
    schemeColorDef.Color = color;
    return schemeColorDef;
  }
  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.RgbColorModelHex color)
  {
    var schemeColorDef = new SchemeColorDef();
    schemeColorDef.Color = color;
    return schemeColorDef;
  }
  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.HslColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.HslColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.HslColor color)
  {
    var schemeColorDef = new SchemeColorDef();
    schemeColorDef.Color = color;
    return schemeColorDef;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.SystemColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.SystemColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.SystemColor color)
  {
    var schemeColorDef = new SchemeColorDef();
    schemeColorDef.Color= color;
    return schemeColorDef;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.PresetColor"/> color value directly to a <see cref="SchemeColorDef"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to scheme color definitions, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.PresetColor"/> value is assigned to a <see cref="SchemeColorDef"/>, it creates a new instance of <see cref="SchemeColorDef"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator SchemeColorDef(DMD.PresetColor color)
  {
    var schemeColorDef = new SchemeColorDef();
    schemeColorDef.Color = color;
    return schemeColorDef;
  }



  ///// <summary>
  ///// Gets or sets the effective color value of the scheme color
  ///// <para>
  ///// Gets the color value of the scheme color definition by checking each color type in a specific order and returning the first non-null color value found. The order of checking is as follows: RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, and finally Preset Color. This method allows for retrieving the effective color value of the scheme color definition based on the defined color types.
  ///// </para>
  ///// <para>
  ///// Sets the color value of the scheme color definition by determining the type of the provided color value and assigning it to the corresponding color property. The method checks the type of the input color value and updates the appropriate color property (RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, or Preset Color) based on the type of the input color. This allows for setting the color value of the scheme color definition using a single property while internally managing multiple color types.
  ///// </para>
  ///// </summary>
  //public ColorType? ColorType
  //{
  //  get => Color as ColorType;
  //  set => Color = value;
  //}

  ///// <summary>
  ///// Gets the RGB color value represented by this scheme color, if available.
  ///// </summary>
  //public uint? RGB => (Color as IColor)?.RGB;
}