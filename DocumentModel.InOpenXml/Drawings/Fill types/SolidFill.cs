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
  public ColorType? Color { get => _color; set => UpdateField(ref _color, value, nameof(Color)); }
  private ColorType? _color;

  
  ///// <summary>
  ///// Gets or sets the effective color value of the scheme color.
  ///// <para>
  ///// Gets the color value of the scheme color definition by checking each color type in a specific order and returning the first non-null color value found.
  ///// The order of checking is as follows: RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant,
  ///// Hue, Saturation, Luminance Color Model, System Color, SchemeColor, and finally Preset Color.
  ///// This method allows for retrieving the effective color value of the scheme color definition based on the defined color types.
  ///// </para>
  ///// <para>
  ///// Sets the color value of the scheme color definition by determining the type of the provided color value and assigning it to the corresponding color property.
  ///// The method checks the type of the input color value and updates the appropriate color property
  ///// (RGB Color Model - Percentage Variant, RGB Color Model - Hex Variant, Hue, Saturation, Luminance Color Model, System Color, SchemeColor, or Preset Color)
  ///// based on the type of the input color. This allows for setting the color value of the scheme color definition
  ///// using a single property while internally managing multiple color types.
  ///// </para>
  ///// </summary>
  //public IColor? Color
  //{
  //  get => Color;
  //}

}