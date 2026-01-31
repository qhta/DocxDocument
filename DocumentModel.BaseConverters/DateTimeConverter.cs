namespace DocumentModel.OpenXml;

/// <summary>
///   Defines a DateTime converter from OpenXml. 
/// </summary>
public static class DateTimeConverter
{

  private static readonly ConversionMethodInfo[] supportedTypes =
  [
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="DateTimeConverter"/>.
  /// </summary>
  static DateTimeConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(DateTimeConverter), typeof(DateTime), supportedTypes, ConversionToMap, ConversionFromMap);
  }

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to DateTime.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The DateTime value, or null if the element has no content.</returns>
  public static DateTime? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return DateTime.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an DateTime value.
  /// </summary>
  /// <param name="value">The DateTime value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(DateTime? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((DateTime)value).ToString("u");
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
  private static DateTime? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!DateTime.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 16-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 16-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(DateTime? value)
  {
    if (value == null) return null;

    var text = ((DateTime)value).ToString("u");
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to DateTime.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The DateTime value, or null if the element has no content.</returns>
  public static DateTime? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!DateTime.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an DateTime value.
  /// </summary>
  /// <param name="value">The DateTime value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(DateTime? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((DateTime)value).ToString("u");
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement to DateTime.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The DateTime value, or null if the element has no content.</returns>
  public static DateTime? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
  {
    if (OpenXmlLeafElement == null) return null;

    var sourceType = OpenXmlLeafElement.GetType();
    var valProp = OpenXmlLeafElement.GetType().GetProperty("Val");
    if (valProp == null)
    {
      var allProps = sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        throw new InvalidOperationException($"OpenXmlLeafElement of type {sourceType} does not have a string Val property");
    }
    var value = valProp.GetValue(OpenXmlLeafElement);
    var convertedValue = ConvertFrom(value);
    return (DateTime)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an DateTime value.
  /// </summary>
  /// <param name="value">The DateTime value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(DateTime? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProp = element.GetType().GetProperty("Val");
    if (valProp == null)
    {
      var allProps = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        throw new InvalidOperationException($"OpenXmlLeafElement of type {element.GetType()} does not have a string Val property");
    }
    var convertedValue = ConvertTo(value, valProp.PropertyType);
    valProp.SetValue(element, convertedValue);
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
  public static object? ConvertTo(DateTime? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts an Open XML value to a nullable DateTime, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an DateTime integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include DateTimeValue, DateTimeValue, DateTimeValue, UDateTimeValue, DateTimeValue,
  /// UDateTimeValue, UDateTimeValue, and StringValue. May be null.</param>
  /// <returns>An DateTime representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static DateTime? ConvertFrom(object? value)
  {
    return (DateTime?)ConverterBase.ConvertFrom(value, typeof(DateTime), ConversionFromMap);
  }

  #endregion
}