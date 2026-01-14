
namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Base64Binary values in Open XML.
/// </summary>
public static class Base64BinaryConverter
{
  /// <summary>
  /// Retrieves a byte array from a boolean Base64BinaryValue.
  /// </summary>
  /// <param name="val">The Base64BinaryValue to convert.</param>
  /// <returns>A byte array representing the value, or null if the input is null.</returns>
  public static byte[]? GetValue(DX.Base64BinaryValue? val)
  {
    if (val == null)
      return null;
    var value = val.Value;
    if (value != null)
      return Convert.FromBase64String(value);
    return Array.Empty<byte>();
  }

  /// <summary>
  /// Retrieves a byte array from an OpenXmlLeafElement having a "Value" property containing a base64 string.
  /// </summary>
  /// <param name="element">The element to retrieve the value from.</param>
  /// <returns>A byte array representing the value, or null if the element is null.</returns>
  public static byte[]? GetValue(DX.OpenXmlLeafElement? element)
  {
    if (element == null)
      return null;
    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return Convert.FromBase64String(value);
    }
    return Array.Empty<byte>();
  }

  /// <summary>
  /// Creates a Base64BinaryValue from a byte array.
  /// </summary>
  /// <param name="value">The byte array to convert.</param>
  /// <returns>A Base64BinaryValue element, or null if the input value is null.</returns>
  public static DX.Base64BinaryValue? CreateBase64BinaryValue(byte[]? value)
  {
    if (value == null)
      return null;
    var element = new DX.Base64BinaryValue
    {
      InnerText = Convert.ToBase64String(value)
    };
    return element;
  }

  /// <summary>
  /// Creates a generic OpenXml element containing a base64 string "Value" property from a byte array.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of OpenXml element to create.</typeparam>
  /// <param name="value">The byte array to convert.</param>
  /// <returns>An instance of the element type, or null if the input value is null.</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[]? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value == null)
      return null;
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, Convert.ToBase64String(value));
    return element;
  }
}