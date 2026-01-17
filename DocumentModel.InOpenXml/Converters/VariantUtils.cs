using System.Runtime.CompilerServices;

namespace DocumentModel;

/// <summary>
/// This static class contains extension operations to be performed on a DocumentFormat.OpenXml.VariantTypes objects.
/// </summary>
public static class VariantUtils
{
  /// <summary>
  /// Table to convert OpenXml VectorBaseValues value to C# type.
  /// </summary>
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

  /// <summary>
  /// Converts the specified OpenXml VTVector element to a C# array.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static Array? AsArray(this DXVT.VTVector? element) => AsArray(element, out _);

  /// <summary>
  /// Converts the specified OpenXml VTVector element to a C# array.
  /// using the specified OpenXml VectorBaseValues baseType.
  /// </summary>
  /// <param name="element"></param>
  /// <param name="baseType"></param>
  /// <returns></returns>
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


  /// <summary>
  /// Table to convert C# type to OpenXml VectorBaseValues value.
  /// Contains default base values. Default for String type is Lpwstr.
  /// </summary>
  private static readonly Dictionary<Type, DXVT.VectorBaseValues> TypeToVectorBase = new Dictionary<Type, DXVT.VectorBaseValues>
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

  /// <summary>
  /// Converts the specified array to an array of OpenXmlElements
  /// using the VectorBaseValues base type (when specified).
  /// If it is unspecified, then default VectorBaseValues types are used.
  /// </summary>
  /// <param name="array"></param>
  /// <param name="baseType"></param>
  /// <returns></returns>
  public static DX.OpenXmlElement[]? AsChildArray(this Array? array, DXVT.VectorBaseValues? baseType = null)
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

  /// <summary>
  /// Converts the specified array to an OpenXml VTVector element
  /// using the VectorBaseValues base type (when specified).
  /// If it is unspecified, then default VectorBaseValues types are used.
  /// </summary>
  /// <param name="array"></param>
  /// <param name="baseType"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Table to convert OpenXml ArrayBaseValues value to C# type.
  /// </summary>
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

  /// <summary>
  /// Converts the specified OpenXml VTArray element to a C# array.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static Array? AsArray(this DXVT.VTArray? element) => AsArray(element, out _);

  /// <summary>
  /// Converts the specified OpenXml VTArray element to a C# array
  /// using the specified OpenXml ArrayBaseValues base type. 
  /// </summary>
  /// <param name="element"></param>
  /// <param name="baseType"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Converts the value of the specified VTInteger variant to a nullable 32-bit integer.
  /// </summary>
  /// <remarks>If the inner text of the variant does not represent a valid 32-bit integer, the method returns
  /// null.</remarks>
  /// <param name="variant">The VTInteger variant whose value is to be converted.</param>
  /// <returns>A 32-bit integer value if the conversion succeeds; otherwise, null.</returns>
  public static long? AsLong(this DXVT.VTInteger variant)
  {
    if (long.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTUnsignedInt32 variant to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="variant">The VTUnsignedInt32 variant whose value is to be converted.</param>
  /// <returns>A 32-bit unsigned integer representation of the variant's value, or 0 if the value cannot be parsed as a valid
  /// UInt32.</returns>
  public static ulong? AsULong(this DXVT.VTUnsignedInteger variant)
  {
    if (ulong.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified <see cref="DXVT.VTBool"/> variant to a Boolean value.
  /// </summary>
  /// <param name="variant">The <see cref="DXVT.VTBool"/> variant whose value is to be converted.</param>
  /// <returns>A Boolean value that represents the parsed value of the variant. Returns <see langword="false"/> if the value
  /// cannot be parsed as a Boolean.</returns>
  public static bool? AsBoolean(this DXVT.VTBool variant)
  {
    if (bool.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTByte variant to a nullable 8-bit signed integer.
  /// </summary>
  /// <param name="variant">The VTByte variant whose value to convert.</param>
  /// <returns>A nullable 8-bit signed integer containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static sbyte? AsSByte(this DXVT.VTByte variant)
  {
    if (sbyte.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTShort variant to a nullable 16-bit signed integer.
  /// </summary>
  /// <remarks>If the inner text of the variant cannot be parsed as a valid 16-bit signed integer, the method
  /// returns null.</remarks>
  /// <param name="variant">The VTShort variant whose value is to be converted.</param>
  /// <returns>A 16-bit signed integer representing the value of the variant, or null if the conversion fails.</returns>
  public static short? AsShort(this DXVT.VTShort variant)
  {
    if (short.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTInt32 variant to a nullable 32-bit signed integer.
  /// </summary>
  /// <param name="variant">The VTInt32 variant whose inner text is to be parsed as an integer.</param>
  /// <returns>An integer value if the inner text can be successfully parsed; otherwise, null.</returns>
  public static int? AsInt(this DXVT.VTInt32 variant)
  {
    if (int.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the inner text of the specified VTInt64 variant to a 64-bit signed integer.
  /// </summary>
  /// <param name="variant">The VTInt64 variant whose inner text is to be converted to a long value.</param>
  /// <returns>A 64-bit signed integer if the inner text can be successfully parsed; otherwise, null.</returns>
  public static long? AsLong(this DXVT.VTInt64 variant)
  {
    if (long.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTUnsignedByte variant to a nullable 8-bit unsigned integer.
  /// </summary>
  /// <param name="variant">The VTUnsignedByte variant whose value is to be converted.</param>
  /// <returns>An 8-bit unsigned integer containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static byte? AsByte(this DXVT.VTUnsignedByte variant)
  {
    if (byte.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTUnsignedShort variant to a nullable 16-bit unsigned integer.
  /// </summary>
  /// <param name="variant">The VTUnsignedShort variant whose value is to be converted.</param>
  /// <returns>A 16-bit unsigned integer containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static ushort? AsUShort(this DXVT.VTUnsignedShort variant)
  {
    if (ushort.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTUnsignedInt32 variant to a nullable 32-bit unsigned integer.    
  /// </summary>
  /// <param name="variant">The VTUnsignedInt32 variant whose value is to be converted.</param>
  /// <returns>A 32-bit unsigned integer containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static uint? AsUInt(this DXVT.VTUnsignedInt32 variant)
  {
    if (uint.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTUnsignedInt64 variant to a nullable 64-bit unsigned integer.
  /// </summary>
  /// <param name="variant">The VTUnsignedInt64 variant whose value is to be converted.</param>
  /// <returns>A 64-bit unsigned integer containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static ulong? AsULong(this DXVT.VTUnsignedInt64 variant)
  {
    if (ulong.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTFloat variant to a nullable single-precision floating-point number. 
  /// </summary>
  /// <param name="variant">The VTFloat variant whose value is to be converted.</param>
  /// <returns>A single-precision floating-point number containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static float? AsFloat(this DXVT.VTFloat variant)
  {
    if (float.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTDouble variant to a nullable double-precision floating-point number.
  /// </summary>
  /// <param name="variant">The VTDouble variant whose value is to be converted.</param>
  /// <returns>A double-precision floating-point number containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static double? AsDouble(this DXVT.VTDouble variant)
  {
    if (double.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }


  /// <summary>
  /// Converts the value of the specified VTDecimal variant to a nullable decimal number.
  /// </summary>
  /// <param name="variant">The VTDecimal variant whose value is to be converted.</param>
  /// <returns>A decimal number containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static decimal? AsDecimal(this DXVT.VTDecimal variant)
  {
    if (decimal.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTCurrency variant to a nullable decimal number.
  /// </summary>
  /// <param name="variant">The VTCurrency variant whose value is to be converted.</param>
  /// <returns>A decimal number containing the converted value if the conversion succeeds; otherwise, null.</returns>
  public static decimal? AsDecimal(this DXVT.VTCurrency variant)
  {
    if (decimal.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTDate variant to a nullable DateTime object.
  /// </summary>
  /// <remarks>This method attempts to parse the inner text of the VTDate variant using standard date and time
  /// formats. If parsing fails, the method returns null.</remarks>
  /// <param name="variant">The VTDate variant whose value is to be converted.</param>
  /// <returns>A DateTime value if the variant's inner text can be parsed as a valid date and time; otherwise, null.</returns>
  public static DateTime? AsDateTime(this DXVT.VTDate variant)
  {
    if (DateTime.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified <see cref="DXVT.VTFileTime"/> to a <see cref="DateTime"/> object, if possible.  
  /// </summary>
  /// <remarks>If the <see cref="DXVT.VTFileTime.InnerText"/> property does not contain a valid date and time
  /// string, the method returns <see langword="null"/>.</remarks>
  /// <param name="variant">The <see cref="DXVT.VTFileTime"/> instance containing the date and time value to convert.</param>
  /// <returns>A <see cref="DateTime"/> object that represents the converted value, or <see langword="null"/> if the conversion
  /// fails.</returns>
  public static DateTime? AsDateTime(this DXVT.VTFileTime variant)
  {
    if (DateTime.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTClassId to a Guid.
  /// </summary>
  /// <remarks>This method parses the InnerText property of the VTClassId as a Guid. If the InnerText is not a
  /// valid Guid representation, the method returns null.</remarks>
  /// <param name="variant">The VTClassId instance whose value to convert.</param>
  /// <returns>A Guid that represents the value of the VTClassId if the conversion succeeds; otherwise, null.</returns>
  public static Guid? AsGuid(this DXVT.VTClassId variant)
  {
    if (Guid.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }

  /// <summary>
  /// Converts the value of the specified VTError variant to a nullable HexInt.
  /// </summary>
  /// <param name="variant">The VTError instance whose value to convert.</param>
  /// <returns>A HexInt that represents the value of the VTError if the conversion succeeds; otherwise, null.</returns>
  public static HexInt? AsHexInt(this DXVT.VTError variant)
  {
    if (HexInt.TryParse(variant.InnerText, out var result))
      return result;
    return null;
  }


  /// <summary>
  /// Converts the value of the specified VTBlob variant to a byte array.
  /// </summary>
  /// <param name="variant">The VTBlob instance whose value to convert.</param>
  /// <returns>A byte array that represents the value of the VTBlob if the conversion succeeds; otherwise, null.</returns>
  public static byte[]? AsByteArray(this DXVT.VTBlob variant)
  {
    var value = Convert.FromBase64String(variant.InnerText);
    return value;
  }

  /// <summary>
  /// Converts the value of the specified VTOBlob variant to a byte array.
  /// </summary>
  /// <param name="variant">The VTOBlob instance whose value to convert.</param>
  /// <returns>A byte array that represents the value of the VTOBlob if the conversion succeeds; otherwise, null.</returns>
  public static byte[]? AsByteArray(this DXVT.VTOBlob variant)
  {
    var value = Convert.FromBase64String(variant.InnerText);
    byte[] result = new byte[value.Length - 4];
    Array.Copy(value, 4, result, 0, result.Length);
    return result;
  }

  /// <summary>
  /// Converts the value of the specified VTStorage variant to a byte array.
  /// </summary>
  /// <param name="variant">The VTStorage instance whose value to convert.</param>
  /// <returns>A byte array that represents the value of the VTStorage if the conversion succeeds; otherwise, null.</returns>
  public static byte[]? AsByteArray(this DXVT.VTStorage variant)
  {
    var value = Convert.FromBase64String(variant.InnerText);
    return value;
  }


  /// <summary>
  /// Converts the value of the specified VTOStorage variant to a byte array.
  /// </summary>
  /// <param name="variant">The VTOStorage instance whose value to convert.</param>
  /// <returns>A byte array that represents the value of the VTStorage if the conversion succeeds; otherwise, null.</returns>
  public static byte[]? AsByteArray(this DXVT.VTOStorage variant)
  {
    var value = Convert.FromBase64String(variant.InnerText);
    return value;
  }


  /// <summary>
  /// Converts the value of the specified VTOStreamData variant to a byte array.
  /// </summary>
  /// <param name="variant">The VTOStreamData instance whose value to convert.</param>
  /// <returns>A byte array that represents the value of the VTOStreamData if the conversion succeeds; otherwise, null.</returns>
  public static byte[]? AsByteArray(this DXVT.VTOStreamData variant)
  {
    var value = Convert.FromBase64String(variant.InnerText);
    return value;
  }

  /// <summary>
  /// Converts the value of the specified VTVStreamData variant to a Guid version number and byte array.
  /// </summary>
  /// <param name="variant">The VTVStreamData instance whose value to convert.</param>
  /// <returns>A pair of Guid and byte array that represents the value of the VTVStreamData if the conversion succeeds; otherwise, null.</returns>
  public static (Guid, byte[])? AsGuidAndByteArray(this DXVT.VTVStreamData variant)
  {
    if (Guid.TryParse(variant.Version?.Value, out Guid guid))
    {
      var value = Convert.FromBase64String(variant.InnerText);
      return (guid, value);
    }
    return null;
  }

  /// <summary>
  /// Converts the specified OpenXmlElement, which must be some of the VTVariant types,
  /// to an object of the proper C# type.
  /// </summary>
  /// <param name="element">The OpenXmlElement instance to convert.</param>
  /// <returns>An object that represents the value of the OpenXmlElement if the conversion succeeds; otherwise, null.</returns>
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
    if (element is DXVT.VTLPSTR vtLPstr)
      return vtLPstr.InnerText;
    if (element is DXVT.VTLPWSTR vtLPWSTR)
      return vtLPWSTR.InnerText;
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
      return vtBlob.AsByteArray();
    if (element is DXVT.VTOBlob vtOBlob)
      return vtOBlob.AsByteArray();
    if (element is DXVT.VTStorage vtStorage)
      return vtStorage.AsByteArray();
    if (element is DXVT.VTOStorage vtOStorage)
      return vtOStorage.AsByteArray();
    if (element is DXVT.VTOStreamData vtOStream)
      return vtOStream.AsByteArray();
    if (element is DXVT.VTVStreamData vtVStream)
      return vtVStream.AsGuidAndByteArray();
    return null;
  }

  /// <summary>
  /// Converts any object value to an OpenXmlElement
  /// using the specified VectorBaseValues base type.
  /// </summary>
  /// <param name="value">The object value to convert.</param>
  /// <param name="baseType">The base type to use for the conversion.</param>
  /// <returns></returns>
  public static DX.OpenXmlElement? AsVTVariant(this object? value, DXVT.VectorBaseValues? baseType = null)
  {
    if (value == null)
      return new DXVT.VTNull();
    if (value == DBNull.Value)
      return new DXVT.VTEmpty();
    if (baseType == null)
    {
      if (value is Variant variant)
      {
        if (variant.ValueType!=null)
        {
          baseType = TypeToVectorBase[variant.ValueType];
          value = variant.Value;
        }
        else
          baseType = DXVT.VectorBaseValues.Variant;
      }
      else
        baseType = TypeToVectorBase[value.GetType()];
    }
    if (baseType == DXVT.VectorBaseValues.Variant)
    {
      var result = new DXVT.Variant();
      var childElement = value.AsVTVariant();
      if (childElement != null)
        result.AppendChild(childElement);
      return result;
    }
    if (value == null)
      return new DXVT.VTNull();
    if (baseType == DXVT.VectorBaseValues.OneByteSignedInteger)
      return new DXVT.VTByte(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.TwoBytesSignedInteger)
      return new DXVT.VTShort(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.FourBytesSignedInteger)
      return new DXVT.VTInt32(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.EightBytesSignedInteger)
      return new DXVT.VTInt64(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.OneByteUnsignedInteger)
      return new DXVT.VTUnsignedByte(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.TwoBytesUnsignedInteger)
      return new DXVT.VTUnsignedShort(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.FourBytesUnsignedInteger)
      return new DXVT.VTUnsignedInt32(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.EightBytesUnsignedInteger)
      return new DXVT.VTUnsignedInt64(value.ToString()!);
    if (baseType == DXVT.VectorBaseValues.FourBytesReal)
      return new DXVT.VTFloat(((float)value).ToString(CultureInfo.InvariantCulture)!);
    if (baseType == DXVT.VectorBaseValues.EightBytesReal)
      return new DXVT.VTDouble(((double)value).ToString(CultureInfo.InvariantCulture)!);
    if (baseType == DXVT.VectorBaseValues.Lpstr)
      return new DXVT.VTLPSTR(((string)value));
    if (baseType == DXVT.VectorBaseValues.Lpwstr)
      return new DXVT.VTLPWSTR(((string)value));
    if (baseType == DXVT.VectorBaseValues.Bstr)
      return new DXVT.VTBString(((string)value));
    if (baseType == DXVT.VectorBaseValues.Date)
      return new DXVT.VTDate(((DateTime)value).ToString("yyyy-MM-dd"));
    if (baseType == DXVT.VectorBaseValues.Filetime)
      return new DXVT.VTFileTime(((DateTime)value).ToString("s"));
    if (baseType == DXVT.VectorBaseValues.Bool)
      return new DXVT.VTBool(((bool)value) ? "true" : "false");
    if (baseType == DXVT.VectorBaseValues.Currency)
      return new DXVT.VTCurrency(((decimal)value).ToString(CultureInfo.InvariantCulture)!);
    if (baseType == DXVT.VectorBaseValues.Error)
      return new DXVT.VTError("0x" + ((int)value).ToString("X8"));
    if (baseType == DXVT.VectorBaseValues.ClassId)
      return new DXVT.VTClassId(((Guid)value).ToString("B"));
    return null;
  }

  #region conversion methods needed for ExtendedFileProperties read/write
  /// <summary>
  /// Converts an array of items to the string of items separated with commas.
  /// Items which are strings are emitted enclosed with double-quotes characters.
  /// </summary>
  /// <param name="array"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Converts the specified OpenXml VTVector element to a StringList value.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Converts the specified StringList value to an OpenXml VTVector element.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DXVT.VTVector? AsVTVector(this StringList? value)
  {
    if (value == null) return null;
    var result = new DXVT.VTVector
    {
      Size = new DX.UInt32Value((uint)value.Count()),
      BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Lpstr)
    };
    foreach (var str in value)
    {
      var childItem = new DXVT.VTLPSTR(str);
      result.AppendChild(childItem);
    }
    return result;
  }

  /// <summary>
  /// Converts the specified OpenXml VTVector element to a HeadingPairs value.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static HeadingPairs? AsHeadingPairs(this DXVT.VTVector? element)
  {
    var array = element?.AsArray();
    if (array != null)
    {
      var result = new HeadingPairs();
      for (int i = 0; i < array.Length / 2; i++)
      {
        var item1 = array.GetValue(i * 2);
        var item2 = array.GetValue(i * 2 + 1);
        if (item1 is string str && item2 is int num)
          result.Add(new HeadingPair { Name = str, Number = num });
      }
      return result;
    }
    return null;
  }

  /// <summary>
  /// Converts the specified HeadingPairs value to an OpenXml VTVector element.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DXVT.VTVector? AsVTVector(this HeadingPairs? value)
  {
    if (value == null) return null;
    var result = new DXVT.VTVector
    {
      Size = new DX.UInt32Value((uint)value.Count() * 2),
      BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Variant)
    };
    foreach (var item in value)
    {
      var childItem1 = new DXVT.VTLPSTR(item.Name ?? "");
      result.AppendChild(childItem1);
      var childItem2 = new DXVT.VTInt32(item.Number.ToString() ?? "");
      result.AppendChild(childItem2);
    }
    return result;
  }

  /// <summary>
  /// Converts the specified OpenXml VTVector element to a HyperlinkList value.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
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
                item.Attachment = (HyperlinkAttachmentKind)Enum.ToObject(typeof(HyperlinkAttachmentKind), n4l);
                var n4h = (Int16)(n4 >> 16 & 0xFFFF);
                item.Action = (HyperlinkActionKind)Enum.ToObject(typeof(HyperlinkActionKind), n4h);
                break;
              case 4:
                item.Target = (string?)varItem ?? string.Empty;
                break;
              case 5:
                item.Location = (string?)varItem ?? string.Empty;
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

  /// <summary>
  /// Converts the specified HyperlinkList value to an OpenXml VTVector element.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DXVT.VTVector? AsVTVector(this HyperlinkList? value)
  {
    if (value == null) return null;
    var result = new DXVT.VTVector
    {
      Size = new DX.UInt32Value((uint)value.Count * 2),
      BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Variant)
    };
    foreach (var item in value)
    {
      result.AppendChild(new DXVT.VTInt32(item.N1.ToString()));
      result.AppendChild(new DXVT.VTInt32(item.N2.ToString()));
      result.AppendChild(new DXVT.VTInt32(item.N3.ToString()));
      var n4h = (uint)Convert.ChangeType(item.Action, typeof(uint));
      var n4l = (uint)Convert.ChangeType(item.Attachment, typeof(uint));
      var n4 = (n4h << 16) | (n4l);
      result.AppendChild(new DXVT.VTInt32(n4.ToString()));
      result.AppendChild(new DXVT.VTLPSTR(item.Target ?? ""));
      result.AppendChild(new DXVT.VTLPSTR(item.Location ?? ""));
    }
    return result;
  }
  #endregion
}


