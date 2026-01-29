namespace DocumentModel.OpenXml;

/// <summary>
/// Translates between the tri-state <see cref="TSBoolean"/> model value and supported Open XML representations.
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

  static TSBooleanConverter() { ConverterBase.RegisterConversionMethods(typeof(TSBooleanConverter), typeof(TSBoolean), supportedTypes, ConversionToMap, ConversionFromMap); }

  #region TrueFalseOnlyValue conversion.

  /// <summary>
  /// Converts a <see cref="DX.TrueFalseBlankValue"/> into its <see cref="TSBoolean"/> counterpart, preserving the blank state.
  /// </summary>
  /// <param name="value">The Open XML three-state value to interpret.</param>
  /// <returns>The equivalent <see cref="TSBoolean"/> value.</returns>
  public static TSBoolean ConvertFromTrueFalseBlankValue(DX.TrueFalseBlankValue value)
  {
    if (!value.HasValue) return TSBoolean.Blank;

    return DX.TrueFalseBlankValue.ToBoolean(value) ? TSBoolean.True : TSBoolean.False;
  }

  /// <summary>
  /// Creates a <see cref="DX.TrueFalseBlankValue"/> that mirrors the supplied <see cref="TSBoolean"/> state.
  /// </summary>
  /// <param name="value">The tri-state value to serialize.</param>
  /// <returns>A new <see cref="DX.TrueFalseBlankValue"/> instance representing the same logical state.</returns>
  public static DX.TrueFalseBlankValue? ConvertToTrueFalseBlankValue(TSBoolean value)
  {
    if (value == TSBoolean.Blank)
      return new DX.TrueFalseBlankValue();

    return DX.TrueFalseBlankValue.FromBoolean(value == TSBoolean.True);
  }

  #endregion

  #region string conversion.

  /// <summary>
  /// Parses textual representations of a tri-state boolean (true/false/blank) into <see cref="TSBoolean"/>.
  /// </summary>
  /// <param name="value">The string to interpret. Null or unrecognized text yields <see cref="TSBoolean.Blank"/>.</param>
  /// <returns>The parsed <see cref="TSBoolean"/> value.</returns>
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
  /// Serializes a <see cref="TSBoolean"/> into a human-readable token.
  /// </summary>
  /// <param name="value">The tri-state value to serialize.</param>
  /// <returns>"true", "false", or "blank" according to <paramref name="value"/>.</returns>
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
  /// Converts the specified <see cref="TSBoolean"/> value to the specified target type, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The tri-state source value.</param>
  /// <param name="targetType">The desired Open XML target type.</param>
  /// <returns>The converted object suitable for the specified target type.</returns>
  /// <exception cref="NotSupportedException">Thrown when no converter exists for <paramref name="targetType"/>.</exception>
  public static object? ConvertFrom(TSBoolean? value, Type targetType)
  {
    if (value == null) return null;

    if (ConversionToMap.TryGetValue((typeof(TSBoolean), targetType), out var conversionFunc))
    {
      return conversionFunc(value, targetType);
    }
    throw new NotSupportedException($"Conversion from TSBoolean to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts the specified value to a <see cref="TSBoolean"/> instance, if a supported conversion exists. 
  /// </summary>
  /// <param name="value">The value to convert to <see cref="TSBoolean"/>. Can be <see langword="null"/>.</param>
  /// <returns>A <see cref="TSBoolean"/> representation of the specified value, or <see langword="null"/> if <paramref
  /// name="value"/> is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="TSBoolean"/> is not supported.</exception>
  public static TSBoolean? ConvertTo(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (ConversionFromMap.TryGetValue((sourceType, typeof(TSBoolean)), out var conversionFunc))
    {
      return (TSBoolean)conversionFunc(value)!;
    }
    throw new NotSupportedException($"Conversion from type {sourceType} to TSBoolean is not supported.");
  }

  #endregion
}