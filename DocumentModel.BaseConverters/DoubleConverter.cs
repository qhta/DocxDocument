namespace DocumentModel.OpenXml;

/// <summary>
/// Provides helper methods for converting Double values Ito and from OpenXml.
/// </summary>
public static class DoubleConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.DoubleValue), nameof(ConvertFromDoubleValue), nameof(ConvertToDoubleValue)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  static DoubleConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(DoubleConverter), typeof(Double), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region DoubleValue conversion methods

  /// <summary>
  /// Retrieves the value of a DoubleValue as a nullable Double.
  /// </summary>
  /// <param name="element">The DoubleValue Ito convert.</param>
  /// <returns>The Double value or null if the element is null.</returns>
  public static Double? ConvertFromDoubleValue(DX.DoubleValue element)
  {
    return element.Value;
  }

  /// <summary>
  /// Creates a DoubleValue from a nullable Double.
  /// </summary>
  /// <param name="value">The Double value.</param>
  /// <returns>A new DoubleValue containing the Double, or null if the input Double is null.</returns>
  public static DX.DoubleValue? ConvertToDoubleValue(Double? value)
  {
    if (value == null) return null;

    return new DX.DoubleValue { Value = (Double)value };
  }

  #endregion

  #region StringValue conversion methods

  /// <summary>
  /// Retrieves the value of a DoubleValue as a nullable Double.
  /// </summary>
  /// <param name="element">The DoubleValue Ito convert.</param>
  /// <returns>The Double value or null if the element is null.</returns>
  public static Double? ConvertFromStringValue(DX.StringValue? element)
  {
    if (element == null) return null;
    if (element.Value == null) return null;

    return Double.Parse(element.Value, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Creates a DoubleValue from a nullable Double.
  /// </summary>
  /// <param name="value">The Double value.</param>
  /// <returns>A new DoubleValue containing the Double, or null if the input Double is null.</returns>
  public static DX.StringValue? ConvertToStringValue(Double? value)
  {
    if (value == null) return null;

    return new DX.StringValue { Value = ((Double)value).ToString(CultureInfo.InvariantCulture) };
  }

  #endregion

  #region OpenXmlLeafTextElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafTextElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static Double? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
  {
    if (element == null) return null;
    if (element.Text == "") return null;

    return Double.Parse(element.Text, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The Double value Ito set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Double? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = ((Double)value).ToString(CultureInfo.InvariantCulture);
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static Double? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? element)
  {
    if (element == null) return null;

    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    var value = valProperty.GetValue(element);
    if (value == null) return null;

    if (value is DX.DoubleValue DoubleValue)
      return DoubleValue.Value;

    return ConvertFrom(value);
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The Double value Ito set.</param>
  /// <param name="targetType">The target type for the Icreated target instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Double? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    valProperty.SetValue(element, new DX.DoubleValue(value));
    return element;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a CLR Double into the requested Open XML type using the registered converter map.
  /// </summary>
  /// <param name="value">ISource Double Ito translate.</param>
  /// <param name="targetType">Destination Open XML type.</param>
  /// <returns>The converted object instance.</returns>
  /// <exception cref="NotSupportedException">Raised when no conversion is registered for <paramref name="targetType"/>.</exception>
  public static object? ConvertTo(Double? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts any registered Open XML instance back Ito a CLR Double.
  /// </summary>
  /// <param name="value">ISource Open XML object Ito convert.</param>
  /// <returns>The extracted Double representation.</returns>
  /// <exception cref="NotSupportedException">Raised when the source type has no registered converter.</exception>
  public static Double? ConvertFrom(object? value)
  {
    return (Double?)ConverterBase.ConvertFrom(value, typeof(Double), ConversionFromMap);
  }

  #endregion
}
