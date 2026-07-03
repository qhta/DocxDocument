namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Base64Binary values to/from Open XML.
/// </summary>
public static class Base64BinaryConverter
{


  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.Base64BinaryValue), nameof(ConvertFromBase64BinaryValue), nameof(ConvertToBase64BinaryValue)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="Base64BinaryConverter"/>.
  /// </summary>
  static Base64BinaryConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(Base64BinaryConverter), typeof(Base64Binary), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region Base64BinaryValue conversion.

  /// <summary>
  /// Retrieves a Base64Binary from a Base64BinaryValue.
  /// </summary>
  /// <param name="val">The Base64BinaryValue to convert.</param>
  /// <returns>A Base64Binary representing the value, or null if the input is null.</returns>
  public static Base64Binary? ConvertFromBase64BinaryValue(DX.Base64BinaryValue? val)
  {
    if (val == null)
      return null;

    var value = val.Value;
    if (value != null)
      return new Base64Binary(value);

    return null;
  }

  /// <summary>
  /// Creates a Base64BinaryValue from a Base64Binary.
  /// </summary>
  /// <param name="value">The Base64Binary to convert.</param>
  /// <returns>A Base64BinaryValue element, or null if the input value is null.</returns>
  public static DX.Base64BinaryValue? ConvertToBase64BinaryValue(Base64Binary? value)
  {
    if (value == null)
      return null;

    var element = new DX.Base64BinaryValue
    {
      InnerText = value.ToString()
    };
    return element;
  }

  #endregion


  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to Base64Binary.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The Base64Binary value, or null if the element has no content.</returns>
  public static Base64Binary? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new Base64Binary(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Base64Binary value.
  /// </summary>
  /// <param name="value">The Base64Binary value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(Base64Binary? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((Base64Binary)value).ToString();
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
  private static Base64Binary? ConvertFromString(string? value)
  {
    if (value == null) return null;
    return new Base64Binary(value);
  }

  /// <summary>
  /// Converts a nullable 16-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 16-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(Base64Binary? value)
  {
    if (value == null) return null;

    var text = ((Base64Binary)value).ToString();
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Base64Binary.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Base64Binary value, or null if the element has no content.</returns>
  public static Base64Binary? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    return new Base64Binary(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Base64Binary value.
  /// </summary>
  /// <param name="value">The Base64Binary value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Base64Binary? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((Base64Binary)value).ToString();
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a Base64Binary from an OpenXmlLeafElement having a "Value" property containing a base64 string.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A Base64Binary representing the value, or null if the element is null.</returns>
  public static Base64Binary? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? element)
  {
    if (element == null)
      return null;

    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return new Base64Binary(value);
    }
    throw new InvalidOperationException($"The OpenXml element of type {element.GetType()} does not have a valid 'Value' property.");
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement element containing a base64 string "Value" property from a Base64Binary.
  /// </summary>
  /// <param name="value">The Base64Binary to convert.</param>
  /// <param name="targetType">The type of OpenXml element to create.</param>
  /// <returns>An instance of the element type, or null if the input value is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Base64Binary? value, Type targetType)
  {
    if (value == null)
      return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProperty = targetType.GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, value.ToString());
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
  public static object? ConvertTo(Base64Binary? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts an Open XML value to a nullable Base64Binary, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an Base64Binary integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include Base64BinaryValue, Base64BinaryValue, Base64BinaryValue, UBase64BinaryValue, Base64BinaryValue,
  /// UBase64BinaryValue, UBase64BinaryValue, and StringValue. May be null.</param>
  /// <returns>An Base64Binary representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Base64Binary? ConvertFrom(object? value)
  {
    return (Base64Binary?)ConverterBase.ConvertFrom(value, typeof(Base64Binary), ConversionFromMap);
  }

  #endregion
}
