namespace DocumentModel.OpenXml;

/// <summary>
/// Provides helper methods for converting string values to and from OpenXml.
/// </summary>
public static class StringConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DXW.StringType), nameof(ConvertFromStringType), nameof(ConvertToStringType)),
    new(typeof(DXW.String255Type), nameof(ConvertFromString255Type), nameof(ConvertToString255Type)),
    new(typeof(DXW.String253Type), nameof(ConvertFromString253Type), nameof(ConvertToString253Type)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(DX.OpenXmlSimpleType), nameof(ConvertFromOpenXmlSimpleType), nameof(ConvertToOpenXmlSimpleType)),
    new(typeof(Uri), nameof(ConvertFromUri), nameof(ConvertToUri))
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  static StringConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(StringConverter), typeof(String), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region StringValue conversion methods

  /// <summary>
  /// Retrieves the value of a StringValue as a nullable string.
  /// </summary>
  /// <param name="element">The StringValue to convert.</param>
  /// <returns>The string value or null if the element is null.</returns>
  public static string? ConvertFromStringValue(DX.StringValue element) { return element.Value; }

  /// <summary>
  /// Creates a StringValue from a nullable string.
  /// </summary>
  /// <param name="value">The string value.</param>
  /// <returns>A new StringValue containing the string, or null if the input string is null.</returns>
  public static DX.StringValue? ConvertToStringValue(String? value)
  {
    if (value == null) return null;

    return new DX.StringValue { Value = value };
  }

  #endregion

  #region StringType conversion methods

  /// <summary>
  /// Retrieves the string value from a StringType element.
  /// </summary>
  /// <param name="element">The StringType element.</param>
  /// <returns>The string value, or null if result cannot be determined.</returns>
  public static string? ConvertFromStringType(DXW.StringType element) { return element.Val?.Value; }

  /// <summary>
  /// Creates an instance of StringType and sets its Val property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the Icreated StringType instance. Must be a subclass of StringType.</param>
  /// <returns>Created StringType instance or null if element is null.</returns>
  public static DXW.StringType? ConvertToStringType(String? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.StringType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region String255Type conversion methods

  /// <summary>
  /// Retrieves the string value from a String255Type element.
  /// </summary>
  /// <param name="element">The String255Type element.</param>
  /// <returns>The string value, or null if result cannot be determined.</returns>
  public static string? ConvertFromString255Type(DXW.String255Type? element)
  {
    if (element == null) return null;

    return element.Val?.Value;
  }

  /// <summary>
  /// Creates an instance of String255Type and sets its Val property.
  /// </summary>
  /// <param name="value">The string value to set</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of String255Type.</param>
  /// <returns>Created String255Type instance or null if value is null.</returns>
  public static DXW.String255Type? ConvertToString255Type(String? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.String255Type)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region String253Type conversion methods

  /// <summary>
  /// Retrieves the string value from a String253Type element.
  /// </summary>
  /// <param name="element">The String253Type element.</param>
  /// <returns>The string value, or null if result cannot be determined.</returns>
  public static string? ConvertFromString253Type(DXW.String253Type? element)
  {
    if (element == null) return null;

    return element.Val?.Value;
  }

  /// <summary>
  /// Creates an instance of String253Type and sets its Val property.
  /// </summary>
  /// <param name="value">The string value to set</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of String253Type.</param>
  /// <returns>Created String253Type instance or null if value is null.</returns>
  public static DXW.String253Type? ConvertToString253Type(String? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.String253Type)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafTextElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static string? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
  {
    if (element == null) return null;

    return element.Text;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(string? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = value;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static string? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? element)
  {
    if (element == null) return null;

    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    var value = valProperty.GetValue(element);
    return value?.ToString();
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(string? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    valProperty.SetValue(element, new DX.StringValue(value));
    return element;
  }

  #endregion

  #region OpenXmlSimpleType conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXml EnumValue.
  /// </summary>
  /// <param name="element">The OpenXml EnumValue.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static string? ConvertFromOpenXmlSimpleType(DX.OpenXmlSimpleType? element)
  {
    if (element == null) return null;

    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Value' not found on {element.GetType().Name}");

    var value = valProperty.GetValue(element);
    return value?.ToString();
  }

  /// <summary>
  /// Creates an OpenXml EnumValue and sets its value or text property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXml EnumValue.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlSimpleType? ConvertToOpenXmlSimpleType(string? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlSimpleType)Activator.CreateInstance(targetType)!;
    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Value' not found on {element.GetType().Name}");

    valProperty.SetValue(element, new DX.StringValue(value));
    return element;
  }

  #endregion

  #region Uri conversion methods

  /// <summary>
  /// Converts a <see cref="Uri"/> into its string representation for storage in Open XML values.
  /// </summary>
  /// <param name="uri">The URI instance to serialize.</param>
  /// <returns>The absolute or relative string form of <paramref name="uri"/>, or null when <paramref name="uri"/> is null.</returns>
  public static string? ConvertFromUri(Uri? uri)
  {
    if (uri == null) return null;

    return uri.ToString();
  }

  /// <summary>
  /// Parses a string into a <see cref="Uri"/> instance compatible with the requested target type.
  /// </summary>
  /// <param name="value">The textual URI to parse.</param>
  /// <param name="targetType">The requested URI type (currently informational only).</param>
  /// <returns>A new <see cref="Uri"/> matching <paramref name="value"/>, or null when <paramref name="value"/> is null.</returns>
  /// <exception cref="UriFormatException">Thrown when <paramref name="value"/> is not a valid URI.</exception>
  public static Uri? ConvertToUri(string? value, Type targetType)
  {
    if (value == null) return null;

    if (value == String.Empty) return null;

    return new Uri(value);
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a CLR string into the requested Open XML type using the registered converter map.
  /// </summary>
  /// <param name="value">ISource string to translate.</param>
  /// <param name="targetType">Destination Open XML type.</param>
  /// <returns>The converted object instance.</returns>
  /// <exception cref="NotSupportedException">Raised when no conversion is registered for <paramref name="targetType"/>.</exception>
  public static object? ConvertTo(string? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts any registered Open XML instance back to a CLR string.
  /// </summary>
  /// <param name="value">ISource Open XML object to convert.</param>
  /// <returns>The extracted string representation.</returns>
  /// <exception cref="NotSupportedException">Raised when the source type has no registered converter.</exception>
  public static string? ConvertFrom(object? value)
  {
    return (string?)ConverterBase.ConvertFrom(value, typeof(string), ConversionFromMap);
  }

  #endregion
}
