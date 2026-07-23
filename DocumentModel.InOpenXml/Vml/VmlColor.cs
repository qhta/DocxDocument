namespace DocumentModel.Vml;

/// <summary>
/// Represents a color value that can be specified as a hexadecimal RGB value or as a named theme color, and provides
/// methods and conversions for working with color representations in OpenXML documents.  
/// </summary>
/// <remarks>The Color class supports initialization and parsing from both hexadecimal RGB strings and theme color
/// names, and provides implicit conversions to and from related types such as string, UInt32, and HexColor. It is
/// designed for use with OpenXML document models, enabling seamless integration with color attributes in
/// WordprocessingML and other OpenXML schemas. The class also provides methods for converting to and from
/// OpenXML-specific color representations.</remarks>
[DataContract]
[XmlRoot("VmlColor", Namespace = "DocumentModel.Vml")]
public partial class VmlColor : ModelElement
{
  /// <summary>
  /// Initializes a new instance of the Color class.
  /// </summary>
  public VmlColor() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the Color class using the specified color string.
  /// </summary>
  /// <remarks>The compoundString parameter can be null, in which case the Color instance will be initialized with a
  /// null value.</remarks>
  /// <param name = "colorString">The color string to initialize the Color instance.</param>
  public VmlColor(string colorString)
  {
    Init(colorString);
  }

  /// <summary>
  /// Initializes a new instance of the Color class using the specified hexadecimal RGB color value.
  /// </summary>
  /// <param name = "hexColor">The </param>
  public VmlColor(UInt32 hexColor)
  {
    Value = new HexColor(hexColor);
  }

  /// <summary>
  /// <para>Run Content Color</para>
  /// <para>Represents the following attribute in the schema: w:val</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  public HexColor? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }
  private HexColor? _Value;

  /// <summary>
  /// Name of the color, which can be used to specify a color by name, such as "Red", "Black", etc.
  /// If the color is not found in the PresetColors enumeration, an exception is raised.
  /// </summary>
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;

  /// <summary>
  /// Implicitly converts a string to a <see cref = "VmlColor"/> value.
  /// </summary>
  /// <param name = "value">The string to convert.</param>
  /// <returns>A <see cref = "VmlColor"/> value representing the color.</returns>
  public static implicit operator VmlColor(string value) => new VmlColor(value);

  /// <summary>
  /// Implicitly converts an <see cref = "VmlColor"/> value to a string representation.
  /// </summary>
  /// <param name = "value">The <see cref = "VmlColor"/> value to convert.</param>
  /// <returns>A string representation of the RGB color.</returns>
   // ReSharper disable once SpecifyACultureInStringConversionExplicitly
  public static implicit operator String(VmlColor value) => value.ToString()!;

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

    if (HexColor.TryParse(colorString, out var hexColor))
      Value = hexColor;
    else
    if (Enum.TryParse<PresetColors>(colorString, out var presetColor))
    {
      Name = presetColor.ToString();
      Value = new HexColor((uint)presetColor ^ 0xFF000000);
    }
    else
    if (HexColor.TryParse(colorString, out var hexColor2))
    {
      Value = hexColor2;
    }
    else
      Name = colorString; // Fallback to storing the raw string if no known format matches
  }

  /// <summary>
  /// String representation of the Color instance, which includes the hexadecimal color value and theme color information if available.
  /// </summary>
  /// <returns></returns>
  public override string? ToString()
  {
    return Value?.ToString();
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
  public static VmlColor Parse(string colorString)
  {
    if (string.IsNullOrEmpty(colorString))
      throw new ArgumentException("Color string cannot be null or empty.", nameof(colorString));
    return new VmlColor(colorString);
  }

  /// <summary>
  /// Attempts to parse the specified color string into a <see cref = "VmlColor"/> object, supporting both hexadecimal RGB
  /// and named theme color formats.
  /// </summary>
  /// <remarks>This method supports parsing color strings in both hexadecimal RGB format and as named theme
  /// colors. If the input string is null or empty, parsing fails.</remarks>
  /// <param name = "colorString">The color string to parse. This can be a hexadecimal RGB value (e.g., "#FF0000") or the name of a theme color.
  /// Cannot be null or empty.</param>
  /// <param name = "color">When this method returns <see langword="true"/>, contains the parsed <see cref = "VmlColor"/> object; otherwise, is
  /// <see langword="null"/>.</param>
  /// <returns>true if the color string was successfully parsed; otherwise, false.</returns>
  public static bool TryParse(string? colorString, out VmlColor? color)
  {
    color = null;
    if (string.IsNullOrEmpty(colorString))
      return false;
    try
    {
      color = new VmlColor(colorString);
      return true;
    }
    catch (FormatException)
    {
      return false;
    }
  }

  /// <summary>
  /// Creates new instance of <see cref = "VmlColor"/> based on the provided OpenXml color properties, including the color value, theme color, tint,
  /// and shade.
  /// </summary>
  /// <param name = "val">StringValue representing the color value.</param>
  /// <returns>A Color object populated with the provided OpenXml color properties. If no color properties are provided, returns null.</returns>
  public static DMV.VmlColor? FromOpenXml(DX.StringValue? val)
  {
    DMV.VmlColor? color = null;
    if (val?.Value != null)
    {
      color ??= new DMV.VmlColor(val.Value);
    }

    return color;
  }

  /// <summary>
  /// Converts the current color and theme-related properties to their OpenXML representations.
  /// </summary>
  /// <remarks>Use this method to obtain OpenXML-compatible values for color and theme settings when generating
  /// or modifying OpenXML documents. Properties that are not set will result in null values in the returned
  /// tuple.</remarks>
  /// <returns>A DX.StringValue representing the color value, or null if not set.</returns>
  public DX.StringValue? ToOpenXml()
  {
    if (Value is not null)
      return new DX.StringValue(Value.ToString());
    return null;
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable HexColor to a nullable DMV.Color instance.
  /// </summary>
  /// <remarks>This operator enables seamless assignment of a nullable HexColor to a nullable DMV.Color without
  /// explicit casting. The Val property of the resulting Color is set to the provided HexColor value.</remarks>
  /// <param name = "value">The HexColor value to convert. If null, the result is null.</param>
  public static implicit operator DMV.VmlColor?(HexColor? value)
  {
    if (value is null)
      return null!;
    return new VmlColor
    {
      Value = value,
    };
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable Color to a nullable HexColor.
  /// </summary>
  /// <remarks>If the specified Color is null, the result is null; otherwise, the HexColor value of the Color is
  /// returned. This operator enables seamless conversion between Color and HexColor types when working with nullable
  /// values.</remarks>
  /// <param name = "color">The nullable Color instance to convert to a HexColor.</param>
  public static implicit operator HexColor?(VmlColor? color)
  {
    if (color is null)
      return null;
    if (UInt32.TryParse(color.Value?.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hexValue))
      return new HexColor(hexValue);
    return null;
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable UInt32 to a nullable DMV.Color instance.
  /// </summary>
  /// <remarks>This operator enables seamless assignment of a nullable UInt32 to a nullable DMV.Color without
  /// explicit casting. The Val property of the resulting Color is set to the provided UInt32 value.</remarks>
  /// <param name = "value">The UInt32 value to convert. If null, the result is null.</param>
  public static implicit operator DMV.VmlColor?(UInt32? value)
  {
    if (value is null)
      return null!;
    return new VmlColor
    {
      Value = new HexColor(value.Value),
    };
  }

  /// <summary>
  /// Defines an implicit conversion from a nullable Color to a nullable UInt32.
  /// </summary>
  /// <remarks>If the specified Color is null, the result is null; otherwise, the UInt32 value of the Color is
  /// returned. This operator enables seamless conversion between Color and UInt32 types when working with nullable
  /// values.</remarks>
  /// <param name = "color">The nullable Color instance to convert to an UInt32.</param>
  public static implicit operator UInt32?(VmlColor? color)
  {
    if (color is null)
      return null;
    if (UInt32.TryParse(color.Value?.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var hexValue))
      return hexValue;
    return null;
  }
}