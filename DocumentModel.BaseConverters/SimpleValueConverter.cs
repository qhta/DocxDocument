
using DocumentFormat.OpenXml.Office2019.Excel.RichData;

namespace DocumentModel.OpenXml;


/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{
  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ChangeType(object? value, Type targetType)
  {
    if (value == null)
    {
      if (targetType==typeof(string))
        return string.Empty;
      return null;
    }

    var sourceType = value.GetType();

    if (targetType == sourceType)
      return value;

    if (targetType == typeof(string))
    {
      if (value is Guid guid)
        return guid.ToString("B");
      return value.ToString();
    }

    #region Boolean Conversion
    if (value is Boolean booleanValue && BooleanOpenXmlConverter.SupportsType(targetType))
        return BooleanOpenXmlConverter.ConvertToOpenXml(booleanValue, targetType);
    
    if (targetType == typeof(Boolean))
    {
      if (value is string booleanStr)
        return Boolean.Parse(booleanStr);
      if (BooleanOpenXmlConverter.SupportsType(sourceType))
        return BooleanOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Enum Conversion
    if (value.GetType().IsEnum)
    {
      if (targetType.Name.StartsWith("EnumValue`"))
        return EnumOpenXmlConverter.CreateOpenXmlElement((Enum?)value, targetType);
      return Enum.ToObject(targetType, value);
    }
    if (targetType.IsEnum)
    {
      if (value.GetType().Name.StartsWith("EnumValue`"))
        return EnumOpenXmlConverter.CreateOpenXmlElement((Enum?)value, targetType);

      var str = value.ToString()!;
      return Enum.Parse(targetType, str, true);
    }
    #endregion

    #region SByte Conversion && 
    if (value is SByte sByteValue && SByteOpenXmlConverter.SupportsType(targetType))
      return SByteOpenXmlConverter.ConvertToOpenXml(sByteValue, targetType);

    if (targetType == typeof(SByte))
    {
      if (value is string sByteStr)
        return SByte.Parse(sByteStr);
      return SByteOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Int16 Conversion
    if (value is Int16 int16Value)
    {
      if (targetType == typeof(string))
        return int16Value.ToString();
      return Int16OpenXmlConverter.ConvertToOpenXml(int16Value, targetType);
    }
    if (targetType == typeof(Int16))
    {
      if (value is string int16Str)
        return Int16.Parse(int16Str);
      return Int16OpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Int32 Conversion
    if (value is Int32 int32Value && Int32OpenXmlConverter.SupportsType(targetType))
        return Int32OpenXmlConverter.ConvertToOpenXml(int32Value, targetType);
    if (targetType == typeof(Int32))
    {
      if (value is string int32Str)
        return Int32.Parse(int32Str);
      if (Int32OpenXmlConverter.SupportsType(sourceType))
        return Int32OpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Int64 Conversion
    if (value is Int64 int64Value)
    {
      if (targetType == typeof(string))
        return int64Value.ToString();
      return Int64OpenXmlConverter.ConvertToOpenXml(int64Value, targetType);
    }
    if (targetType == typeof(Int64))
    {
      if (value is string int64Str)
        return Int64.Parse(int64Str);
      return Int64OpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion


    #region Byte Conversion
    if (value is Byte byteValue)
    {
      if (targetType == typeof(string))
        return byteValue.ToString();
      return ByteOpenXmlConverter.ConvertToOpenXml(byteValue, targetType);
    }
    if (targetType == typeof(Byte))
    {
      if (value is string byteStr)
        return Byte.Parse(byteStr);
      return ByteOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region UInt16 Conversion
    if (value is UInt16 uint16Value)
    {
      if (targetType == typeof(string))
        return uint16Value.ToString();
      return UInt16OpenXmlConverter.ConvertToOpenXml(uint16Value, targetType);
    }
    if (targetType == typeof(UInt16))
    {
      if (value is string uint16Str)
        return UInt16.Parse(uint16Str);
      return UInt16OpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region UInt32 Conversion
    if (value is UInt32 uint32Value)
    {
      if (targetType == typeof(string))
        return uint32Value.ToString();
      return UInt32OpenXmlConverter.ConvertToOpenXml(uint32Value, targetType);
    }
    if (targetType == typeof(UInt32))
    {
      if (value is string uint32Str)
        return UInt32.Parse(uint32Str);
      return UInt32OpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region UInt64 Conversion
    if (value is UInt64 uint64Value)
    {
      if (targetType == typeof(string))
        return uint64Value.ToString();
      return UInt64OpenXmlConverter.ConvertToOpenXml(uint64Value, targetType);
    }
    if (targetType == typeof(UInt64))
    {
      if (value is string uint64Str)
        return UInt64.Parse(uint64Str);
      return UInt64OpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Guid Conversion
    if (value is Guid guidValue)
    {
      if (targetType == typeof(string))
        return guidValue.ToString("B");
      return GuidOpenXmlConverter.ConvertToOpenXml(guidValue, targetType);
    }
    if (targetType == typeof(Guid))
    {
      if (value is string guidStr)
        return Guid.Parse(guidStr);
      return GuidOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region HexInt Conversion
    if (value is HexInt HexIntValue)
    {
      if (targetType == typeof(string))
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return HexIntValue.ToString();
      return HexIntOpenXmlConverter.ConvertToOpenXml(HexIntValue, targetType);
    }
    if (targetType == typeof(HexInt))
    {
      if (value is string HexIntStr)
        return new HexInt(HexIntStr);
      return HexIntOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion


    #region HexChar Conversion
    if (value is HexChar HexCharValue)
    {
      if (targetType == typeof(string))
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return HexCharValue.ToString();
      return HexCharOpenXmlConverter.ConvertToOpenXml(HexCharValue, targetType);
    }
    if (targetType == typeof(HexChar))
    {
      if (value is string HexCharStr)
        return new HexChar(HexCharStr);
      return HexCharOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Twips Conversion
    if (value is Twips TwipsValue)
    {
      if (targetType == typeof(string))
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return TwipsValue.ToString();
      return TwipsOpenXmlConverter.ConvertToOpenXml(TwipsValue, targetType);
    }
    if (targetType == typeof(Twips))
    {
      if (value is string TwipsStr)
        return new Twips(TwipsStr);
      return TwipsOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region Base64Binary Conversion
    if (value is Base64Binary base64binaryValue)
    {
      if (targetType == typeof(string))
        return base64binaryValue.ToString();
      return Base64BinaryOpenXmlConverter.ConvertToOpenXml(base64binaryValue, targetType);
    }
    if (targetType == typeof(Base64Binary))
    {
      if (value is string base64binaryStr)
        return new Base64Binary(base64binaryStr);
      return Base64BinaryOpenXmlConverter.ConvertFromOpenXml(value);
    }
    #endregion

    #region String Conversion
    if (value is String stringValue)
    {
      if (targetType == typeof(string))
        return stringValue;
      if (targetType == typeof(Uri))
      {
        if (string.IsNullOrWhiteSpace(stringValue))
          return null;
        if (Uri.TryCreate(stringValue, UriKind.RelativeOrAbsolute, out var uri))
          return uri;
        throw new UriFormatException($"Invalid URI value '{stringValue}'.");
      }
      if (StringOpenXmlConverter.SupportsType(targetType))
        return StringOpenXmlConverter.ConvertToOpenXml(stringValue, targetType);
    }
    if (targetType == typeof(String))
    {
      if (value is string stringVal)
        return stringVal;
      if (value is Uri uriVal)
        return uriVal.ToString();
      if (StringOpenXmlConverter.SupportsType(sourceType))
        return StringOpenXmlConverter.ConvertFromOpenXml(value);

      return value.ToString();
    }
    #endregion

    #region StringList Conversion
    if (value is StringList stringList)
    {
      if (targetType == typeof(string))
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return stringList.ToString();
      if (StringListOpenXmlConverter.SupportsType(targetType))
        return StringListOpenXmlConverter.ConvertToOpenXml(stringList, targetType);
    }
    if (targetType == typeof(String))
    {
      if (value is string stringVal)
        return stringVal;
      if (StringListOpenXmlConverter.SupportsType(sourceType))
        return StringListOpenXmlConverter.ConvertFromOpenXml(value);

      return value.ToString();
    }
    #endregion
    if (value is DX.OpenXmlElement openXmlElement)
    {
      return OpenXmlConverter.ConvertFromOpenXml(openXmlElement, targetType);
    }

    if (TryImplicitConvert(value, targetType, out var result))
      return result;
    return Convert.ChangeType(value, targetType);

  }

  /// <summary>
  /// Attempts to convert a value to the specified target type using an implicit conversion operator, if available.
  /// </summary>
  /// <param name="source">The source value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="result">The converted value if the conversion succeeds; otherwise, null.</param>
  /// <returns>True if an implicit conversion was performed; otherwise, false.</returns>
  public static bool TryImplicitConvert(object? source, Type targetType, out object? result)
  {
    result = null;
    if (source == null) return true;

    var sourceType = source.GetType();
    var methods = sourceType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Concat(targetType.GetMethods(BindingFlags.Public | BindingFlags.Static)).ToArray();

    var op = methods.FirstOrDefault(m =>
      m.Name == "op_Implicit" &&
      m.ReturnType == targetType &&
      m.GetParameters() is [{ ParameterType: var p }] &&
      p.IsAssignableFrom(sourceType));

    if (op == null) return false;

    result = op.Invoke(null, [source]);
    return true;
  }
}
