namespace DocumentModel.Utils;

/// <summary>
/// This static class contains extension operations to be performed on a DocumentFormat.OpenXml.VariantTypes objects.
/// </summary>
public static class VariantUtils
{
  private static Dictionary<DXVT.VectorBaseValues, Type> VectorBaseValueToType = new Dictionary<DXVT.VectorBaseValues, Type>()
  {
    { DXVT.VectorBaseValues.Variant, typeof(object) },
    { DXVT.VectorBaseValues.OneByteSignedInteger, typeof(sbyte) },
    { DXVT.VectorBaseValues.TwoBytesSignedInteger, typeof(Int16) },
    { DXVT.VectorBaseValues.FourBytesSignedInteger, typeof(Int32) },
    { DXVT.VectorBaseValues.EightBytesSignedInteger, typeof(Int64) },
    { DXVT.VectorBaseValues.OneByteUnsignedInteger, typeof(byte) },
    { DXVT.VectorBaseValues.TwoBytesUnsignedInteger, typeof(UInt16) },
    { DXVT.VectorBaseValues.FourBytesUnsignedInteger, typeof(UInt32) },
    { DXVT.VectorBaseValues.EightBytesUnsignedInteger, typeof(UInt64) },
    { DXVT.VectorBaseValues.FourBytesReal, typeof(Single) },
    { DXVT.VectorBaseValues.EightBytesReal, typeof(Double) },
    { DXVT.VectorBaseValues.Lpstr, typeof(String) },
    { DXVT.VectorBaseValues.Lpwstr, typeof(String) },
    { DXVT.VectorBaseValues.Bstr, typeof(String) },
    { DXVT.VectorBaseValues.Date, typeof(DateTime) },
    { DXVT.VectorBaseValues.Filetime, typeof(DateTime) },
    { DXVT.VectorBaseValues.Bool, typeof(bool) },
    { DXVT.VectorBaseValues.Currency, typeof(Decimal) },
    { DXVT.VectorBaseValues.Error, typeof(int) },
    { DXVT.VectorBaseValues.ClassId, typeof(Guid) },
  };

  public static Array? AsArray(this DXVT.VTVector? element) => AsArray(element, out _);

  public static Array? AsArray(this DXVT.VTVector? element, out DXVT.VectorBaseValues? baseType)
  {
    baseType = null;
    if (element == null)
      return null;
    baseType = element.BaseType?.Value;
    Type itemType = (baseType == null) ? typeof(object) : VectorBaseValueToType[(DXVT.VectorBaseValues)baseType];
    var size = /*(int?)element.Size?.Value ?? */element.Elements().Count();
    var array = Array.CreateInstance(itemType, size);
    var i = 0;
    foreach (var child in element.Elements())
    {
      var item = AsObject(child);
      array.SetValue(item, i++);
    }
    return array;
  }


  private static Dictionary<Type, DXVT.VectorBaseValues> TypeToVectorBase = new Dictionary<Type, DXVT.VectorBaseValues>
  {
    { typeof(object), DXVT.VectorBaseValues.Variant },
    { typeof(sbyte), DXVT.VectorBaseValues.OneByteSignedInteger },
    { typeof(Int16), DXVT.VectorBaseValues.TwoBytesSignedInteger },
    { typeof(Int32), DXVT.VectorBaseValues.FourBytesSignedInteger },
    { typeof(Int64), DXVT.VectorBaseValues.EightBytesSignedInteger },
    { typeof(byte), DXVT.VectorBaseValues.OneByteUnsignedInteger },
    { typeof(UInt16), DXVT.VectorBaseValues.TwoBytesUnsignedInteger },
    { typeof(UInt32), DXVT.VectorBaseValues.FourBytesUnsignedInteger },
    { typeof(UInt64), DXVT.VectorBaseValues.EightBytesUnsignedInteger },
    { typeof(Single), DXVT.VectorBaseValues.FourBytesReal },
    { typeof(Double), DXVT.VectorBaseValues.EightBytesReal },
    { typeof(string), DXVT.VectorBaseValues.Lpwstr },
    { typeof(DateTime), DXVT.VectorBaseValues.Filetime },
    { typeof(bool), DXVT.VectorBaseValues.Bool },
    { typeof(decimal), DXVT.VectorBaseValues.Currency },
    { typeof(Guid), DXVT.VectorBaseValues.ClassId },
  };

  internal static DX.OpenXmlElement[]? AsChildArray(this Array? array, DXVT.VectorBaseValues? baseType = null)
  {
    if (array == null)
      return null;
    var itemType = array.GetType().GetElementType();
    if (itemType == null)
      return null;
    if (baseType == null)
      baseType = TypeToVectorBase[itemType];
    var size = array.Length;
    var result = new DX.OpenXmlElement[size];
    for (var i = 0; i < size; i++)
    {
      var item = array.GetValue(i);
      var childElement = item.AsVTVariant(baseType);
      if (childElement == null)
        childElement = new DXVT.VTNull();
      result[i] = childElement;
    }
    return result;
  }
  public static DXVT.VTVector? AsVTVector(this Array? array, DXVT.VectorBaseValues? baseType = null)
  {
    if (array == null)
      return null;
    var itemType = array.GetType().GetElementType();
    if (itemType == null)
      return null;
    if (baseType == null)
      baseType = TypeToVectorBase[itemType];
    var size = array.Length;
    DXVT.VTVector vector = new DXVT.VTVector();
    for (var i = 0; i < size; i++)
    {
      var item = array.GetValue(i);
      var childElement = item.AsVTVariant(baseType);
      if (childElement != null)
        vector.AppendChild(childElement);
    }
    return vector;
  }

  internal static Dictionary<DXVT.ArrayBaseValues, Type> ArrayBaseValueToType = new Dictionary<DXVT.ArrayBaseValues, Type>()
  {
    {  DXVT.ArrayBaseValues.Variant, typeof(object) },
    {  DXVT.ArrayBaseValues.OneByteSignedInteger, typeof(sbyte) },
    {  DXVT.ArrayBaseValues.TwoBytesSignedInteger, typeof(Int16) },
    {  DXVT.ArrayBaseValues.FourBytesSignedInteger, typeof(Int32) },
    {  DXVT.ArrayBaseValues.Integer, typeof(Int64) },
    {  DXVT.ArrayBaseValues.OneByteUnsignedInteger, typeof(byte) },
    {  DXVT.ArrayBaseValues.TwoBytesUnsignedInteger, typeof(UInt16) },
    {  DXVT.ArrayBaseValues.FourBytesUnsignedInteger, typeof(UInt32) },
    {  DXVT.ArrayBaseValues.UnsignedInteger, typeof(UInt64) },
    {  DXVT.ArrayBaseValues.FourBytesReal, typeof(Single) },
    {  DXVT.ArrayBaseValues.EightBytesReal, typeof(Double) },
    {  DXVT.ArrayBaseValues.Bstr, typeof(String) },
    {  DXVT.ArrayBaseValues.Date, typeof(DateTime) },
    {  DXVT.ArrayBaseValues.Bool, typeof(bool) },
    {  DXVT.ArrayBaseValues.Currency, typeof(Decimal) },
    {  DXVT.ArrayBaseValues.Error, typeof(int) },
  };

  public static Array? AsArray(this DXVT.VTArray? element) => AsArray(element, out _);

  public static Array? AsArray(this DXVT.VTArray? element, out DXVT.ArrayBaseValues? baseType)
  {
    baseType = null;
    if (element == null)
      return null;
    baseType = element.BaseType?.Value;
    var itemType = (baseType == null) ? typeof(object) : ArrayBaseValueToType[(DXVT.ArrayBaseValues)baseType];
    var lowerBounds = element.LowerBounds?.Value ?? 0;
    var upperBounds = element.UpperBounds?.Value ?? 0;
    Array? array = Array.CreateInstance(itemType, lowerBounds, upperBounds);
    if (array != null)
    {
      var i = 0;
      foreach (var child in element.Elements())
      {
        var item = AsObject(child);
        array.SetValue(element, i++);
      }
    }
    return array;
  }

  public static object? AsObject(this DX.OpenXmlElement? element)
  {
    if (element is DXVT.VTInteger vtInt)
      return vtInt.AsLong();
    if (element is DXVT.VTUnsignedInteger vtUInt)
      return vtUInt.AsULong();
    if (element is DXVT.VTBool vtBool)
      return vtBool.AsBoolean();
    if (element is DXVT.Variant variant)
      return variant.Elements().FirstOrDefault()?.AsObject();
    if (element is DXVT.VTByte vtByte)
      return vtByte.AsSByte();
    if (element is DXVT.VTShort vtShort)
      return vtShort.AsShort();
    if (element is DXVT.VTInt32 vtInt32)
      return vtInt32.AsInt();
    if (element is DXVT.VTInt64 vtInt64)
      return vtInt64.AsLong();
    if (element is DXVT.VTUnsignedByte vtUByte)
      return vtUByte.AsByte();
    if (element is DXVT.VTUnsignedShort vtUShort)
      return vtUShort.AsUShort();
    if (element is DXVT.VTUnsignedInt32 vtUInt32)
      return vtUInt32.AsUInt();
    if (element is DXVT.VTUnsignedInt64 vtUInt64)
      return vtUInt64.AsULong();
    if (element is DXVT.VTFloat vtFloat)
      return vtFloat.AsFloat();
    if (element is DXVT.VTDouble vtDouble)
      return vtDouble.AsDouble();
    if (element is DXVT.VTDecimal vtDecimal)
      return vtDecimal.AsDecimal();
    if (element is DXVT.VTCurrency vtCurrency)
      return vtCurrency.AsDecimal();
    if (element is DXVT.VTLPSTR vtLpstr)
      return vtLpstr.InnerText;
    if (element is DXVT.VTLPWSTR vtLpwstr)
      return vtLpwstr.InnerText;
    if (element is DXVT.VTBString vtBstr)
      return vtBstr.InnerText;
    if (element is DXVT.VTDate vtDate)
      return vtDate.AsDateTime();
    if (element is DXVT.VTFileTime vtFileTime)
      return vtFileTime.AsDateTime();
    if (element is DXVT.VTClassId vtClassId)
      return vtClassId.AsGuid();
    if (element is DXVT.VTError vtError)
      return vtError.AsHexInt();
    if (element is DXVT.VTEmpty)
      return DBNull.Value;
    if (element is DXVT.VTNull)
      return null;
    if (element is DXVT.VTBlob vtBlob)
      return vtBlob.AsLByteArray();
    if (element is DXVT.VTOBlob vtOBlob)
      return vtOBlob.AsLByteArray();
    if (element is DXVT.VTStorage vtStorage)
      return vtStorage.AsByteArray();
    if (element is DXVT.VTOStorage vtOStorage)
      return vtOStorage.AsByteArray();
    if (element is DXVT.VTOStreamData vtOStream)
      return vtOStream.AsByteArray();
    if (element is DXVT.VTVStreamData vtVStream)
      return vtVStream.AsByteArray();
    return null;
  }

  internal static DX.OpenXmlElement? AsVTVariant(this object? value, DXVT.VectorBaseValues? baseType = null)
  {
    if (value == null)
      return new DXVT.VTNull();
    if (value == DBNull.Value)
      return new DXVT.VTEmpty();
    if (baseType == null)
      baseType = TypeToVectorBase[value.GetType()];
    switch (baseType)
    {
      case DXVT.VectorBaseValues.Variant:
        var result = new DXVT.Variant();
        var childElement = value.AsVTVariant();
        if (childElement != null)
          result.AppendChild(childElement);
        return result;
      case DXVT.VectorBaseValues.OneByteSignedInteger:
        return new DXVT.VTByte(value.ToString()!);
      case DXVT.VectorBaseValues.TwoBytesSignedInteger:
        return new DXVT.VTShort(value.ToString()!);
      case DXVT.VectorBaseValues.FourBytesSignedInteger:
        return new DXVT.VTInt32(value.ToString()!);
      case DXVT.VectorBaseValues.EightBytesSignedInteger:
        return new DXVT.VTInt64(value.ToString()!);
      case DXVT.VectorBaseValues.OneByteUnsignedInteger:
        return new DXVT.VTUnsignedByte(value.ToString()!);
      case DXVT.VectorBaseValues.TwoBytesUnsignedInteger:
        return new DXVT.VTUnsignedShort(value.ToString()!);
      case DXVT.VectorBaseValues.FourBytesUnsignedInteger:
        return new DXVT.VTUnsignedInt32(value.ToString()!);
      case DXVT.VectorBaseValues.EightBytesUnsignedInteger:
        return new DXVT.VTUnsignedInt64(value.ToString()!);
      case DXVT.VectorBaseValues.FourBytesReal:
        return new DXVT.VTFloat(((float)value).ToString(CultureInfo.InvariantCulture)!);
      case DXVT.VectorBaseValues.EightBytesReal:
        return new DXVT.VTDouble(((double)value).ToString(CultureInfo.InvariantCulture)!);
      case DXVT.VectorBaseValues.Lpstr:
        return new DXVT.VTLPSTR(((string)value));
      case DXVT.VectorBaseValues.Lpwstr:
        return new DXVT.VTLPWSTR(((string)value));
      case DXVT.VectorBaseValues.Bstr:
        return new DXVT.VTBString(((string)value));
      case DXVT.VectorBaseValues.Date:
        return new DXVT.VTDate(((DateTime)value).ToString());
      case DXVT.VectorBaseValues.Filetime:
        return new DXVT.VTFileTime(((DateTime)value).ToString());
      case DXVT.VectorBaseValues.Bool:
        return new DXVT.VTBool(((bool)value).ToString());
      case DXVT.VectorBaseValues.Currency:
        return new DXVT.VTCurrency(((decimal)value).ToString(CultureInfo.InvariantCulture)!);
      case DXVT.VectorBaseValues.Error:
        return new DXVT.VTError("0x" + ((int)value).ToString("X8"));
      case DXVT.VectorBaseValues.ClassId:
        return new DXVT.VTClassId(((Guid)value).ToString("D"));
    }
    return null;
  }

  public static string? AsString(this Array? array)
  {
    if (array == null) return null;
    var ss = new List<string?>();
    for (int i = 0; i < array.Length; i++)
    {
      var item = array.GetValue(i);
      var s = (item is string str) ? "\"" + item + "\"" : item?.ToString();
      ss.Add(s);
    }
    return "{ " + String.Join(", ", ss) + " }";
  }

  public static StringList? AsStringList(this DXVT.VTVector? element)
  {
    var array = element?.AsArray();
    if (array != null)
    {
      var result = new StringList();
      foreach (var item in array)
        if (item is string str)
          result.Add(str);
      return result;
    }
    return null;
  }

  public static DXVT.VTVector? AsVTVector(this StringList? list)
  {
    if (list == null) return null;
    var result = new DXVT.VTVector
    {
      Size = new DX.UInt32Value((uint)list.Count()),
      BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Lpstr)
    };
    foreach (var str in list)
    {
      var childItem = new DXVT.VTLPSTR(str);
      result.AppendChild(childItem);
    }
    return result;
  }

  public static HeadingPairs? AsHeadingPairs(this DXVT.VTVector? element)
  {
    var array = element?.AsArray();
    if (array != null)
    {
      var result = new HeadingPairs();
      for (int i = 0; i < array.Length / 2; i++)
      {
        var item1 = array.GetValue(i);
        var item2 = array.GetValue(i + 1);
        if (item1 is string str && item2 is int num)
          result.Add(new HeadingPair { Heading = str, Num = num });
      }
      return result;
    }
    return null;
  }

  public static DXVT.VTVector? AsVTVector(this HeadingPairs? list)
  {
    if (list == null) return null;
    var result = new DXVT.VTVector
    {
      Size = new DX.UInt32Value((uint)list.Count() * 2),
      BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Variant)
    };
    foreach (var item in list)
    {
      var childItem1 = new DXVT.VTLPSTR(item.Heading ?? "");
      result.AppendChild(childItem1);
      var childItem2 = new DXVT.VTInt32(item.Num.ToString());
      result.AppendChild(childItem2);
    }
    return result;
  }

  public static HyperlinkList? AsHyperlinkList(this DXVT.VTVector? element)
  {
    var array = element?.AsArray();
    if (array != null)
    {
      var result = new HyperlinkList();
      int n = array.Length;
      for (int i = 0; i < n / 6; i++)
      {
        var item = new HyperlinkInfo();
        for (var k = 0; k < 6; k++)
        {
          var varItem = array.GetValue(i * 6 + k);
          if (varItem is not null)
          {
            switch (k)
            {
              case 0:
                item.N1 = (int)varItem;
                break;
              case 1:
                item.N2 = (int)varItem;
                break;
              case 2:
                item.N3 = (int)varItem;
                break;
              case 3:
                var n4 = (int)varItem;
                var n4l = (Int16)(n4 & 0xFFFF);
                item.Attachment = (HyperlinkAttachment)Enum.ToObject(typeof(HyperlinkAttachment), n4l);
                var n4h = (Int16)(n4 >> 16 & 0xFFFF);
                item.Action = (HyperlinkAction)Enum.ToObject(typeof(HyperlinkAction), n4h);
                break;
              case 4:
                item.Target = (string)varItem;
                break;
              case 5:
                item.Location = (string?)varItem;
                break;
            }
          }
        }
        result.Add(item);
      }
      return result;
    }
    return null;
  }

  public static DXVT.VTVector? AsVTVector(this HyperlinkList? list)
  {
    if (list == null) return null;
    var result = new DXVT.VTVector
    {
      Size = new DX.UInt32Value((uint)list.Count() * 2),
      BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Variant)
    };
    foreach (var item in list)
    {
      result.AppendChild(new DXVT.VTInt32(item.N1.ToString()));
      result.AppendChild(new DXVT.VTInt32(item.N2.ToString()));
      result.AppendChild(new DXVT.VTInt32(item.N3.ToString()));
      var n4h = (uint)Convert.ChangeType(item.Action,typeof(uint));
      var n4l = (uint)Convert.ChangeType(item.Attachment,typeof(uint));
      var n4 = (n4h << 16) | (n4l);
      result.AppendChild(new DXVT.VTInt32(n4.ToString()));
      result.AppendChild(new DXVT.VTLPSTR(item.Target ?? ""));
      result.AppendChild(new DXVT.VTLPSTR(item.Location ?? ""));
    }
    return result;
  }

}


