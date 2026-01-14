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
    var valProperty = openXmlElement?.GetType().GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
    if (valProperty != null)
    {
      var valPropertyValue = valProperty.GetValue(openXmlElement);
      if (valPropertyValue is string valStr)
        return Convert.FromHexString(valStr);
      if (valPropertyValue is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
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
    if (value != null)
    {
      var element = new OpenXmlElementType();
      if (value.Length > 0)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
        if (valProperty != null)
          valProperty.SetValue(element, CreateValue<DX.HexBinaryValue>(value));
      }
      return element;
    }
    return null;
  }
}