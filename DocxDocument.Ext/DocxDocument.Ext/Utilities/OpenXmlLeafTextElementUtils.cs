namespace DocumentModel.Utils;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class OpenXmlLeafTextElementUtils
{
  /// <summary>
  /// Gets a boolean value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static bool? AsBoolean(this DX.OpenXmlLeafTextElement? element)
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
  /// Gets an int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static int? AsInt(this DX.OpenXmlLeafTextElement? element)
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
  /// Gets a short int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static short? AsShort(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (short.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a long int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static long? AsLong(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (long.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a signed byte value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static sbyte? AsSByte(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (sbyte.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets an unsigned byte value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static byte? AsByte(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (byte.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets an unsigned int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static uint? AsUInt(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (uint.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets an unsigned short int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static ushort? AsUShort(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (ushort.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets an unsigned long int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static ulong? AsULong(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (ulong.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a single-precision real value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static float? AsFloat(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (float.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a double-precision real value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static double? AsDouble(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (double.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a decimal-precision real value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static decimal? AsDecimal(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a date time value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static DateTime? AsDateTime(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (DateTime.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a Guid value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static Guid? AsGuid(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (Guid.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets an int value from the specified OpenXml OpenXmlLeafTextElement parameter
  /// having hexadecimal inner text.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static int? AsHexInt(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (int.TryParse(str, NumberStyles.HexNumber, null, out var val))
        return val;
    }
    return null;
  }

  /// <summary>
  /// Gets a byte[] array value from the specified OpenXml OpenXmlLeafTextElement parameter
  /// having Base64Binary inner text.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static byte[]? AsByteArray(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      var bytes = Convert.FromBase64String(str);
      return bytes;
    }
    return null;
  }

  /// <summary>
  /// Gets a byte[] array value from the specified OpenXml OpenXmlLeafTextElement parameter
  /// having Base64Binary inner text where the first four bytes specify length of the result.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static byte[]? AsLByteArray(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      var bytes = Convert.FromBase64String(str);
      var length = ((((bytes[3] * 256) + bytes[2]) * 256 + bytes[1]) * 256) + bytes[0];
      var result = new byte[length];
      for (int i = 0; i < length; i++)
        result[i] = bytes[i + 4];
      return result;
    }
    return null;
  }

}
