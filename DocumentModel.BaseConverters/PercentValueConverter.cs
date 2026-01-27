namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Percent values to/from Open XML.
/// </summary>
public static class PercentValueConverter
{

  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.StringValue),
    typeof(DX.OpenXmlLeafElement)
  ];

  #region Percent conversion.

  /// <summary>
  /// Retrieves a Percent from a StringValue.
  /// </summary>
  /// <param name="val">The StringValue to convert.</param>
  /// <returns>A Percent representing the value, or null if the input is null.</returns>
  public static Percent? ConvertStringValueToPercent(DX.StringValue? val)
  {
    if (val == null)
      return null;

    var value = val.Value;
    if (value != null)
      return new Percent(value);

    return null;
  }

  /// <summary>
  /// Creates a StringValue from a Percent.
  /// </summary>
  /// <param name="value">The Percent to convert.</param>
  /// <returns>A StringValue element, or null if the input value is null.</returns>
  public static DX.StringValue? ConvertPercentToStringValue(Percent? value)
  {
    if (value == null)
      return null;

    var element = new DX.StringValue
    {
      InnerText = value.ToString()
    };
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a Percent from an OpenXmlLeafElement having a "Value" property containing a base64 string.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A Percent representing the value, or null if the element is null.</returns>
  public static Percent? GetPercentFromOpenXml(DX.OpenXmlLeafElement? element)
  {
    if (element == null)
      return null;

    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return new Percent(value);
    }
    throw new InvalidOperationException($"The OpenXml element of type {element.GetType()} does not have a valid 'Value' property.");
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement element containing a base64 string "Value" property from a Percent.
  /// </summary>
  /// <param name="value">The Percent to convert.</param>
  /// <param name="targetType">The type of OpenXml element to create.</param>
  /// <returns>An instance of the element type, or null if the input value is null.</returns>
  public static DX.OpenXmlLeafElement? CreateOpenOpenXmlLeafElement(Percent? value, Type targetType)
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
  /// Converts a Percent to an OpenXml-compatible object of the specified target type.
  /// </summary>
  /// <param name="value">The Percent to convert. Can be null.</param>
  /// <param name="targetType">The target OpenXml type to convert the Percent to. Must be a subclass of Percent or OpenXmlLeafElement.</param>
  /// <returns>An object representing the converted value in the specified OpenXml type, or null if the input value is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if the specified target type is not supported for conversion.</exception>
  public static object? ConvertToOpenXml(Percent? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.IsEqualOrSubclassOf(typeof(Percent)))
      return ConvertPercentToStringValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return CreateOpenOpenXmlLeafElement(value, targetType);

    throw new NotSupportedException($"Conversion to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an Open XML value to its Percent representation, if supported.
  /// </summary>
  /// <param name="value">The Open XML value to convert. This can be an instance of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, or OpenXmlLeafElement. May be null.</param>
  /// <returns>A Percent representation of the specified Open XML value, or null if <paramref name="value"/> is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if <paramref name="value"/> is not a supported Open XML type.</exception>
  public static Percent? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (value is DX.StringValue Percent)
      return ConvertStringValueToPercent(Percent);
    if (value is DX.OpenXmlLeafElement openXmlLeafElement)
      return GetPercentFromOpenXml(openXmlLeafElement);

    throw new NotSupportedException($"Conversion from type {sourceType} is not supported.");
  }

  #endregion

}