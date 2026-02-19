using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{
  /// <summary>
  /// Aggregates conversion mappings for converting to various types.
  /// </summary>
  private static readonly ConversionToMap ConversionToMap = new();
  /// <summary>
  /// Aggregates conversion mappings for converting from various types.
  /// </summary>
  private static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Static constructor to initialize the conversion maps.
  /// </summary>
  static SimpleValueConverter()
  {
    ConversionToMap.Append(BooleanConverter.ConversionToMap);
    ConversionToMap.Append(TSBooleanConverter.ConversionToMap);
    ConversionToMap.Append(StringConverter.ConversionToMap);
    ConversionToMap.Append(SByteConverter.ConversionToMap);
    ConversionToMap.Append(Int32Converter.ConversionToMap);
    ConversionToMap.Append(Int64Converter.ConversionToMap);
    ConversionToMap.Append(ByteConverter.ConversionToMap);
    ConversionToMap.Append(UInt16Converter.ConversionToMap);
    ConversionToMap.Append(UInt32Converter.ConversionToMap);
    ConversionToMap.Append(UInt64Converter.ConversionToMap);
    ConversionToMap.Append(SingleConverter.ConversionToMap);
    ConversionToMap.Append(DoubleConverter.ConversionToMap);
    ConversionToMap.Append(DecimalConverter.ConversionToMap);
    ConversionToMap.Append(GuidConverter.ConversionToMap);
    ConversionToMap.Append(DateTimeConverter.ConversionToMap);
    ConversionToMap.Append(HexLongConverter.ConversionToMap);
    ConversionToMap.Append(StringListConverter.ConversionToMap);
    ConversionToMap.Append(RgbConverter.ConversionToMap);
    ConversionToMap.Append(HexBinaryConverter.ConversionToMap);
    ConversionToMap.Append(EnumConverter.ConversionToMap);
    ConversionToMap.Append(BytePercentConverter.ConversionToMap);
    ConversionToMap.Append(PercentConverter.ConversionToMap);

    ConversionFromMap.Append(BooleanConverter.ConversionFromMap);
    ConversionFromMap.Append(TSBooleanConverter.ConversionFromMap);
    ConversionFromMap.Append(StringConverter.ConversionFromMap);
    ConversionFromMap.Append(SByteConverter.ConversionFromMap);
    ConversionFromMap.Append(Int32Converter.ConversionFromMap);
    ConversionFromMap.Append(Int64Converter.ConversionFromMap);
    ConversionFromMap.Append(UInt16Converter.ConversionFromMap);
    ConversionFromMap.Append(UInt32Converter.ConversionFromMap);
    ConversionFromMap.Append(UInt64Converter.ConversionFromMap);
    ConversionFromMap.Append(SingleConverter.ConversionFromMap);
    ConversionFromMap.Append(DoubleConverter.ConversionFromMap);
    ConversionFromMap.Append(DecimalConverter.ConversionFromMap);
    ConversionFromMap.Append(GuidConverter.ConversionFromMap);
    ConversionFromMap.Append(DateTimeConverter.ConversionFromMap);
    ConversionFromMap.Append(HexIntConverter.ConversionFromMap);
    ConversionFromMap.Append(StringListConverter.ConversionFromMap);
    ConversionFromMap.Append(RgbConverter.ConversionFromMap);
    ConversionFromMap.Append(HexBinaryConverter.ConversionFromMap);
    ConversionFromMap.Append(EnumConverter.ConversionFromMap);
    ConversionFromMap.Append(PercentConverter.ConversionFromMap);

  }

  /// <summary>
  /// Provides a mapping from custom measurement types to their corresponding base numeric types.
  /// </summary>
  /// <remarks>This dictionary is used to determine the underlying numeric type associated with specific
  /// measurement units, such as Twips, EMU, and HalfPoints. It enables conversion or type resolution scenarios where
  /// the base type of measurement unit is required.</remarks>
  private static readonly Dictionary<Type, Type> BaseTypeMappings = new()
  {
    [typeof(Twips)] = typeof(Int32),
    [typeof(EMU)] = typeof(Int64),
    [typeof(HPS)] = typeof(Int32),
  };

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion cannot be performed.</exception>
  public static object? ConvertTo(object? value, Type targetType)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return value;

    if (BaseTypeMappings.TryGetValue(sourceType, out var newTargetType))
    {
      if (ConverterBase.TryImplicitConvertTo(value, newTargetType, out var newValue))
      {
        value = newValue;
        targetType = newTargetType;
      }
    }
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Attempts to convert the specified value to the given target type and returns a value that indicates whether the
  /// conversion succeeded.
  /// </summary>
  /// <remarks>If the value is already of the target type, no conversion is performed and the method returns
  /// true. If the conversion fails, the result parameter will contain the original value.</remarks>
  /// <param name="value">The value to convert. May be null.</param>
  /// <param name="targetType">The type to which to attempt to convert the value. Cannot be null.</param>
  /// <param name="result">When this method returns, contains the converted value if the conversion succeeded, or the original value if the
  /// conversion failed.</param>
  /// <returns>true if the value was successfully converted to the target type; otherwise, false.</returns>
  public static bool TryConvertTo(object? value, Type targetType, out object? result)
  {
    result = value;
    if (value == null)
      return true;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return true;

    if (ConverterBase.TryConvertTo(value, targetType, ConversionToMap, out result))
      return true;

    if (BaseTypeMappings.TryGetValue(sourceType, out var newTargetType))
    {
      if (ConverterBase.TryImplicitConvertTo(value, newTargetType, out var newValue))
      {
        value = newValue;
        targetType = newTargetType;
        if (ConverterBase.TryConvertTo(value, targetType, ConversionToMap, out result))
          return true;
      }
    }
    return false;
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion cannot be performed.</exception>
  public static object? ConvertFrom(object? value, Type targetType)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return value;

    if (BaseTypeMappings.TryGetValue(targetType, out var newSourceType))
    {
      if (ConverterBase.TryImplicitConvertFrom(value, targetType, out var newValue))
      {
        return newValue;
      }
    }
    return ConverterBase.ConvertFrom(value, targetType, ConversionFromMap);
  }

  /// <summary>
  /// Attempts to convert the specified value to the given target type, returning a value that indicates whether the
  /// conversion was successful.
  /// </summary>
  /// <remarks>If the value is null or already of the target type, the method returns true and sets result
  /// accordingly. Otherwise, the method attempts to perform an implicit or mapped conversion. This method does not
  /// throw exceptions for failed conversions.</remarks>
  /// <param name="value">The value to convert. May be null.</param>
  /// <param name="targetType">The type to which to attempt to convert the value. Cannot be null.</param>
  /// <param name="result">When this method returns, contains the converted value if the conversion succeeded, or the original value if it
  /// was null or already of the target type; otherwise, contains null. This parameter is passed uninitialized.</param>
  /// <returns>true if the conversion was successful or the value was null; otherwise, false.</returns>
  public static bool TryConvertFrom(object? value, Type targetType, out object? result)
  {
    result = value;
    if (value == null)
      return true;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return true;

    if (BaseTypeMappings.TryGetValue(targetType, out var newSourceType))
    {
      if (ConverterBase.TryImplicitConvertFrom(value, targetType, out var newValue))
      {
        result = newValue;
        return true;
      }
    }
    return ConverterBase.TryConvertFrom(value, targetType, ConversionFromMap, out result);
  }
}