
namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations Ito be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class OpenXmlLeafTextElementUtils
{
  /// <summary>
  /// Retrieves a boolean value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The boolean value, or null if conversion fails.</returns>
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
  /// Retrieves an int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The int value, or null if conversion fails.</returns>
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
  /// Retrieves a short int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The short value, or null if conversion fails.</returns>
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
  /// Retrieves a long int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The long value, or null if conversion fails.</returns>
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
  /// Retrieves a signed byte value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The signed byte value, or null if conversion fails.</returns>
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
  /// Retrieves an unsigned byte value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The byte value, or null if conversion fails.</returns>
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
  /// Retrieves an unsigned int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The uint value, or null if conversion fails.</returns>
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
  /// Retrieves an unsigned short int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The ushort value, or null if conversion fails.</returns>
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
  /// Retrieves an unsigned long int value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The ulong value, or null if conversion fails.</returns>
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
  /// Retrieves a single-precision real value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The float value, or null if conversion fails.</returns>
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
  /// Retrieves a double-precision real value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The double value, or null if conversion fails.</returns>
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
  /// Retrieves a decimal-precision real value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The decimal value, or null if conversion fails.</returns>
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
  /// Retrieves a date time value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The DateTime value, or null if conversion fails.</returns>
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
  /// Retrieves a Guid value from the specified OpenXml OpenXmlLeafTextElement parameter.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The Guid value, or null if conversion fails.</returns>
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
  /// Retrieves an int value from the specified OpenXml OpenXmlLeafTextElement parameter
  /// having hexadecimal inner text.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The int value parsed from hex, or null if conversion fails.</returns>
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
  /// Retrieves a byte[] array value from the specified OpenXml OpenXmlLeafTextElement parameter
  /// having Base64Binary inner text.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The byte array, or null if conversion fails.</returns>
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
  /// Retrieves a byte[] array value from the specified OpenXml OpenXmlLeafTextElement parameter
  /// having Base64Binary inner text where the first four bytes specify length of the result.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The byte array with length prefix handled, or null if conversion fails.</returns>
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

