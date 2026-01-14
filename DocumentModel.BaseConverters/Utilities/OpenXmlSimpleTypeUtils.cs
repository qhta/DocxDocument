
namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlSimpleType object.
/// </summary>
public static class OpenXmlSimpleTypeUtils
{
  #region Universal OpenXmlSimpleType conversion methods
  /// <summary>
  /// Retrieves a boolean value from the specified OpenXml SimpleType parameter
  /// having "True/False" inner text.
  /// </summary>
  /// <param name="element">The OpenXmlSimpleType element to convert.</param>
  /// <returns>The boolean value, or null if conversion fails.</returns>
  public static bool? AsBoolean(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (Boolean.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Retrieves an int value from the specified OpenXml SimpleType parameter
  /// having integer-formatted inner text.
  /// </summary>
  /// <param name="element">The OpenXmlSimpleType element to convert.</param>
  /// <returns>The int value, or null if conversion fails.</returns>
  public static int? AsInt(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (int.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Retrieves a uint value from the specified OpenXml SimpleType parameter
  /// having hex-formatted inner text.
  /// </summary>
  /// <param name="element">The OpenXmlSimpleType element to convert.</param>
  /// <returns>The uint value, or null if conversion fails.</returns>
  public static uint? AsUInt(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (uint.TryParse(str, NumberStyles.HexNumber, null, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Retrieves a Guid value from the specified OpenXml SimpleType parameter
  /// having Guid-formatted inner text.
  /// </summary>
  /// <param name="element">The OpenXmlSimpleType element to convert.</param>
  /// <returns>The Guid value, or null if conversion fails.</returns>
  public static Guid? AsGuid(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (Guid.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  #endregion

  #region specialized OpenXmlSimpleType conversion methods

  /// <summary>
  /// Retrieves the inner text string from a StringValue element.
  /// </summary>
  /// <param name="element">The StringValue element.</param>
  /// <returns>The string content, or null if simple type is null.</returns>
  public static string? GetString(this DX.StringValue? element) 
  {
    var str = element?.InnerText;
    return str;
  }

  /// <summary>
  /// Creates a StringValue element from a string.
  /// </summary>
  /// <param name="value">The string value.</param>
  /// <returns>A new StringValue element, or null if input is null.</returns>
  public static DX.StringValue? GetStringValue(this string? value) 
  {
    return (value!=null) ? new DX.StringValue(value) : null;
  }

//DocumentFormat.OpenXml.Base64BinaryValue
//DocumentFormat.OpenXml.EnumValue<T>
//DocumentFormat.OpenXml.HexBinaryValue
//DocumentFormat.OpenXml.ListValue<T>
//DocumentFormat.OpenXml.OnOffValue
//DocumentFormat.OpenXml.OpenXmlSimpleValue<T>
//DocumentFormat.OpenXml.StringValue
//DocumentFormat.OpenXml.TrueFalseBlankValue
//DocumentFormat.OpenXml.TrueFalseValue 
  #endregion
}
