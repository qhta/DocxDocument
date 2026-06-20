namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a color definition for use in WordprocessingML documents.
/// This class extends <see cref = "AnyColor"/> and is used to specify color values for document elements such as borders, shading, and text, enabling advanced formatting and visual customization.
/// </summary>
[OpenXmlType(typeof(DXW.Color))]
[XmlRoot("Color", Namespace = "DocumentModel.Wordprocessing")]
public partial class Color : Color<DXW.Color>
{
  /// <summary>
  /// Initializes a new instance of the Color class.
  /// </summary>
  public Color() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the Color class using the specified color string.
  /// </summary>
  /// <remarks>The compoundString parameter can be null, in which case the Color instance will be initialized with a
  /// null value.</remarks>
  /// <param name = "colorString">The color string to initialize the Color instance.</param>
  public Color(string colorString)
  {
    Init(colorString);
  }

  /// <summary>
  /// Initializes a new instance of the Color class using the specified hexadecimal RGB color value.
  /// </summary>
  /// <param name = "hexColor">The </param>
  public Color(UInt32 hexColor)
  {
    Val = hexColor;
  }

  /// <summary>
  /// <para>Run Content Color</para>
  /// <para>Represents the following attribute in the schema: w:val</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.Val))]
  public HexColor? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
  private HexColor? _Val;

  /// <summary>
  /// <para>Run Content Theme Color</para>
  /// <para>Represents the following attribute in the schema: w:themeColor</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.ThemeColor))]
  public ThemeColors? ThemeColor { get => _ThemeColor; set => UpdateField(ref _ThemeColor, value, nameof(ThemeColor)); }
  private ThemeColors? _ThemeColor;

  /// <summary>
  /// <para>Run Content Theme Color Tint</para>
  /// <para>Represents the following attribute in the schema: w:themeTint</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.ThemeTint))]
  public HexPercent? ThemeTint { get => _ThemeTint; set => UpdateField(ref _ThemeTint, value, nameof(ThemeTint)); }
  private HexPercent? _ThemeTint;

  /// <summary>
  /// <para>Run Content Theme Color Shade</para>
  /// <para>Represents the following attribute in the schema: w:themeShade</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.ThemeShade))]
  public HexPercent? ThemeShade { get => _ThemeShade; set => UpdateField(ref _ThemeShade, value, nameof(ThemeShade)); }
  private HexPercent? _ThemeShade;

  /// <summary>
  /// Implicitly converts a string to a <see cref = "Color"/> value.
  /// </summary>
  /// <param name = "value">The string to convert.</param>
  /// <returns>A <see cref = "Color"/> value representing the color.</returns>
  public static implicit operator Color(string value) => new Color(value);

  /// <summary>
  /// Implicitly converts an <see cref = "Color"/> value to a string representation.
  /// </summary>
  /// <param name = "value">The <see cref = "Color"/> value to convert.</param>
  /// <returns>A string representation of the RGB color.</returns>
   // ReSharper disable once SpecifyACultureInStringConversionExplicitly
  public static implicit operator String(Color value) => value.ToString()!;

  /// <summary>
  /// Initializes instance properties based on the provided color string,
  /// which can include hexadecimal RGB values and theme color information.
  /// The method parses the input string to extract and set the appropriate properties of the Color instance.
  /// </summary>
  /// <param name = "colorString">The string that represents the color to initialize the Color instance.</param>
  /// <exception cref = "ArgumentException"></exception>
  protected void Init(String colorString)
  {
    if (string.IsNullOrEmpty(colorString))
      throw new ArgumentException("Color string cannot be null or empty.", nameof(colorString));
    var strings = colorString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (var str in strings)
    {
      var s = str.Trim();
      if (HexColor.TryParse(s, out var hexColor))
        Val = hexColor;
      else if (Enum.TryParse<ThemeColors>(s, true, out var themeColor))
        ThemeColor = themeColor;
      if (s.StartsWith("ThemeTint:", StringComparison.OrdinalIgnoreCase) && byte.TryParse(s.Substring("ThemeTint:".Length).Trim(), out var themeTint))
        ThemeTint = themeTint;
      if (s.StartsWith("ThemeShade:", StringComparison.OrdinalIgnoreCase) && byte.TryParse(s.Substring("ThemeShade:".Length).Trim(), out var themeShade))
        ThemeShade = themeShade;
    }
  }

  /// <summary>
  /// String representation of the Color instance, which includes the hexadecimal color value and theme color information if available.
  /// </summary>
  /// <returns></returns>
  public override string? ToString()
  {
    var strings = new List<string>();
    if (Val is not null)
      strings.Add(Val.ToString()!);
    if (ThemeColor is not null)
      strings.Add(ThemeColor.ToString()!);
    if (ThemeTint is not null)
      strings.Add($"ThemeTint:{ThemeTint}");
    if (ThemeShade is not null)
      strings.Add($"ThemeShade:{ThemeShade}");
    return String.Join(" ", strings);
  }

  /// <summary>
  /// Parses a string representation of a color and returns a corresponding Color object. Supports both hexadecimal RGB
  /// values and theme color names.
  /// </summary>
  /// <remarks>The method first attempts to parse the input as a hexadecimal RGB value. If parsing fails, it
  /// then tries to interpret the input as a theme color name. If both attempts fail, a FormatException is
  /// thrown.</remarks>
  /// <param name = "colorString">The string that represents the color to parse. This value must be a valid hexadecimal color value or a recognized
  /// theme color name. Cannot be null or empty.</param>
  /// <returns>A Color object that corresponds to the parsed color value.</returns>
  /// <exception cref = "ArgumentException">Thrown when the colorString parameter is null or empty.</exception>
  /// <exception cref = "FormatException">Thrown when colorString is not a valid hexadecimal color value or a recognized theme color name.</exception>
  public static Color Parse(string colorString)
  {
    if (string.IsNullOrEmpty(colorString))
      throw new ArgumentException("Color string cannot be null or empty.", nameof(colorString));
    return new Color(colorString);
  }

  /// <summary>
  /// Attempts to parse the specified color string into a <see cref = "Color"/> object, supporting both hexadecimal RGB
  /// and named theme color formats.
  /// </summary>
  /// <remarks>This method supports parsing color strings in both hexadecimal RGB format and as named theme
  /// colors. If the input string is null or empty, parsing fails.</remarks>
  /// <param name = "colorString">The color string to parse. This can be a hexadecimal RGB value (e.g., "#FF0000") or the name of a theme color.
  /// Cannot be null or empty.</param>
  /// <param name = "color">When this method returns <see langword="true"/>, contains the parsed <see cref = "Color"/> object; otherwise, is
  /// <see langword="null"/>.</param>
  /// <returns>true if the color string was successfully parsed; otherwise, false.</returns>
  public static bool TryParse(string? colorString, out Color? color)
  {
    color = null;
    if (string.IsNullOrEmpty(colorString))
      return false;
    try
    {
      color = new Color(colorString);
      return true;
    }
    catch (FormatException)
    {
      return false;
    }
  }

  /// <summary>
  /// Creates new instance of <see cref = "Color"/> based on the provided OpenXml color properties, including the color value, theme color, tint,
  /// and shade.
  /// </summary>
  /// <param name = "val">StringValue representing the color value.</param>
  /// <param name = "themeColor">EnumValue representing the theme color.</param>
  /// <param name = "themeTint">StringValue representing the theme tint.</param>
  /// <param name = "themeShade">StringValue representing the theme shade.</param>
  /// <returns>A Color object populated with the provided OpenXml color properties. If no color properties are provided, returns null.</returns>
  public static DMW.Color? FromOpenXml(DX.StringValue? val = null, DX.EnumValue<DXW.ThemeColorValues>? themeColor = null, DX.StringValue? themeTint = null, DX.StringValue? themeShade = null)
  {
    DMW.Color? color = null;
    if (val?.Value != null)
    {
      color ??= new DMW.Color();
      color.Val = HexColorConverter.ConvertFrom(val);
    }

    if (themeColor?.Value != null)
    {
      color ??= new DMW.Color();
      color.ThemeColor = (ThemeColors)EnumTypeConverter.ConvertFrom(themeColor, typeof(ThemeColors))!;
    }

    if (themeTint?.Value != null)
    {
      color ??= new DMW.Color();
      color.ThemeTint = HexPercentConverter.ConvertFrom(themeTint)!;
    }

    if (themeShade?.Value != null)
    {
      color ??= new DMW.Color();
      color.ThemeShade = HexPercentConverter.ConvertFrom(themeShade)!;
    }

    return color;
  }

  /// <summary>
  /// Converts the current color and theme-related properties to their OpenXML representations.
  /// </summary>
  /// <remarks>Use this method to obtain OpenXML-compatible values for color and theme settings when generating
  /// or modifying OpenXML documents. Properties that are not set will result in null values in the returned
  /// tuple.</remarks>
  /// <returns>A tuple containing the converted color value, theme color, theme tint, and theme shade. Each element may be null
  /// if the corresponding property is not set.</returns>
  public (DX.StringValue? val, DX.EnumValue<DXW.ThemeColorValues>? themeColor, DX.StringValue? themeTint, DX.StringValue? themeShade) ToOpenXml()
  {
    DX.StringValue? val = null;
    if (Val is not null)
      val = HexColorConverter.ConvertTo(Val, typeof(DX.StringValue)) as DX.StringValue;
    DX.EnumValue<DXW.ThemeColorValues>? themeColor = null;
    if (ThemeColor is not null)
      // ReSharper disable once InvokeAsExtensionMember
      themeColor = EnumTypeConverter.CreateOpenXmlEnumValue<DXW.ThemeColorValues, ThemeColors>(ThemeColor.Value);
    DX.StringValue? themeTint = null;
    if (ThemeTint is not null)
      themeTint = HexPercentConverter.ConvertTo(ThemeTint, typeof(DX.StringValue)) as DX.StringValue;
    DX.StringValue? themeShade = null;
    if (ThemeShade is not null)
      themeShade = HexPercentConverter.ConvertTo(ThemeShade, typeof(DX.StringValue)) as DX.StringValue;
    return (val, themeColor, themeTint, themeShade);
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable HexColor to a nullable DMW.Color instance.
  /// </summary>
  /// <remarks>This operator enables seamless assignment of a nullable HexColor to a nullable DMW.Color without
  /// explicit casting. The Val property of the resulting Color is set to the provided HexColor value.</remarks>
  /// <param name = "value">The HexColor value to convert. If null, the result is null.</param>
  public static implicit operator DMW.Color? (HexColor? value)
  {
    if (value is null)
      return null!;
    return new Color
    {
      Val = value,
    };
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable Color to a nullable HexColor.
  /// </summary>
  /// <remarks>If the specified Color is null, the result is null; otherwise, the HexColor value of the Color is
  /// returned. This operator enables seamless conversion between Color and HexColor types when working with nullable
  /// values.</remarks>
  /// <param name = "color">The nullable Color instance to convert to a HexColor.</param>
  public static implicit operator HexColor? (Color? color)
  {
    if (color is null)
      return null;
    return color.Val;
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable UInt32 to a nullable DMW.Color instance.
  /// </summary>
  /// <remarks>This operator enables seamless assignment of a nullable UInt32 to a nullable DMW.Color without
  /// explicit casting. The Val property of the resulting Color is set to the provided UInt32 value.</remarks>
  /// <param name = "value">The UInt32 value to convert. If null, the result is null.</param>
  public static implicit operator DMW.Color? (UInt32? value)
  {
    if (value is null)
      return null!;
    return new Color
    {
      Val = value,
    };
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable Color to a nullable UInt32.
  /// </summary>
  /// <remarks>If the specified Color is null, the result is null; otherwise, the UInt32 value of the Color is
  /// returned. This operator enables seamless conversion between Color and UInt32 types when working with nullable
  /// values.</remarks>
  /// <param name = "color">The nullable Color instance to convert to an UInt32.</param>
  public static implicit operator UInt32? (Color? color)
  {
    if (color is null)
      return null;
    return color.Val;
  }

}