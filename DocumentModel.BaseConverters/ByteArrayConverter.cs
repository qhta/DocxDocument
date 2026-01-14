namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for byte arrays to and from Open XML binary value types.
/// </summary>
public static class ByteArrayConverter
{
  /// <summary>
  /// Retrieves a byte array from an OpenXmlLeafElement (expecting HexBinaryValue or Base64BinaryValue).
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A byte array representing the value, or null if the element is null or the type is incorrect.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the element's Value property type is neither HexBinaryValue nor Base64BinaryValue.</exception>
  public static byte[]? GetValue(DX.OpenXmlLeafElement? element)
  {
    var valProperty = element?.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
      {
        if (valProperty.PropertyType == typeof(DX.HexBinaryValue))
          return Convert.FromHexString(value);
        if (valProperty.PropertyType == typeof(DX.Base64BinaryValue))
          return Convert.FromBase64String(value);
        throw new InvalidOperationException($"ByteArrayConverter can get value only from DX.HexBinaryValue or DX.Base64BinaryValue but \"{valProperty.PropertyType}\" type occured");
      }
    }
    return null;
  }

  /// <summary>
  /// Converts a hexadecimal string to a byte array.
  /// </summary>
  /// <param name="value">The hexadecimal string to convert.</param>
  /// <returns>A byte array representing the hexadecimal string, or null if the input is null.</returns>
  public static byte[]? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  /// <summary>
  /// Creates a specific OpenXmlElement type and sets its Value property from a byte array (converts to hex or base64 string based on property type).
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement to create.</typeparam>
  /// <param name="value">The byte array to convert.</param>
  /// <returns>A new instance of the specified OpenXmlElement type with the value set, or null if the input byte array is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the element's Value property type is neither HexBinaryValue nor Base64BinaryValue.</exception>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[]? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valProperty != null)
      {
        if (valProperty.PropertyType == typeof(DX.HexBinaryValue))
          valProperty.SetValue(element, Convert.ToHexString(value));
        else if (valProperty.PropertyType == typeof(DX.Base64BinaryValue))
          valProperty.SetValue(element, Convert.ToBase64String(value));
        else
          throw new InvalidOperationException(
            $"ByteArrayConverter can set value only to DX.HexBinaryValue or DX.Base64BinaryValue but \"{valProperty.PropertyType}\" type occured");
      }
      return element;
    }
    return null;
  }
}