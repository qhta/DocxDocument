using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{
  private static readonly ConversionToMap ConversionToMap = new();
  private static readonly ConversionFromMap ConversionFromMap = new();

  static SimpleValueConverter()
  {
    ConversionToMap.Append(BooleanConverter.ConversionToMap);
    ConversionToMap.Append(TSBooleanConverter.ConversionToMap);
    ConversionToMap.Append(StringConverter.ConversionToMap);
    ConversionToMap.Append(Int32Converter.ConversionToMap);
    ConversionFromMap.Append(BooleanConverter.ConversionFromMap);
    ConversionFromMap.Append(TSBooleanConverter.ConversionFromMap);
    ConversionFromMap.Append(StringConverter.ConversionFromMap);
    ConversionFromMap.Append(Int32Converter.ConversionFromMap);
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertTo(object? value, Type targetType)
  {
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
    return (object?)ConverterBase.ConvertFrom(value, targetType, ConversionFromMap);
  }

}