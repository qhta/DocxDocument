using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{

  private static readonly ConversionToMap ConversionToMap = new();
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
    ConversionToMap.Append(DecimalConverter.ConversionToMap);
    ConversionToMap.Append(GuidConverter.ConversionToMap);
    ConversionToMap.Append(DateTimeConverter.ConversionToMap);
    ConversionToMap.Append(HexLongConverter.ConversionToMap);

    ConversionFromMap.Append(BooleanConverter.ConversionFromMap);
    ConversionFromMap.Append(TSBooleanConverter.ConversionFromMap);
    ConversionFromMap.Append(StringConverter.ConversionFromMap);
    ConversionFromMap.Append(SByteConverter.ConversionFromMap);
    ConversionFromMap.Append(Int32Converter.ConversionFromMap);
    ConversionFromMap.Append(Int64Converter.ConversionFromMap);
    ConversionFromMap.Append(UInt16Converter.ConversionFromMap);
    ConversionFromMap.Append(UInt32Converter.ConversionFromMap);
    ConversionFromMap.Append(UInt64Converter.ConversionFromMap);
    ConversionFromMap.Append(DecimalConverter.ConversionFromMap);
    ConversionFromMap.Append(GuidConverter.ConversionFromMap);
    ConversionFromMap.Append(DateTimeConverter.ConversionFromMap);
    ConversionFromMap.Append(HexIntConverter.ConversionFromMap);
    ConversionFromMap.Append(HexLongConverter.ConversionFromMap);

  }

  private static readonly Dictionary<Type, Type> BaseTypeMappings = new()
  {
    [typeof(Twips)] = typeof(Int32),
    [typeof(EMU)] = typeof(Int64),
    [typeof(HalfPoints)] = typeof(Int32),
  };


  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertTo(object? value, Type targetType)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
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
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertFrom(object? value, Type targetType)
  {
    if (value == null)
      return null;

    if (BaseTypeMappings.TryGetValue(targetType, out var newSourceType))
    {
      if (ConverterBase.TryImplicitConvertFrom(value, targetType, out var newValue))
      {
        return newValue;
      }
    }
    return ConverterBase.ConvertFrom(value, targetType, ConversionFromMap);
  }
}