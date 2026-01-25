namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for HexBinary values in Open XML.
/// </summary>
public static class HexBinaryConverter
{
  /// <summary>
  /// Retrieves a HexBinary array from an OpenXmlLeafElement having a "Value" property of type HexBinaryValue.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlLeafElement to retrieve the value from.</param>
  /// <returns>A HexBinary array, or null if retrieval fails.</returns>
  public static HexBinary? GetValue(DX.OpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperties()
      .FirstOrDefault(item=>item.PropertyType==typeof(DX.HexBinaryValue));
    if (valProperty != null)
    {
      var valPropertyValue = valProperty.GetValue(openXmlElement);
      if (valPropertyValue is string valStr)
        return Convert.FromHexString(valStr);
      if (valPropertyValue is DX.HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return Convert.FromHexString(hexBinaryValue.Value);
    }
    return null;
  }

  /// <summary>
  /// Converts a hexadecimal string to a HexBinary array.
  /// </summary>
  /// <param name="value">The hexadecimal string to convert.</param>
  /// <returns>A HexBinary array representing the string, or null if the input is null.</returns>
  public static HexBinary? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  /// <summary>
  /// Creates a specific HexBinaryValue type from a HexBinary array.
  /// </summary>
  /// <typeparam name="HexBinaryType">The type of HexBinaryValue to create.</typeparam>
  /// <param name="value">The HexBinary array to convert.</param>
  /// <returns>A new instance of HexBinaryType, or null if the input value is null.</returns>
  public static HexBinaryType? CreateValue<HexBinaryType>(HexBinary? value)
    where HexBinaryType : DX.HexBinaryValue, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Value = Convert.ToHexString(value);
      return element;
    }
    return null;
  }

  /// <summary>
  /// Creates a generic OpenXml element and sets its HexBinaryValue property from a HexBinary array.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <param name="value">The HexBinary array to set.</param>
  /// <returns>A new instance of the element type with the value set, or null if the input value is null.</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexBinary? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value == null)
      return null;
    var element = new OpenXmlElementType();
    if (value.Length > 0)
    {
      var openXmlType = typeof(OpenXmlElementType);
      var valProperty = openXmlType.GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(DX.HexBinaryValue));
      if (valProperty != null)
        valProperty.SetValue(element, CreateValue<DX.HexBinaryValue>(value));
      else
        throw new InvalidOperationException($"The specified {openXmlType.Name} type does not have a HexBinaryValue property.");
    }
    return element;
  }

  /// <summary>
  /// Creates a new Open XML element of the specified type and assigns the provided hex binary value, if present.
  /// </summary>
  /// <remarks>The created element will have its first property of type HexBinaryValue set to the provided
  /// value, if such a property exists. If the value is empty, the property is not set.</remarks>
  /// <param name="value">The hex binary value to assign to the Open XML element. If null, the method returns null.</param>
  /// <param name="openXmlType">The type of the Open XML element to create. Must be a type that has a property of type HexBinaryValue.</param>
  /// <returns>An instance of the specified Open XML element type with the value assigned, or null if the input value is null.</returns>
  public static object? CreateOpenXmlElement(HexBinary? value, Type openXmlType)
  {
    if (value == null)
      return null;
    var element = Activator.CreateInstance(openXmlType);
    var valProperty = openXmlType.GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(DX.HexBinaryValue));
    if (valProperty != null)
      valProperty.SetValue(element, HexBinaryConverter.CreateValue<DX.HexBinaryValue>(value));
    else
      throw new InvalidOperationException($"The specified {openXmlType.Name} type does not have a HexBinaryValue property.");
    return element;
  }
}