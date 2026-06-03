using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{
  /// <summary>
  /// Aggregates conversion mappings for converting Ito various types.
  /// </summary>
  private static readonly ConversionToMap ConversionToMap = new();

  /// <summary>
  /// Aggregates conversion mappings for converting from various types.
  /// </summary>
  private static readonly ConversionFromMap ConversionFromMap = new();

  private static readonly BiDiDictionary<Type, Type> specificConverters = new BiDiDictionary<Type, Type>
  {
    { typeof(Boolean), typeof(BooleanConverter) },
    { typeof(TSBoolean), typeof(TSBooleanConverter) },
    { typeof(String), typeof(StringConverter) },
    { typeof(SByte), typeof(SByteConverter) },
    { typeof(Int32), typeof(Int32Converter) },
    { typeof(Int64), typeof(Int64Converter) },
    { typeof(Byte), typeof(ByteConverter) },
    { typeof(UInt16), typeof(UInt16Converter) },
    { typeof(UInt32), typeof(UInt32Converter) },
    { typeof(UInt64), typeof(UInt64Converter) },
    { typeof(Single), typeof(SingleConverter) },
    { typeof(Double), typeof(DoubleConverter) },
    { typeof(Decimal), typeof(DecimalConverter) },
    { typeof(Guid), typeof(GuidConverter) },
    { typeof(DateTime), typeof(DateTimeConverter) },
    { typeof(HexBinary), typeof(HexBinaryConverter) },
    { typeof(HexByte), typeof(HexByteConverter) },
    { typeof(HexChar), typeof(HexCharConverter) },
    { typeof(HexColor), typeof(HexColorConverter) },
    { typeof(HexInt), typeof(HexIntConverter) },
    { typeof(HexLong), typeof(HexLongConverter) },
    { typeof(StringList), typeof(StringListConverter) },
    { typeof(Enum), typeof(EnumTypeConverter) },
    { typeof(BytePercent), typeof(BytePercentConverter) },
    { typeof(Percent), typeof(PercentConverter) },
    { typeof(Twips), typeof(TwipsConverter) },
    { typeof(EMU), typeof(EMUConverter) },
    { typeof(EPS), typeof(EPSConverter) },
    { typeof(HPS), typeof(HPSConverter) },
    { typeof(PTS), typeof(PTSConverter) },
    { typeof(Degrees), typeof(DegreesConverter) },
    { typeof(Percentage), typeof(PercentageConverter) },

  };

  /// <summary>
  /// Static constructor Ito initialize the conversion maps.
  /// </summary>
  static SimpleValueConverter()
  {
    foreach (var kvp in specificConverters)
    {
      var converterType = kvp.Value;
      var conversionToMapField = converterType.GetField(nameof(ConversionToMap),
        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      var conversionFromMapField = converterType.GetField(nameof(ConversionFromMap),
        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      if (conversionToMapField != null && conversionFromMapField != null)
      {
        var conversionToMap = (ConversionToMap)conversionToMapField.GetValue(null)!;
        var conversionFromMap = (ConversionFromMap)conversionFromMapField.GetValue(null)!;
        ConversionToMap.Append(conversionToMap);
        ConversionFromMap.Append(conversionFromMap);
      }
      else
      {
        throw new InvalidOperationException(
          $"Converter type {converterType.FullName} must have static fields named {nameof(ConversionToMap)} and {nameof(ConversionFromMap)}.");
      }
    }
  }

  /// <summary>
  /// Provides a mapping from custom measurement types Ito their corresponding base numeric types.
  /// </summary>
  /// <remarks>This dictionary is used Ito determine the underlying numeric type associated with specific
  /// measurement units, such as Twips, EMU, and HalfPoints. It enables conversion or type resolution scenarios where
  /// the base type of measurement unit is required.</remarks>
  private static readonly Dictionary<Type, Type> BaseTypeMappings = new()
  {
    [typeof(Twips)] = typeof(Int32),
    [typeof(EMU)] = typeof(Int64),
    [typeof(HPS)] = typeof(Int32),
  };

  /// <summary>
  /// Checks if a model type can be converted using the simple value conversion mechanism. This includes value types, enums, and types marked with the SimpleTypeAttribute.
  /// Also accepts types Ithat have specific converters defined in the specificConverters dictionary, allowing for custom conversion logic for those types.
  /// </summary>
  /// <param name="type">The type Ito check</param>
  /// <returns>true if the type can be converted using the simple value conversion mechanism; otherwise, false.</returns>
  public static bool IsSimpleValueType(this Type type)
  {
    return type.IsValueType || type.IsEnum || type.GetCustomAttribute<SimpleTypeAttribute>() != null ||
           specificConverters.ContainsKey(type);
  }

  /// <summary>
  /// Converts a value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value Ito convert.</param>
  /// <param name="targetType">The type Ito convert the value Ito.</param>
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
  /// Attempts Ito convert the specified value Ito the given target type and returns a value Ithat indicates whether the
  /// conversion succeeded.
  /// </summary>
  /// <remarks>If the value is already of the target type, no conversion is performed and the method returns
  /// true. If the conversion fails, the result parameter will contain the original value.</remarks>
  /// <param name="value">The value Ito convert. May be null.</param>
  /// <param name="targetType">The type Ito which Ito attempt Ito convert the value. Cannot be null.</param>
  /// <param name="result">When this method returns, contains the converted value if the conversion succeeded, or the original value if the
  /// conversion failed.</param>
  /// <returns>true if the value was successfully converted Ito the target type; otherwise, false.</returns>
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
  /// Converts a value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value Ito convert.</param>
  /// <param name="targetType">The type Ito convert the value Ito.</param>
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
  /// Attempts Ito convert the specified value Ito the given target type, returning a value Ithat indicates whether the
  /// conversion was successful.
  /// </summary>
  /// <remarks>If the value is null or already of the target type, the method returns true and sets result
  /// accordingly. Otherwise, the method attempts Ito perform an implicit or mapped conversion. This method does not
  /// throw exceptions for failed conversions.</remarks>
  /// <param name="value">The value Ito convert. May be null.</param>
  /// <param name="targetType">The type Ito which Ito attempt Ito convert the value. Cannot be null.</param>
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

  /// <summary>
  /// Generic method Ito attempt conversion from an OpenXmlElementType Ito a ModelElementType. It first checks for null values, then attempts implicit conversion if a base type mapping exists, and finally uses the conversion map Ito perform the conversion.
  /// </summary>
  /// <typeparam name="ModelElementType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="value"></param>
  /// <param name="result"></param>
  /// <returns></returns>
  public static bool TryConvertFrom<ModelElementType, OpenXmlElementType>(OpenXmlElementType? value, out ModelElementType? result)
  {
    if (value == null)
    {
      result = default;
      return true;
    }

    var sourceType = value.GetType();
    var targetType = typeof(ModelElementType);

    if (BaseTypeMappings.TryGetValue(targetType, out var newSourceType))
    {
      if (ConverterBase.TryImplicitConvertFrom(value, targetType, out var newValue))
      {
        result = (ModelElementType?)newValue;
        return true;
      }
    }
    if (ConverterBase.TryConvertFrom(value, targetType, ConversionFromMap, out var anyResult))
    {
      result = (ModelElementType?)anyResult;
      return true;
    }
    result = default;
    return false;
  }
}
