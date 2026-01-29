namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for TSBoolean values to/from Open XML.
/// </summary>
public static class TSBooleanConverter
{
  private static readonly ConversionMethodInfo[] supportedTypes =
  [
    new ConversionMethodInfo(typeof(DX.TrueFalseBlankValue), nameof(ConvertFromTrueFalseBlankValue), nameof(ConvertToTrueFalseBlankValue)),
    new ConversionMethodInfo(typeof(string), nameof(TSBooleanFromString), nameof(TSBooleanToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  static TSBooleanConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(TSBooleanConverter), typeof(TSBoolean), supportedTypes, ConversionToMap, ConversionFromMap);
  }

  #region TrueFalseOnlyValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified TrueFalseBlankValue element.
  /// </summary>
  /// <param name="value">The TrueFalseBlankValue element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static TSBoolean ConvertFromTrueFalseBlankValue(DX.TrueFalseBlankValue value)
  {
    if (!value.HasValue) return TSBoolean.Blank;

    return DX.TrueFalseBlankValue.ToBoolean(value) ? TSBoolean.True : TSBoolean.False;
  }

  /// <summary>
  /// Creates an TrueFalseBlankValue element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>TrueFalseBlankValue.On if true, TrueFalseBlankValue.Off if false, otherwise null.</returns>
  public static DX.TrueFalseBlankValue? ConvertToTrueFalseBlankValue(TSBoolean value)
  {
    if (value== TSBoolean.Blank)
      return new DX.TrueFalseBlankValue();
    return DX.TrueFalseBlankValue.FromBoolean(value == TSBoolean.True);
  }

  #endregion

  #region string conversion.

  /// <summary>
  /// Converts the specified string representation of a logical value to its nullable Boolean equivalent.
  /// </summary>
  /// <remarks>If <paramref name="value"/> is <see langword="null"/>, the method returns <see langword="true"/>.
  /// Any other input that does not match the accepted values results in <see langword="null"/>.</remarks>
  /// <param name="value">The string to convert. Accepts "true", "false", "1", or "0" (case-insensitive).</param>
  /// <returns>A nullable Boolean value: <see langword="true"/> if <paramref name="value"/> is "true" or "1"; <see
  /// langword="false"/> if <paramref name="value"/> is "false" or "0"; otherwise, Blank.</returns>
  public static TSBoolean TSBooleanFromString(string? value)
  {
    if (value == null)
      return TSBoolean.Blank;

    value = value.ToLower();

    if (value == "true" || value == "1")
      return TSBoolean.True;
    if (value == "false" || value == "0")
      return TSBoolean.False;

    return TSBoolean.Blank;
  }

  /// <summary>
  /// Converts the specified <see cref="TSBoolean"/> value to its string representation.
  /// </summary>
  /// <param name="value">The <see cref="TSBoolean"/> value to convert.</param>
  /// <returns>A string that represents the specified <see cref="TSBoolean"/> value: "true" if the value is <see
  /// cref="TSBoolean.True"/>; "false" if the value is <see cref="TSBoolean.False"/>; otherwise, "blank".</returns>
  public static string TSBooleanToString(TSBoolean value)
  {
    if (value == TSBoolean.True)
      return "true";
    if (value == TSBoolean.False)
      return "false";
    return "blank";
  }

  #endregion
  #region Generic OpenXml three-state boolean converter

  /// <summary>
  /// Converts a boolean value to an OpenXml value or element of the specified type.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the OpenXml element to create.</param>
  /// <returns>An OpenXml element representing the TSBoolean value.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static object? ConvertToOpenXml(TSBoolean value, Type targetType)
  {
    if (ConversionToMap.TryGetValue((typeof(TSBoolean), targetType), out var conversionFunc))
    {
      return conversionFunc(value, targetType);
    }

    throw new NotSupportedException($"Conversion from TSBoolean to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an OpenXml value or element to a TSBoolean value.
  /// </summary>
  /// <param name="value">The OpenXml value or element to convert.</param>
  /// <returns>The boolean value represented by the element.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static TSBoolean ConvertFromOpenXml(object value)
  {
    var sourceType = value.GetType();
    if (ConversionFromMap.TryGetValue((sourceType, typeof(TSBoolean)), out var conversionFunc))
    {
      return (TSBoolean)conversionFunc(value)!;
    }

    throw new NotSupportedException($"Conversion from type {sourceType} to TSBoolean is not supported.");
  }

  #endregion
}