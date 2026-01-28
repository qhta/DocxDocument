namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Base64Binary values to/from Open XML.
/// </summary>
public static class Base64BinaryOpenXmlConverter
{

  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.Base64BinaryValue),
    typeof(DX.OpenXmlLeafElement)
  ];

  #region Base64BinaryValueconversion.

  /// <summary>
  /// Retrieves a Base64Binary from a Base64BinaryValue.
  /// </summary>
  /// <param name="val">The Base64BinaryValue to convert.</param>
  /// <returns>A Base64Binary representing the value, or null if the input is null.</returns>
  public static Base64Binary? ConvertBase64BinaryValueToBase64Binary(DX.Base64BinaryValue? val)
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
  public static DX.Base64BinaryValue? ConvertBase64BinaryToBase64BinaryValue(Base64Binary? value)
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

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a Base64Binary from an OpenXmlLeafElement having a "Value" property containing a base64 string.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A Base64Binary representing the value, or null if the element is null.</returns>
  public static Base64Binary? GetBase64BinaryFromOpenXml(DX.OpenXmlLeafElement? element)
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
  public static DX.OpenXmlLeafElement? CreateOpenOpenXmlLeafElement(Base64Binary? value, Type targetType)
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
  /// Converts a Base64Binary to an OpenXml-compatible object of the specified target type.
  /// </summary>
  /// <param name="value">The Base64Binary to convert. Can be null.</param>
  /// <param name="targetType">The target OpenXml type to convert the Base64Binary to. Must be a subclass of Base64Binary or OpenXmlLeafElement.</param>
  /// <returns>An object representing the converted value in the specified OpenXml type, or null if the input value is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if the specified target type is not supported for conversion.</exception>
  public static object? ConvertToOpenXml(Base64Binary? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.IsEqualOrSubclassOf(typeof(DX.Base64BinaryValue)))
      return ConvertBase64BinaryToBase64BinaryValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return CreateOpenOpenXmlLeafElement(value, targetType);

    throw new NotSupportedException($"Conversion to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an Open XML value to its Base64Binary representation, if supported.
  /// </summary>
  /// <param name="value">The Open XML value to convert. This can be an instance of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, or OpenXmlLeafElement. May be null.</param>
  /// <returns>A Base64Binary representation of the specified Open XML value, or null if <paramref name="value"/> is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if <paramref name="value"/> is not a supported Open XML type.</exception>
  public static Base64Binary? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (value is DX.Base64BinaryValue base64Binary)
      return ConvertBase64BinaryValueToBase64Binary(base64Binary);
    if (value is DX.OpenXmlLeafElement openXmlLeafElement)
      return GetBase64BinaryFromOpenXml(openXmlLeafElement);

    throw new NotSupportedException($"Conversion from type {sourceType} is not supported.");
  }

  #endregion

}