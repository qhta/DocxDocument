
namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for HexChar values in Open XML.
/// </summary>
public static class HexCharConverter
{
  /// <summary>
  /// Retrieves a HexChar value from a HexBinaryValue element.
  /// </summary>
  /// <param name="element">The HexBinaryValue element to convert.</param>
  /// <returns>A HexChar value, or null if the element or value is null.</returns>
  public static HexChar? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  /// <summary>
  /// Retrieves a HexChar value from a LongHexNumberType element.
  /// </summary>
  /// <param name="element">The LongHexNumberType element to convert.</param>
  /// <returns>A HexChar value, or null if element or inner value is null.</returns>
  public static HexChar? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

  /// <summary>
  /// Retrieves a HexChar value from an OpenXmlLeafElement having a "Value" property of type HexBinaryValue or string.
  /// </summary>
  /// <param name="openXmlElement">The element to retrieve the value from.</param>
  /// <returns>A HexChar value, or null if the input element is null or property mismatch.</returns>
  public static HexChar? GetValue(DX.OpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = valProperty.GetValue(openXmlElement);
      if (value is string valStr)
        return valStr;
      if (value is DX.HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return hexBinaryValue.Value;
    }
    return null;
  }

  /// <summary>
  /// Creates a HexBinaryValue containing the specified HexChar value.
  /// </summary>
  /// <param name="value">The HexChar value.</param>
  /// <returns>A new HexBinaryValue, or null if the input value is null.</returns>
  public static DX.HexBinaryValue? CreateHexBinaryValue(HexChar? value)
  {
    if (value is not null) return new DX.HexBinaryValue(value);
    return null;
  }

  /// <summary>
  /// Creates a specific LongHexNumberType element from a HexChar value.
  /// </summary>
  /// <typeparam name="HexBinaryType">The type of the element to create.</typeparam>
  /// <param name="value">The HexChar value.</param>
  /// <returns>A new instance of the element type with its Val property set, or null if value is null.</returns>
  public static HexBinaryType? CreateValue<HexBinaryType>(HexChar? value)
    where HexBinaryType : DXW.LongHexNumberType, new()
  {
    if (value is not null)
    {
      var element = new HexBinaryType();
      element.Val = new DX.HexBinaryValue(value);
      return element;
    }
    return null;
  }

  /// <summary>
  /// Creates a generic OpenXml element and sets its "Value" property to a new HexBinaryValue derived from the input.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <param name="value">The HexChar value.</param>
  /// <returns>A new OpenXml element instance with value set.</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexChar? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value);
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
}