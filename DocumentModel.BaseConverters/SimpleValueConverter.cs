namespace DocumentModel.OpenXml;

/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{
  private static readonly Dictionary<(Type Source, Type Target), Func<object, Type, object?>> ConversionToMap = new();
  private static readonly Dictionary<(Type Source, Type Target), Func<object, object?>> ConversionFromMap = new();

  static SimpleValueConverter()
  {
    ConversionToMap = ConversionToMap.Concat(BooleanConverter.ConversionToMap).ToDictionary();
    ConversionFromMap = ConversionFromMap.Concat(BooleanConverter.ConversionFromMap).ToDictionary();
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertTo(object? value, Type targetType)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    Debug.WriteLine($"Start converting from {sourceType.FullName} to {targetType.FullName}");

    var targetSubType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    while (targetSubType != null)
    {
      Debug.WriteLine($"Search for conversion from {sourceType.FullName} to {targetSubType.FullName}");

      if (ConversionToMap.TryGetValue((sourceType, targetSubType), out var conversionFunc))
      {
        Debug.WriteLine($"Converting from {sourceType.FullName} to {targetSubType.FullName}");
        return conversionFunc(value, targetType);
      }

      targetSubType = targetSubType.BaseType;
    }
    if (TryImplicitConvert(value, targetType, out var result))
      return result;

    return Convert.ChangeType(value, targetType);
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertFrom(object? value, Type targetType)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    Debug.WriteLine($"Start converting from {sourceType.FullName} to {targetType.FullName}");

    var sourceSubType = Nullable.GetUnderlyingType(sourceType) ?? sourceType;
    while (sourceSubType != null)
    {
      Debug.WriteLine($"Search for conversion from {sourceSubType.FullName} to {targetType.FullName}");

      if (ConversionFromMap.TryGetValue((sourceSubType, targetType), out var conversionFunc))
      {
        Debug.WriteLine($"Converting from {sourceType.FullName} to {sourceSubType.FullName}");
        return conversionFunc(value);
      }

      sourceSubType = sourceSubType.BaseType;
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
    var methods = sourceType.GetMethods(BindingFlags.Public | BindingFlags.Static).Concat(targetType.GetMethods(BindingFlags.Public | BindingFlags.Static)).ToArray();
    var op = methods.FirstOrDefault(m => m.Name == "op_Implicit" && m.ReturnType == targetType && m.GetParameters() is [{ ParameterType: var p }] && p.IsAssignableFrom(sourceType));
    if (op == null) return false;

    result = op.Invoke(null, [source]);
    return true;
  }
}