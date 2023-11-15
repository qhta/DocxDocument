namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlSimpleType object.
/// </summary>
public static class OpenXmlSimpleTypeUtils
{
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
}
