namespace DocumentModel;

/// <summary>
/// Full color interface, supporting both RGB and theme colors.
/// </summary>
public interface IColor
{
  /// <summary>
  /// Gets or sets the RGB value represented by this property.
  /// </summary>
  public UInt32? RGB { get; set; }

  /// <summary>
  /// Red component of the color as a percentage value.
  /// </summary>
  public double? Red { get; set; }

  /// <summary>
  /// Green component of the color as a percentage value.
  /// </summary>
  public double? Green { get; set; }

  /// <summary>
  /// Blue component of the color as a percentage value.
  /// </summary>
  public double? Blue { get; set; }

  /// <summary>
  /// Gets or sets the name of color. May be used to specify a color by name, such as "red", "blue", etc.
  /// The actual interpretation of the name depends on the context in which it is used and may be mapped to a specific RGB value or theme color.
  /// </summary>
  public string? Name { get; set; }

  ///// <summary>
  ///// Gets or sets the theme tint represented by this property.
  ///// </summary>
  ///// <remarks>
  ///// Given an RGB color defined as three hex values in RRGGBB format, the shade is applied as follows:
  ///// <list type="bullet">
  ///// <item>Convert the color to the HSL color format (values from 0 to 1)</item>
  ///// <item>Modify the luminance factor as follows:  L′ = Tint_percentage + (1 − Tint_percentage)</item>
  ///// <item>Convert the resultant HSL color to RGB</item>
  ///// </list> 
  ///// </remarks> 
  //public double? Tint { get; set; }

  ///// <summary>
  ///// Gets or sets the theme shade represented by this property.
  ///// </summary>
  ///// <remarks>
  ///// Given an RGB color defined as three hex values in RRGGBB format, the shade is applied as follows:
  ///// <list type="bullet">
  ///// <item>Convert the color to the HSL color format (values from 0 to 1)</item>
  ///// <item>Modify the luminance factor as follows:  L′ =L* Shade_percentage </item>
  ///// <item>Convert the resultant HSL color to RGB</item>
  ///// </list>
  ///// </remarks>  
  //public double? Shade { get; set; }

}