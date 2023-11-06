namespace DocumentModel.Utils;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class OpenXmlLeafTextElementUtils
{
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

  public static float? AsFloat(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (float.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  public static double? AsDouble(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (double.TryParse(str, out var val))
        return val;
    }
    return null;
  }

  public static decimal? AsDecimal(this DX.OpenXmlLeafTextElement? element)
  {
    var str = element?.InnerText;
    if (str != null)
    {
      if (decimal.TryParse(str, out var val))
        return val;
    }
    return null;
  }

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

  #region EnumType get/set methods
  public static EnumType? GetEnumVal<EnumType, ElementType>(this DX.OpenXmlLeafElement _element) where EnumType : struct
  where ElementType : DX.OpenXmlLeafElement
  {
    var valProperty = typeof(ElementType).GetProperty("Val");
    Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
    var val = valProperty.GetValue(_element);
    if (val != null)
    {
      var valType = val.GetType();
      Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      var value = valueProperty.GetValue(val);
      if (value != null)
      {
        var valueType = value.GetType();
        if (valueType != typeof(EnumType))
        {
          var n = (int)Convert.ChangeType(value, typeof(int));
          value = Enum.ToObject(typeof(EnumType), n);
        }
        return (EnumType)value;
      }
    }
    return null;
  }

  #endregion

}
