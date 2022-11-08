using DM = DocxDocument.Model;
using OM = DocumentFormat.OpenXml.Math;
using OO = DocumentFormat.OpenXml;
using W = DocumentFormat.OpenXml.Wordprocessing;
using VT = DocumentFormat.OpenXml.VariantTypes;
using W14 = DocumentFormat.OpenXml.Office2010.Word;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public const string wordUrl = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

  public static string? ReadString(OO.OpenXmlElement? element)
  {
    var str = element?.InnerText;
    return (str == "") ? null : str;
  }

  public static string? ReadString(W.StringType? type)
  {
    if (type is not null)
    {
      return type?.Val;
    }
    return null;
  }

  public static string? ReadString(OO.StringValue? val)
  {
    if (val is not null)
    {
      return val.Value;
    }
    return null;
  }

  public static string? ReadString(OO.OpenXmlLeafTextElement? element)
  {
    var str = element?.Text;
    return str;
  }


  public static bool? ReadBoolean(OO.OpenXmlLeafTextElement? element)
  {
    var str = element?.Text;
    if (!string.IsNullOrEmpty(str) && bool.TryParse(str, out var bv))
      return bv;
    return null;
  }

  public static bool? ReadBoolean(OO.OnOffValue? element)
  {
    if (element?.HasValue == true)
      return element.Value;
    return null;
  }

  public static bool? ReadBoolean(OO.StringValue? value)
  {
    if (value is not null)
    {
      if (value.Value is "true" or "True" or "1" )
        return true;
      if (value.Value is "false" or "False" or "0")
        return false;
    }
    return null;
  }

  public static bool? ReadBoolean(W.OnOffType? element)
  {
    if (element!=null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value;
      else
        return true;
    }
    return null;
  }

  public static bool? ReadBoolean(W14.OnOffType? element)
  {
    if (element is not null)
    {
      if (element.Val?.HasValue == true)
      {
        if (element.Val.Value is W14.OnOffValues.True or W14.OnOffValues.One)
          return true;
        if (element.Val.Value is W14.OnOffValues.False or W14.OnOffValues.Zero)
          return false;
      }
      else
        return true;
    }
    return null;
  }

  public static bool? ReadBoolean(OM.OnOffType? element)
  {
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value is OM.BooleanValues.True or OM.BooleanValues.On or OM.BooleanValues.One;
      else
        return true;
    }
    return null;
  }
  public static bool? ReadBoolean(W.EmptyType? element)
  {
    if (element is not null)
      return true;
    return null;
  }

  public static bool? ReadBoolean(W14.EmptyType? element)
  {
    if (element is not null)
      return true;
    return null;
  }

  public static int? ReadInteger(OO.OpenXmlLeafTextElement? element)
  {
    var str = element?.Text;
    if (!string.IsNullOrEmpty(str) && int.TryParse(str, out var iv))
      return iv;
    return null;
  }

  public static int? ReadInteger(OO.StringValue? val)
  {
    if (val is not null)
    {
      return int.Parse(val.Value);
    }
    return null;
  }

  public static int? ReadInteger(OO.Int32Value? val)
  {
    if (val is not null)
    {
      return val.Value;
    }
    return null;
  }

  public static int? ReadInteger(OO.UInt32Value? val)
  {
    if (val is not null)
    {
      return (int)val.Value;
    }
    return null;
  }

  public static int? ReadInteger(W.UnsignedInt7Type? type)
  {
    if (type is not null)
    {
      return type.Val?.Value;
    }
    return null;
  }

  public static int? ReadInteger(W.DecimalNumberType? type)
  {
    if (type is not null)
    {
      return type.Val?.Value;
    }
    return null;
  }

  public static int? ReadInteger(W.UnsignedDecimalNumberType? type)
  {
    if (type is not null)
    {
      return (int?)type.Val?.Value;
    }
    return null;
  }

  public static int? ReadInteger(W.NonNegativeShortType? type)
  {
    if (type is not null)
    {
      return (int?)type.Val?.Value;
    }
    return null;
  }

  public static int? ReadInteger(OO.Int16Value? val)
  {
    if (val is not null)
    {
      return (int?)val.Value;
    }
    return null;
  }

  public static int? ReadInteger(OO.UInt16Value? val)
  {
    if (val is not null)
    {
      return (int?)val.Value;
    }
    return null;
  }

  public static DM.HexInt? ReadHexInt(OO.HexBinaryValue? val)
  {
    if (val is not null)
    {
      return Int32.Parse(val.Value, NumberStyles.HexNumber, null);
    }
    return null;
  }

  public static Guid? ReadGuid(OO.StringValue? val)
  {
    if (val is not null)
    {
      return Guid.Parse(val.Value);
    }
    return null;
  }

  public static DM.Percentage? ReadPercentage(OO.Int32Value? val)
  {
    if (val is not null)
    {
       return val.Value;
    }
    return null;
  }

  public static DM.Percentage? ReadPercentage(OO.StringValue? value)
  {
    if (value is not null && value.HasValue)
    {
      var str = value.Value;
      if (str is not null && str.EndsWith("%"))
        str = str.Substring(0, str.Length - 1);
      return decimal.Parse(str, CultureInfo.InvariantCulture);
    }
    return null;
  }

  public static DM.Twips? ReadTwips(W.NonNegativeShortType? type)
  {
    if (type is not null)
    {
      return type.Val?.Value;
    }
    return null;
  }

  public static DM.Twips? ReadTwips(W.TwipsMeasureType? type)
  {
    if (type is not null)
    {
      return int.Parse(type.Val?.Value);
    }
    return null;
  }

  public static DM.Twips? ReadTwips(OM.TwipsMeasureType? type)
  {
    if (type is not null)
    {
      return (int?)(type.Val?.Value);
    }
    return null;
  }
  public static EnumType? ReadEnum<EnumType, EnumValues>(OO.EnumValue<EnumValues>? val) where EnumType : struct, IConvertible where EnumValues : struct, IConvertible
  {
    if (val is not null && val.HasValue)
    {
      return (EnumType)Convert.ChangeType(val.Value, typeof(int));
    }
    return null;
  }

  public static EnumType? ReadEnum<EnumType>(OO.OpenXmlLeafElement? element) where EnumType : struct, IConvertible
  {
    if (element is not null)
    {
      try
      {
        var val = element.GetAttribute("val", wordUrl);
        if (val != null)
          return (EnumType)Enum.Parse(typeof(EnumType), val.Value, true);
      }
      catch (Exception ex)
      {

      }
    }
    return null;
  }

  public static DM.Base64Binary? ReadBase64Binary(OO.Base64BinaryValue? val)
  {
    if (val?.Value is not null)
    {
      return val.Value;
    }
    return null;
  }

  public static DM.HexBinary? ReadHexBinary(OO.HexBinaryValue? val)
  {
    if (val?.Value is not null)
    {
      return val.Value;
    }
    return null;
  }

  public static DM.Relationship? ReadRelationship(W.RelationshipType? type)
  {
    if (type?.Id is not null)
    {
      return new DM.Relationship { Id = type.Id };
    }
    return null;
  }

  public static byte[]? ReadBlob(DocumentFormat.OpenXml.OpenXmlLeafElement? blob)
  {
    if (blob == null)
      return null;
    if (String.IsNullOrEmpty(blob.InnerText))
      return null;
    var bytes = Convert.FromBase64String(blob.InnerText);
    if (bytes.Length >= 4)
    {
      var count = BitConverter.ToInt32(new ReadOnlySpan<byte>(bytes, 0, 4).ToArray(), 0);
      if (count == bytes.Length - 4)
      {
        var result = new Span<byte>(bytes, 4, count).ToArray();
        return result;
      }
    }
    throw new InvalidDataException($"Non-conformed VTBlob data");
  }

  public static byte[]? ReadData(DocumentFormat.OpenXml.OpenXmlLeafElement? data)
  {
    if (data == null)
      return null;
    if (String.IsNullOrEmpty(data.InnerText))
      return null;
    var bytes = Convert.FromBase64String(data.InnerText);
    return bytes;
  }

  public static DM.GuidDataPair? ReadVTOStreamData(DocumentFormat.OpenXml.VariantTypes.VTOStreamData? data)
  {
    if (data == null)
      return null;
    if (String.IsNullOrEmpty(data.InnerText))
      return null;
    var bytes = Convert.FromBase64String(data.InnerText);
    return new DM.GuidDataPair { Data = bytes };
  }

  public static DM.GuidDataPair? ReadVTVStreamData(DocumentFormat.OpenXml.VariantTypes.VTVStreamData? data)
  {
    if (data == null)
      return null;
    if (String.IsNullOrEmpty(data.InnerText))
      return null;
    var bytes = Convert.FromBase64String(data.InnerText);
    Guid? guid = null;
    if (data.Version?.Value is not null)
      guid = Guid.Parse(data.Version.Value);
    return new DM.GuidDataPair { Guid = guid, Data = bytes };
  }


  public static int[]? ReadVTArrayBounds(string? str)
  {
    if (str == null)
      return null;
    var ss = str.Split(',');
    var result = new int[ss.Length];
    for (int i = 0; i < ss.Length; i++)
      result[i] = Convert.ToInt32(ss[i]);
    return result;
  }

  public static DM.Collection<Object>? ReadVariants(DocumentFormat.OpenXml.VariantTypes.VTVector? vector)
  {
    if (vector == null)
      return null;
    var variants = new DM.Collection<Object>();
    foreach (var element in vector.Elements())
    {
      if (element is DocumentFormat.OpenXml.VariantTypes.Variant variant)
      {
        var item = variant.Elements().FirstOrDefault();
        if (item is not null)
          variants.Add(ReadVariantValue(item));
      }
      else
        variants.Add(ReadVariantValue(element));
    }
    return variants;
  }

  public static System.Array? ReadVTArray(DocumentFormat.OpenXml.VariantTypes.VTArray? vArray)
  {
    if (vArray == null)
      return null;
    if (vArray.BaseType == null)
      throw new InvalidDataException($"Unknown VTArray base val");
    var baseType = DM.VariantTypeMapping.ArrayBaseTypeToType[vArray.BaseType];
    var lBounds = ReadVTArrayBounds(vArray.LowerBounds?.InnerText);
    var uBounds = ReadVTArrayBounds(vArray.UpperBounds?.InnerText);
    if (lBounds == null || uBounds == null || lBounds.Length != uBounds.Length)
      throw new InvalidDataException($"Non-conformed VTArray bounds");
    var lengths = new int[uBounds.Length];
    for (int i = 0; i < lengths.Length; i++)
      lengths[i] = uBounds[i] - lBounds[i] + 1;
    var array = System.Array.CreateInstance(baseType, lengths, lBounds);
    int index = 0;
    foreach (var itemElement in vArray.Elements())
    {
      var item = ReadVariantValue(itemElement);
      array.SetValue(item, index++);
    }
    return array;
  }

  public static ICollection? ReadVTVector(DocumentFormat.OpenXml.VariantTypes.VTVector? vVector)
  {
    if (vVector == null)
      return null;
    if (vVector.BaseType == null)
      throw new InvalidDataException($"Unknown VTVector base val");
    var baseType = DM.VariantTypeMapping.VectorBaseTypeToType[vVector.BaseType];
    var vectorType = typeof(DM.Collection<>).MakeGenericType(new Type[] { baseType });
    var vector = vectorType.GetConstructor(new Type[0])?.Invoke(new object[0]);
    foreach (var itemElement in vVector.Elements())
    {
      var item = ReadVariantValue(itemElement);
      vectorType.GetMethod("Add")?.Invoke(vector, new object[] { item });
    }
    return vector as ICollection;
  }

  public static DM.Variant? ReadVariant(DocumentFormat.OpenXml.OpenXmlElement? element)
  {
    if (element == null)
      return null;
    if (element is VT.Variant variant)
      return new DM.Variant(DM.VariantType.Variant, ReadVariantValue(variant.InnerVariant));
    if (element is VT.VTBool vbool)
      return new DM.Variant(DM.VariantType.Bool, bool.Parse(vbool.InnerText));
    if (element is VT.VTLPSTR lpStr)
      return new DM.Variant(DM.VariantType.String, lpStr.InnerText);
    if (element is VT.VTLPWSTR lpwStr)
      return new DM.Variant(DM.VariantType.String, lpwStr.InnerText);
    if (element is VT.VTInteger vint)
      return new DM.Variant(DM.VariantType.Int32, Int32.Parse(vint.InnerText));
    if (element is VT.VTUnsignedInteger vuint)
      return new DM.Variant(DM.VariantType.UInt32, UInt32.Parse(vuint.InnerText));
    if (element is VT.VTInt32 i4)
      return new DM.Variant(DM.VariantType.Int32, Int32.Parse(i4.InnerText));
    if (element is VT.VTInt64 i8)
      return new DM.Variant(DM.VariantType.Int64, Int64.Parse(i8.InnerText));
    if (element is VT.VTUnsignedInt32 ui4)
      return new DM.Variant(DM.VariantType.UInt32, UInt32.Parse(ui4.InnerText));
    if (element is VT.VTUnsignedInt64 ui8)
      return new DM.Variant(DM.VariantType.UInt64, UInt64.Parse(ui8.InnerText));
    if (element is VT.VTByte vb)
      return new DM.Variant(DM.VariantType.Int8, SByte.Parse(vb.InnerText));
    if (element is VT.VTUnsignedByte ub)
      return new DM.Variant(DM.VariantType.UInt8, Byte.Parse(ub.InnerText));
    if (element is VT.VTShort vsh)
      return new DM.Variant(DM.VariantType.Int16, Int16.Parse(vsh.InnerText));
    if (element is VT.VTUnsignedShort ush)
      return new DM.Variant(DM.VariantType.UInt16, UInt16.Parse(ush.InnerText));
    if (element is VT.VTDate vdate)
      return new DM.Variant(DM.VariantType.UInt16, DateTime.Parse(vdate.InnerText));
    if (element is VT.VTFileTime vtime)
      return new DM.Variant(DM.VariantType.DateTime, DateTime.Parse(vtime.InnerText));
    if (element is VT.VTFloat vfloat)
      return new DM.Variant(DM.VariantType.Float, Single.Parse(vfloat.InnerText, System.Globalization.CultureInfo.InvariantCulture));
    if (element is VT.VTDouble vdouble)
      return new DM.Variant(DM.VariantType.Double, double.Parse(vdouble.InnerText, System.Globalization.CultureInfo.InvariantCulture));
    if (element is VT.VTCurrency vcurrency)
      return new DM.Variant(DM.VariantType.Currency, Decimal.Parse(vcurrency.InnerText, System.Globalization.CultureInfo.InvariantCulture));
    if (element is VT.VTDecimal vdecimal)
      return new DM.Variant(DM.VariantType.Decimal, Decimal.Parse(vdecimal.InnerText, System.Globalization.CultureInfo.InvariantCulture));
    if (element is VT.VTNull)
      return new DM.Variant(DM.VariantType.Null, null);
    if (element is VT.VTEmpty)
      return new DM.Variant(DM.VariantType.Empty, null);
    if (element is VT.VTError vError)
      return new DM.Variant(DM.VariantType.Empty, Int32.Parse(vError.InnerText, NumberStyles.AllowHexSpecifier));
    if (element is VT.VTClassId vClsId)
      return new DM.Variant(DM.VariantType.ClassId, Guid.Parse(vClsId.InnerText));

    if (element is VT.VTBlob vBlob)
      return new DM.Variant(DM.VariantType.Blob, ReadBlob(vBlob));
    if (element is VT.VTOBlob oBlob)
      return new DM.Variant(DM.VariantType.OBlob, ReadBlob(oBlob));
    if (element is VT.VTStorage vStorage)
      return new DM.Variant(DM.VariantType.Storage, ReadData(vStorage));
    if (element is VT.VTOStorage oStorage)
      return new DM.Variant(DM.VariantType.OStorage, ReadData(oStorage));
    if (element is VT.VTStreamData vStream)
      return new DM.Variant(DM.VariantType.StreamData, ReadData(vStream));
    if (element is VT.VTOStreamData oStream)
      return new DM.Variant(DM.VariantType.OStreamData, ReadVTOStreamData(oStream));
    if (element is VT.VTVStreamData vvStream)
      return new DM.Variant(DM.VariantType.VStreamData, ReadVTVStreamData(vvStream));

    if (element is VT.VTArray vArray)
      return new DM.Variant(DM.VariantType.Array, ReadVTArray(vArray));
    if (element is VT.VTVector vVector)
      return new DM.Variant(DM.VariantType.Vector, ReadVTVector(vVector));

    throw new InvalidDataException($"Variant val{element.GetType()} not recognized");
  }

  public static object? ReadVariantValue(OO.OpenXmlElement? element)
  {
    if (element is VT.Variant variant)
      return ReadVariantValue(variant.InnerVariant);
    if (element is VT.VTBool vbool)
      return bool.Parse(vbool.InnerText);
    if (element is VT.VTLPSTR lpStr)
      return lpStr.InnerText;
    if (element is VT.VTLPWSTR lpwStr)
      return lpwStr.InnerText;
    if (element is VT.VTBString bStr)
      return bStr.InnerText;
    if (element is VT.VTInteger vint)
      return Int32.Parse(vint.InnerText);
    if (element is VT.VTUnsignedInteger vuint)
      return Int32.Parse(vuint.InnerText);
    if (element is VT.VTInt32 i4)
      return Int32.Parse(i4.InnerText);
    if (element is VT.VTInt64 i8)
      return Int64.Parse(i8.InnerText);
    if (element is VT.VTUnsignedInt32 ui4)
      return UInt32.Parse(ui4.InnerText);
    if (element is VT.VTUnsignedInt64 ui8)
      return UInt64.Parse(ui8.InnerText);
    if (element is VT.VTByte vb)
      return SByte.Parse(vb.InnerText);
    if (element is VT.VTUnsignedByte ub)
      return Byte.Parse(ub.InnerText);
    if (element is VT.VTShort vsh)
      return Int16.Parse(vsh.InnerText);
    if (element is VT.VTUnsignedShort ush)
      return UInt16.Parse(ush.InnerText);
    if (element is VT.VTDate vdate)
      return DateTime.Parse(vdate.InnerText);
    if (element is VT.VTFileTime vtime)
      return DateTime.Parse(vtime.InnerText);
    if (element is VT.VTFloat vfloat)
      return Single.Parse(vfloat.InnerText, System.Globalization.CultureInfo.InvariantCulture);
    if (element is VT.VTDouble vdouble)
      return Double.Parse(vdouble.InnerText, System.Globalization.CultureInfo.InvariantCulture);
    if (element is VT.VTCurrency vcurrency)
      return Decimal.Parse(vcurrency.InnerText, System.Globalization.CultureInfo.InvariantCulture);
    if (element is VT.VTDecimal vdecimal)
      return Decimal.Parse(vdecimal.InnerText, System.Globalization.CultureInfo.InvariantCulture);
    if (element is VT.VTNull)
      return null;
    if (element is VT.VTEmpty)
      return new DM.Variant();
    if (element is VT.VTError vError)
      return Int32.Parse(vError.InnerText, NumberStyles.AllowHexSpecifier);
    if (element is VT.VTClassId vClsId)
      return Guid.Parse(vClsId.InnerText);

    if (element is VT.VTBlob vBlob)
      return ReadBlob(vBlob);
    if (element is VT.VTOBlob oBlob)
      return ReadBlob(oBlob);
    if (element is VT.VTStreamData vStream)
      return ReadData(vStream);
    if (element is VT.VTOStreamData oStream)
      return ReadVTOStreamData(oStream);
    if (element is VT.VTVStreamData vvStream)
      return ReadVTVStreamData(vvStream);
    if (element is VT.VTStorage vStorage)
      return ReadData(vStorage);
    if (element is VT.VTOStorage oStorage)
      return ReadData(oStorage);

    if (element is VT.VTArray vArray)
      return ReadVTArray(vArray);
    if (element is VT.VTVector vVector)
      return ReadVTVector(vVector);

    throw new InvalidDataException($"Variant val{element?.GetType()} not recognized");
  }

  public static DM.HexInt? ToHexInt(OO.HexBinaryValue? val)
  {
    if (val?.Value == null)
      return null;
    return (val.Value);
  }

}