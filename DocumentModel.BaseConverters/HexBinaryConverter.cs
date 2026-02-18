namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for HexBinary values to/from Open XML.
/// </summary>
public static class HexBinaryConverter
{


  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.HexBinaryValue), nameof(ConvertFromHexBinaryValue), nameof(ConvertToHexBinaryValue)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(DXW.FontSignature), nameof(ConvertFromFontSignature), nameof(ConvertToFontSignature)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="HexBinaryConverter"/>.
  /// </summary>
  static HexBinaryConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(HexBinaryConverter), typeof(HexBinary), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region HexBinaryValue conversion.

  /// <summary>
  /// Retrieves a HexBinary from a HexBinaryValue.
  /// </summary>
  /// <param name="val">The HexBinaryValue to convert.</param>
  /// <returns>A HexBinary representing the value, or null if the input is null.</returns>
  public static HexBinary? ConvertFromHexBinaryValue(DX.HexBinaryValue? val)
  {
    if (val == null)
      return null;

    var value = val.Value;
    if (value != null)
      return new HexBinary(value);

    return null;
  }

  /// <summary>
  /// Creates a HexBinaryValue from a HexBinary.
  /// </summary>
  /// <param name="value">The HexBinary to convert.</param>
  /// <returns>A HexBinaryValue element, or null if the input value is null.</returns>
  public static DX.HexBinaryValue? ConvertToHexBinaryValue(HexBinary? value)
  {
    if (value == null)
      return null;

    var element = new DX.HexBinaryValue
    {
      InnerText = value.ToString()
    };
    return element;
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to HexBinary.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The HexBinary value, or null if the element has no content.</returns>
  public static HexBinary? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new HexBinary(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an HexBinary value.
  /// </summary>
  /// <param name="value">The HexBinary value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(HexBinary? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((HexBinary)value).ToString();
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region String conversion.

  /// <summary>
  /// Converts the specified string representation of a number to its 16-bit signed integer equivalent.
  /// </summary>
  /// <param name="value">The string to convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A 16-bit signed integer equivalent to the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static HexBinary? ConvertFromString(string? value)
  {
    if (value == null) return null;
    return new HexBinary(value);
  }

  /// <summary>
  /// Converts a nullable 16-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 16-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(HexBinary? value)
  {
    if (value == null) return null;

    var text = ((HexBinary)value).ToString();
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to HexBinary.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The HexBinary value, or null if the element has no content.</returns>
  public static HexBinary? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    return new HexBinary(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an HexBinary value.
  /// </summary>
  /// <param name="value">The HexBinary value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(HexBinary? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((HexBinary)value).ToString();
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a HexBinary from an OpenXmlLeafElement having a "Value" property containing a base64 string.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A HexBinary representing the value, or null if the element is null.</returns>
  public static HexBinary? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? element)
  {
    if (element == null)
      return null;

    var valProperty = element.GetType().GetProperty("Value") ?? element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"The OpenXml element of type {element.GetType()} does not have a valid 'Value' property.");
    var value = valProperty.GetValue(element);
    if (value != null)
      return ConvertFrom(value);
    return null;
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement element containing a base64 string "Value" property from a HexBinary.
  /// </summary>
  /// <param name="value">The HexBinary to convert.</param>
  /// <param name="targetType">The type of OpenXml element to create.</param>
  /// <returns>An instance of the element type, or null if the input value is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(HexBinary? value, Type targetType)
  {
    if (value == null)
      return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProperty = targetType.GetProperty("Value") ?? element.GetType().GetProperty("Val");
    if (valProperty != null)
    {
      var valObject = ConvertTo(value, valProperty.PropertyType);
      valProperty.SetValue(element, valObject);
    }
    return element;
  }

  #endregion
  
  #region FontSignature conversion.

  /// <summary>
  /// Retrieves a HexBinary from an FontSignature.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A HexBinary representing the value, or null if the element is null.</returns>
  public static HexBinary? ConvertFromFontSignature(DXW.FontSignature? element)
  {
    if (element == null)
      return null;

    List<string> parts = new();
    if (element.UnicodeSignature0?.Value != null)
      parts.Add(element.UnicodeSignature0!.Value!);
    if (element.UnicodeSignature1?.Value != null)
      parts.Add(element.UnicodeSignature1!.Value!);
    if (element.UnicodeSignature2?.Value != null)
      parts.Add(element.UnicodeSignature2!.Value!);
    if (element.UnicodeSignature3?.Value != null)
      parts.Add(element.UnicodeSignature3!.Value!);
    if (element.CodePageSignature0?.Value != null)
      parts.Add(element.CodePageSignature0!.Value!);
    if (element.CodePageSignature1?.Value != null)
      parts.Add(element.CodePageSignature1!.Value!);
    var text = String.Join("-", parts);
    return new HexBinary(text);
  }

  /// <summary>
  /// Creates an FontSignature property from a HexBinary.
  /// </summary>
  /// <param name="value">The HexBinary to convert.</param>
  /// <param name="targetType">The type of OpenXml element to create.</param>
  /// <returns>An instance of the element type, or null if the input value is null.</returns>
  public static DXW.FontSignature? ConvertToFontSignature(HexBinary? value, Type targetType)
  {
    if (value == null)
      return null;

    var element = (DXW.FontSignature)Activator.CreateInstance(targetType)!;
    var text = ((HexBinary)value).ToString();
    string[] parts = text.Split('-');
    if (parts.Length > 0)
      element.UnicodeSignature0 = new DX.HexBinaryValue(parts[0]);
    if (parts.Length > 1)
      element.UnicodeSignature1 = new DX.HexBinaryValue(parts[1]);
    if (parts.Length > 2)
      element.UnicodeSignature2 = new DX.HexBinaryValue(parts[2]);
    if (parts.Length > 3)
      element.UnicodeSignature3 = new DX.HexBinaryValue(parts[3]);
    if (parts.Length > 4)
      element.CodePageSignature0 = new DX.HexBinaryValue(parts[4]);
    if (parts.Length > 5)
      element.CodePageSignature1 = new DX.HexBinaryValue(parts[5]);
    return element;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a value to a specified target type.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the element has no content.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion is not supported.</exception>
  public static object? ConvertTo(HexBinary? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts an Open XML value to a nullable HexBinary, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an HexBinary integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include HexBinaryValue, HexBinaryValue, HexBinaryValue, UHexBinaryValue, HexBinaryValue,
  /// UHexBinaryValue, UHexBinaryValue, and StringValue. May be null.</param>
  /// <returns>An HexBinary representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static HexBinary? ConvertFrom(object? value)
  {
    return (HexBinary?)ConverterBase.ConvertFrom(value, typeof(HexBinary), ConversionFromMap);
  }

  #endregion
}