namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for BytePercent values to/from Open XML.
/// </summary>
public static class BytePercentValueConverter
{

  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.StringValue),
    typeof(DX.OpenXmlLeafElement)
  ];

  #region BytePercent conversion.

  /// <summary>
  /// Retrieves a BytePercent from a StringValue.
  /// </summary>
  /// <param name="val">The StringValue to convert.</param>
  /// <returns>A BytePercent representing the value, or null if the input is null.</returns>
  public static BytePercent? ConvertStringValueToBytePercent(DX.StringValue? val)
  {
    if (val == null)
      return null;

    var value = val.Value;
    if (value != null)
      return new BytePercent(value);

    return null;
  }

  /// <summary>
  /// Creates a StringValue from a BytePercent.
  /// </summary>
  /// <param name="value">The BytePercent to convert.</param>
  /// <returns>A StringValue element, or null if the input value is null.</returns>
  public static DX.StringValue? ConvertBytePercentToStringValue(BytePercent? value)
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
  /// Retrieves a BytePercent from an OpenXmlLeafElement having a "Value" property containing a base64 string.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A BytePercent representing the value, or null if the element is null.</returns>
  public static BytePercent? GetBytePercentFromOpenXml(DX.OpenXmlLeafElement? element)
  {
    if (element == null)
      return null;

    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return new BytePercent(value);
    }
    throw new InvalidOperationException($"The OpenXml element of type {element.GetType()} does not have a valid 'Value' property.");
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement element containing a base64 string "Value" property from a BytePercent.
  /// </summary>
  /// <param name="value">The BytePercent to convert.</param>
  /// <param name="targetType">The type of OpenXml element to create.</param>
  /// <returns>An instance of the element type, or null if the input value is null.</returns>
  public static DX.OpenXmlLeafElement? CreateOpenOpenXmlLeafElement(BytePercent? value, Type targetType)
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
  /// Converts a BytePercent to an OpenXml-compatible object of the specified target type.
  /// </summary>
  /// <param name="value">The BytePercent to convert. Can be null.</param>
  /// <param name="targetType">The target OpenXml type to convert the BytePercent to. Must be a subclass of BytePercent or OpenXmlLeafElement.</param>
  /// <returns>An object representing the converted value in the specified OpenXml type, or null if the input value is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if the specified target type is not supported for conversion.</exception>
  public static object? ConvertToOpenXml(BytePercent? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.IsEqualOrSubclassOf(typeof(BytePercent)))
      return ConvertBytePercentToStringValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return CreateOpenOpenXmlLeafElement(value, targetType);

    throw new NotSupportedException($"Conversion to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an Open XML value to its BytePercent representation, if supported.
  /// </summary>
  /// <param name="value">The Open XML value to convert. This can be an instance of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, or OpenXmlLeafElement. May be null.</param>
  /// <returns>A BytePercent representation of the specified Open XML value, or null if <paramref name="value"/> is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if <paramref name="value"/> is not a supported Open XML type.</exception>
  public static BytePercent? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (value is DX.StringValue BytePercent)
      return ConvertStringValueToBytePercent(BytePercent);
    if (value is DX.OpenXmlLeafElement openXmlLeafElement)
      return GetBytePercentFromOpenXml(openXmlLeafElement);

    throw new NotSupportedException($"Conversion from type {sourceType} is not supported.");
  }

  #endregion

}