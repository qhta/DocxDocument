namespace DocumentModel;

/// <summary>
/// Converter class for converting objects to their string representation. This class maintains a mapping of types to custom conversion functions, allowing for flexible and extensible string conversion logic. When an object is passed to the ConvertToString method, it checks if there is a registered converter for the object's type and uses it to convert the object to a string. If no converter is found, it falls back to the default ToString() method of the object. This design allows for easy customization of how specific types are represented as strings without modifying the core logic of the conversion process.
/// </summary>
public static class ObjectToStringConverter
{

  private static readonly Dictionary<Type, Func<object?, string?>> _convertsToString = new();

  private static readonly Dictionary<Type, Func<string?, object?>> _convertsFromString = new();


  static ObjectToStringConverter()
  {
    RegisterConverters(typeof(string), ObjectToString, StringToObject);
    RegisterConverters(typeof(Boolean), BooleanObjectToString, StringToBooleanObject);
    RegisterConverters(typeof(SByte), SByteObjectToString, StringToSByteObject);
    RegisterConverters(typeof(Int16), Int16ObjectToString, StringToInt16Object);
    RegisterConverters(typeof(Int32), Int32ObjectToString, StringToInt32Object);
    RegisterConverters(typeof(Int64), Int64ObjectToString, StringToInt64Object);
    RegisterConverters(typeof(Byte), ByteObjectToString, StringToByteObject);
    RegisterConverters(typeof(UInt16), UInt16ObjectToString, StringToUInt16Object);
    RegisterConverters(typeof(UInt32), UInt32ObjectToString, StringToUInt32Object);
    RegisterConverters(typeof(UInt64), UInt64ObjectToString, StringToUInt64Object);
    RegisterConverters(typeof(Single), SingleObjectToString, StringToSingleObject);
    RegisterConverters(typeof(Double), DoubleObjectToString, StringToDoubleObject);
    RegisterConverters(typeof(Decimal), DecimalObjectToString, StringToDecimalObject);
    RegisterConverters(typeof(DateTime), DateTimeObjectToString, StringToDateTimeObject);
    RegisterConverters(typeof(HexBinary), HexBinaryObjectToString, StringToHexBinaryObject);
    RegisterConverters(typeof(HexByte), HexByteObjectToString, StringToHexByteObject);
    RegisterConverters(typeof(HexChar), HexCharObjectToString, StringToHexCharObject);
    RegisterConverters(typeof(HexColor), HexColorObjectToString, StringToHexColorObject); 
    RegisterConverters(typeof(HexInt), HexIntObjectToString, StringToHexIntObject);
    RegisterConverters(typeof(HexLong), HexLongObjectToString, StringToHexLongObject);
    RegisterConverters(typeof(HexPercent), HexPercentObjectToString, StringToHexPercentObject);
    RegisterConverters(typeof(Percent), PercentObjectToString, StringToPercentObject);
    RegisterConverters(typeof(Percentage), PercentageObjectToString, StringToPercentageObject);
    RegisterConverters(typeof(Degrees), DegreesObjectToString, StringToDegreesObject);
    RegisterConverters(typeof(StringList), StringListObjectToString, StringToStringListObject);
  }

  /// <summary>
  /// Registers custom conversion functions for a specific type, allowing for flexible and extensible string conversion logic. The toStringConverter function is used to convert an object of the specified type to its string representation, while the fromStringConverter function is used to convert a string back to an object of the specified type. By registering these converters, you can customize how specific types are represented as strings and how they are reconstructed from their string representations without modifying the core logic of the conversion process.
  /// </summary>
  /// <param name="type">The type for which the converters are being registered.</param>
  /// <param name="toStringConverter">The function to convert an object of the specified type to a string.</param>
  /// <param name="fromStringConverter">The function to convert a string back to an object of the specified type.</param>
  public static void RegisterConverters(Type type, Func<object?, string?> toStringConverter, 
    Func<string?, object?> fromStringConverter)
  {
    _convertsToString[type] = toStringConverter;
    _convertsFromString[type] = fromStringConverter;
  }

  /// <summary>
  /// Converts an object to its string representation using a predefined mapping of types to conversion functions. If the object's type is not found in the mapping, it falls back to the default ToString() method.
  /// </summary>
  /// <param name="value">The object to convert to a string.</param>
  /// <returns>The string representation of the object, or null if the object is null.</returns>
  public static string? ConvertToString(object? value)
  {
    if (value == null)
      return null;

    var type = value.GetType();
    if (_convertsToString.TryGetValue(type, out var converter))
    {
      return converter(value);
    }
    else if (value is Enum enumValue)
    {
      return enumValue.ToString();
    }
    var str = JsonSerializer.Serialize(value, type, new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull });
    str = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(str));
    return str;
  }

  /// <summary>
  /// Converts a string back to an object of the specified target type using a predefined mapping of types to conversion functions. If the target type is not found in the mapping, it returns null. This method allows for flexible deserialization of string representations back into their original object forms based on the registered converters. 
  /// </summary>
  /// <param name="str">The string representation of the object to convert.</param>
  /// <param name="targetType">The target type to convert the string to.</param>
  /// <returns>The converted object, or null if the conversion fails or the target type is not found.</returns>
  public static object? ConvertFromString(string? str, Type targetType)
  {
    if (str == null)
      return null;

    if (_convertsFromString.TryGetValue(targetType, out var converter))
    {
      var result = converter(str);
      return result;
    }
    else if (targetType.IsEnum)
    {
      return Enum.Parse(targetType, str);
    }
    else
    {
      str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(str));
      var result = JsonSerializer.Deserialize(str, targetType);
      return result;
    }
  }

  private static string? ObjectToString(object? val) => (string?)val;
  private static object? StringToObject(string? str) => (string?)str;

  private static string? BooleanObjectToString(object? val) => BooleanToString((Boolean?)val);
  private static object? StringToBooleanObject(string? str) => StringToBoolean(str);
  private static string? BooleanToString(Boolean? val) => val?.ToString().ToLower();
  private static Boolean? StringToBoolean(string? str) => String.IsNullOrEmpty(str) ? null : Boolean.Parse(str);

  private static string? SByteObjectToString(object? val) => SByteToString((SByte?)val);
  private static object? StringToSByteObject(string? str) => StringToSByte(str);
  private static string? SByteToString(SByte? val) => val?.ToString();
  private static SByte? StringToSByte(string? str) => String.IsNullOrEmpty(str) ? null : SByte.Parse(str);

  private static string? Int16ObjectToString(object? val) => Int16ToString((Int16?)val);
  private static object? StringToInt16Object(string? str) => StringToInt16(str);
  private static string? Int16ToString(Int16? val) => val?.ToString();
  private static Int16? StringToInt16(string? str) => String.IsNullOrEmpty(str) ? null : Int16.Parse(str);

  private static string? Int32ObjectToString(object? val) => Int32ToString((Int32?)val);
  private static object? StringToInt32Object(string? str) => StringToInt32(str);
  private static string? Int32ToString(Int32? val) => val?.ToString();
  private static Int32? StringToInt32(string? str) => String.IsNullOrEmpty(str) ? null : Int32.Parse(str);

  private static string? Int64ObjectToString(object? val) => Int64ToString((Int64?)val);
  private static object? StringToInt64Object(string? str) => StringToInt64(str);
  private static string? Int64ToString(Int64? val) => val?.ToString();
  private static Int64? StringToInt64(string? str) => String.IsNullOrEmpty(str) ? null : Int64.Parse(str);


  private static string? ByteObjectToString(object? val) => ByteToString((Byte?)val);
  private static object? StringToByteObject(string? str) => StringToByte(str);
  private static string? ByteToString(Byte? val) => val?.ToString();   
  private static Byte? StringToByte(string? str) => String.IsNullOrEmpty(str) ? null : Byte.Parse(str);

  private static string? UInt16ObjectToString(object? val) => UInt16ToString((UInt16?)val);
  private static object? StringToUInt16Object(string? str) => StringToUInt16(str);
  private static string? UInt16ToString(UInt16? val) => val?.ToString();
  private static UInt16? StringToUInt16(string? str) => String.IsNullOrEmpty(str) ? null : UInt16.Parse(str);

  private static string? UInt32ObjectToString(object? val) => UInt32ToString((UInt32?)val);
  private static object? StringToUInt32Object(string? str) => StringToUInt32(str);
  private static string? UInt32ToString(UInt32? val) => val?.ToString();
  private static UInt32? StringToUInt32(string? str) => String.IsNullOrEmpty(str) ? null : UInt32.Parse(str);

  private static string? UInt64ObjectToString(object? val) => UInt64ToString((UInt64?)val);
  private static object? StringToUInt64Object(string? str) => StringToUInt64(str);
  private static string? UInt64ToString(UInt64? val) => val?.ToString();
  private static UInt64? StringToUInt64(string? str) => String.IsNullOrEmpty(str) ? null : UInt64.Parse(str);

  private static string? SingleObjectToString(object? val) => SingleToString((Single?)val);
  private static object? StringToSingleObject(string? str) => StringToSingle(str);
  private static string? SingleToString(Single? val) => val?.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
  private static Single? StringToSingle(string? str) => String.IsNullOrEmpty(str) ? null : Single.Parse(str, System.Globalization.CultureInfo.InvariantCulture);

  private static string? DoubleObjectToString(object? val) => DoubleToString((Double?)val);
  private static object? StringToDoubleObject(string? str) => StringToDouble(str);
  private static string? DoubleToString(Double? val) => val?.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
  private static Double? StringToDouble(string? str) => String.IsNullOrEmpty(str) ? null : Double.Parse(str, System.Globalization.CultureInfo.InvariantCulture);

  private static string? DecimalObjectToString(object? val) => DecimalToString((Decimal?)val);
  private static object? StringToDecimalObject(string? str) => StringToDecimal(str);
  private static string? DecimalToString(Decimal? val) => val?.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
  private static Decimal? StringToDecimal(string? str) => String.IsNullOrEmpty(str) ? null : Decimal.Parse(str, System.Globalization.CultureInfo.InvariantCulture);

  private static string? DateTimeObjectToString(object? val) => DateTimeToString((DateTime?)val);

  private static object? StringToDateTimeObject(string? str) => StringToDateTime(str);
  private static string? DateTimeToString(DateTime? val) => val?.ToString("o");
  private static DateTime? StringToDateTime(string? str) => String.IsNullOrEmpty(str) ? null : DateTime.Parse(str, null, System.Globalization.DateTimeStyles.RoundtripKind);

  private static string? HexBinaryObjectToString(object? val) => HexBinaryToString((HexBinary?)val);
  private static object? StringToHexBinaryObject(string? str) => StringToHexBinary(str);
  private static string? HexBinaryToString(HexBinary? val) => val?.ToString();
  private static HexBinary? StringToHexBinary(string? str) => String.IsNullOrEmpty(str) ? (HexBinary?)null : HexBinary.Parse(str!);

  private static string? HexByteObjectToString(object? val) => HexByteToString((HexByte?)val);
  private static object? StringToHexByteObject(string? str) => StringToHexByte(str);
  private static string? HexByteToString(HexByte? val) => val?.ToString();
  private static HexByte? StringToHexByte(string? str) => String.IsNullOrEmpty(str) ? (HexByte?)null : HexByte.Parse(str!);

  private static string? HexCharObjectToString(object? val) => HexCharToString((HexChar?)val);
  private static object? StringToHexCharObject(string? str) => StringToHexChar(str);
  private static string? HexCharToString(HexChar? val) => val?.ToString();
  private static HexChar? StringToHexChar(string? str) => String.IsNullOrEmpty(str) ? (HexChar?)null : HexChar.Parse(str!);

  private static string? HexColorObjectToString(object? val) => HexColorToString((HexColor?)val);
  private static object? StringToHexColorObject(string? str) => StringToHexColor(str);
  private static string? HexColorToString(HexColor? val) => val?.ToString();
  private static HexColor? StringToHexColor(string? str) => String.IsNullOrEmpty(str) ? (HexColor?)null : HexColor.Parse(str!);

  private static string? HexIntObjectToString(object? val) => HexIntToString((HexInt?)val);
  private static object? StringToHexIntObject(string? str) => StringToHexInt(str);
  private static string? HexIntToString(HexInt? val) => val?.ToString();
  private static HexInt? StringToHexInt(string? str) => String.IsNullOrEmpty(str) ? (HexInt?)null : HexInt.Parse(str!);

  private static string? HexLongObjectToString(object? val) => HexLongToString((HexLong?)val);
  private static object? StringToHexLongObject(string? str) => StringToHexLong(str);
  private static string? HexLongToString(HexLong? val) => val?.ToString();
  private static HexLong? StringToHexLong(string? str) => String.IsNullOrEmpty(str) ? (HexLong?)null : HexLong.Parse(str!);
  
  private static string? HexPercentObjectToString(object? val) => HexPercentToString((HexPercent?)val);
  private static object? StringToHexPercentObject(string? str) => StringToHexPercent(str);
  private static string? HexPercentToString(HexPercent? val) => val?.ToString();
  private static HexPercent? StringToHexPercent(string? str) => String.IsNullOrEmpty(str) ? (HexPercent?)null : HexPercent.Parse(str!);

  private static string? PercentObjectToString(object? val) => PercentToString((Percent?)val);
  private static object? StringToPercentObject(string? str) => StringToPercent(str);
  private static string? PercentToString(Percent? val) => val?.ToString();
  private static Percent? StringToPercent(string? str) => String.IsNullOrEmpty(str) ? (Percent?)null : Percent.Parse(str!);

  private static string? PercentageObjectToString(object? val) => PercentageToString((Percentage?)val);
  private static object? StringToPercentageObject(string? str) => StringToPercentage(str);
  private static string? PercentageToString(Percentage? val) => val?.ToString();
  private static Percentage? StringToPercentage(string? str) => String.IsNullOrEmpty(str) ? (Percentage?)null : Percentage.Parse(str!);

  private static string? DegreesObjectToString(object? val) => DegreesToString((Degrees?)val);
  private static object? StringToDegreesObject(string? str) => StringToDegrees(str);
  private static string? DegreesToString(Degrees? val) => val?.ToString();
  private static Degrees? StringToDegrees(string? str) => String.IsNullOrEmpty(str) ? (Degrees?)null : Degrees.Parse(str!);

  private static string? StringListObjectToString(object? val) => StringListToString((StringList?)val);
  private static object? StringToStringListObject(string? str) => StringToStringList(str);
  private static string? StringListToString(StringList? val) => val?.ToString();
  private static StringList? StringToStringList(string? str) => String.IsNullOrEmpty(str) ? (StringList?)null : StringList.Parse(str!);

}