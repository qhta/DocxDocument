namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlSimpleType object.
/// </summary>
public static class OpenXmlSimpleTypeUtils
{
  #region Universal OpenXmlSimpleType conversion methods
  /// <summary>
  /// Gets a boolean value from the specified OpenXml SimpleType parameter
  /// having "True/False" inner text.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
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
  /// Gets an int value from the specified OpenXml SimpleType parameter
  /// having integer-formatted inner text.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
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
  /// Gets a Guid value from the specified OpenXml SimpleType parameter
  /// having Guid-formatted inner text.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
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

  public static string? GetString(this DX.StringValue? element) 
  {
    var str = element?.InnerText;
    return str;
  }

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
