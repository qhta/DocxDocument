namespace DocumentModel.OpenXml;

/// <summary>
/// Provides helper methods for converting StringList values to and from OpenXml.
/// </summary>
public static class StringListConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DXW.StringType), nameof(ConvertFromStringType), nameof(ConvertToStringType)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="StringListConverter"/>.
  /// </summary>
  static StringListConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(StringListConverter), typeof(StringList), supportedConversions, ConversionToMap, ConversionFromMap);
  }


  #region String conversion methods

  /// <summary>
  /// Retrieves the value of a String as a nullable StringList.
  /// </summary>
  /// <param name="element">The String to convert.</param>
  /// <returns>The StringList value or null if the element is null.</returns>
  public static StringList? ConvertFromString(String? element)
  {
    return element;
  }

  /// <summary>
  /// Creates a String from a nullable StringList.
  /// </summary>
  /// <param name="value">The StringList value.</param>
  /// <returns>A new String containing the StringList, or null if the input StringList is null.</returns>
  public static String? ConvertToString(StringList? value)
  {
    if (value == null) return null;

    return value;
  }

  #endregion


  #region StringValue conversion methods

  /// <summary>
  /// Retrieves the value of a StringValue as a nullable StringList.
  /// </summary>
  /// <param name="element">The StringValue to convert.</param>
  /// <returns>The StringList value or null if the element is null.</returns>
  public static StringList? ConvertFromStringValue(DX.StringValue? element)
  {
    if (element == null) return null;
   
    return new StringList(element.Value);
  }

  /// <summary>
  /// Creates a StringValue from a nullable StringList.
  /// </summary>
  /// <param name="value">The StringList value.</param>
  /// <returns>A new StringValue containing the StringList, or null if the input StringList is null.</returns>
  public static DX.StringValue? ConvertToStringValue(StringList? value)
  {
    if (value == null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    return new DX.StringValue { Value = value.ToString() };
  }

  #endregion

  #region StringType conversion methods

  /// <summary>
  /// Retrieves the StringList value from a StringType element.
  /// </summary>
  /// <param name="element">The StringType element.</param>
  /// <returns>The StringList value, or null if result cannot be determined.</returns>
  public static StringList? ConvertFromStringType(DXW.StringType? element)
  {
    if (element == null)
      return null;

    return element?.Val?.Value;
  }

  /// <summary>
  /// Creates an instance of StringType and sets its Val property.
  /// </summary>
  /// <param name="value">The StringList value to set.</param>
  /// <param name="targetType">The target type for the Icreated StringType instance. Must be a subclass of StringType.</param>
  /// <returns>Created StringType instance or null if element is null.</returns>
  public static DXW.StringType? ConvertToStringType(StringList? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.StringType)Activator.CreateInstance(targetType)!;
    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    element.Val = value.ToString();
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafTextElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static StringList? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
  {
    if (element == null) return null;

    return element.Text;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The StringList value to set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(StringList? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    element.Text = value.ToString();
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static StringList? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? element)
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
  /// <param name="value">The StringList value to set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(StringList? value, Type targetType)
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
  public static StringList? GetValue(DX.OpenXmlSimpleType? element)
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
  /// <param name="value">The StringList value to set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXml EnumValue.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlSimpleType? CreateOpenXmlEnumValue(StringList? value, Type targetType)
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

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an StringList value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The StringList value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(StringList? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value to convert to an <see cref="StringList"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="StringList"/> is not supported.</exception>
  public static StringList? ConvertFrom(object? value)
  {
    return (StringList?)ConverterBase.ConvertFrom(value, typeof(StringList), ConversionFromMap);
  }

  #endregion
}
