
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
    //DX.HexBinaryValue
    if (value == null) return null;
    if (value is DX.HexBinaryValue hexBinaryValue && targetType == typeof(HexInt))
      return new HexInt(hexBinaryValue.Value!);
    if (TryImplicitConvert(value, targetType, out var result))
      return result;

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

    #region SByte Conversion
    if (value is SByte sByteValue)
    {
      if (targetType == typeof(string))
        return sByteValue.ToString();
      return SByteOpenXmlConverter.ConvertToOpenXml(sByteValue, targetType);
    }
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
    if (value is Int32 int32Value)
    {
      if (targetType == typeof(string))
        return int32Value.ToString();
      return Int32OpenXmlConverter.ConvertToOpenXml(int32Value, targetType);
    }
    if (targetType == typeof(Int32))
    {
      if (value is string int32Str)
        return Int32.Parse(int32Str);
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

    if (value is DX.OpenXmlElement openXmlElement)
    {
      return OpenXmlConverter.ConvertFromOpenXml(openXmlElement, targetType);
    }

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
