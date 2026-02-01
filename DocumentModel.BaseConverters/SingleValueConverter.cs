namespace DocumentModel.OpenXml;

/// <summary>
/// Provides helper methods for converting Single values to and from OpenXml.
/// </summary>
public static class SingleConverter
{
  private static readonly ConversionMethodInfo[] supportedTypes =
  [
    new(typeof(DX.SingleValue), nameof(ConvertFromSingleValue), nameof(ConvertToSingleValue)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  static SingleConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(SingleConverter), typeof(Single), supportedTypes, ConversionToMap, ConversionFromMap);
  }

  #region SingleValue conversion methods

  /// <summary>
  /// Retrieves the value of a SingleValue as a nullable Single.
  /// </summary>
  /// <param name="element">The SingleValue to convert.</param>
  /// <returns>The Single value or null if the element is null.</returns>
  public static Single? ConvertFromSingleValue(DX.SingleValue element)
  {
    return element.Value;
  }

  /// <summary>
  /// Creates a SingleValue from a nullable Single.
  /// </summary>
  /// <param name="value">The Single value.</param>
  /// <returns>A new SingleValue containing the Single, or null if the input Single is null.</returns>
  public static DX.SingleValue? ConvertToSingleValue(Single? value)
  {
    if (value == null) return null;

    return new DX.SingleValue { Value = (Single)value };
  }

  #endregion

  #region StringValue conversion methods

  /// <summary>
  /// Retrieves the value of a SingleValue as a nullable Single.
  /// </summary>
  /// <param name="element">The SingleValue to convert.</param>
  /// <returns>The Single value or null if the element is null.</returns>
  public static Single? ConvertFromStringValue(DX.StringValue? element)
  {
    if (element == null) return null;
    if (element.Value == null) return null;

    return Single.Parse(element.Value, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Creates a SingleValue from a nullable Single.
  /// </summary>
  /// <param name="value">The Single value.</param>
  /// <returns>A new SingleValue containing the Single, or null if the input Single is null.</returns>
  public static DX.StringValue? ConvertToStringValue(Single? value)
  {
    if (value == null) return null;

    return new DX.StringValue { Value = ((Single)value).ToString(CultureInfo.InvariantCulture) };
  }

  #endregion

  #region OpenXmlLeafTextElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafTextElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static Single? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
  {
    if (element == null) return null;
    if (element.Text == "") return null;

    return Single.Parse(element.Text, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The Single value to set.</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Single? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = ((Single)value).ToString(CultureInfo.InvariantCulture);
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static Single? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? element)
  {
    if (element == null) return null;

    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    var value = valProperty.GetValue(element);
    if (value == null) return null;

    if (value is DX.SingleValue singleValue)
      return singleValue.Value;

    return ConvertFrom(value);
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The Single value to set.</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Single? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    valProperty.SetValue(element, new DX.SingleValue(value));
    return element;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a CLR Single into the requested Open XML type using the registered converter map.
  /// </summary>
  /// <param name="value">Source Single to translate.</param>
  /// <param name="targetType">Destination Open XML type.</param>
  /// <returns>The converted object instance.</returns>
  /// <exception cref="NotSupportedException">Raised when no conversion is registered for <paramref name="targetType"/>.</exception>
  public static object? ConvertTo(Single? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts any registered Open XML instance back to a CLR Single.
  /// </summary>
  /// <param name="value">Source Open XML object to convert.</param>
  /// <returns>The extracted Single representation.</returns>
  /// <exception cref="NotSupportedException">Raised when the source type has no registered converter.</exception>
  public static Single? ConvertFrom(object? value)
  {
    return (Single?)ConverterBase.ConvertFrom(value, typeof(Single), ConversionFromMap);
  }

  #endregion
}