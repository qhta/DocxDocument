namespace DocxEditor;

/// <summary>
/// Converts HexBinary values to double and back for data binding scenarios in WPF.
/// </summary>
public class HexBinaryValueConverter : IValueConverter
{
  /// <summary>
  /// Converts the specified value to its string representation using the specified target type and culture information.
  /// </summary>
  /// <remarks>This method returns null if the input value is null. The conversion is performed by calling the
  /// value's ToString method, and does not perform any type-specific formatting beyond what ToString
  /// provides.</remarks>
  /// <param name="value">The value to convert. If null, the method returns null.</param>
  /// <param name="targetType">The type to convert the value to. If a nullable type is specified, its underlying type is used.</param>
  /// <param name="parameter">An optional parameter that can be used to provide additional information for the conversion. This parameter is not
  /// used in the default implementation.</param>
  /// <param name="culture">The culture information to use in the conversion process.</param>
  /// <returns>A string representation of the value if the conversion is successful; otherwise, null if the input value is null.</returns>
  public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    if (value == null)
      return null;

    return value.ToString();
  }

  /// <summary>
  /// Converts a value that represents a hexadecimal string back to its corresponding strongly typed object, such as
  /// HexBinary, HexChar, HexInt, or HexLong.
  /// </summary>
  /// <remarks>If the input string is empty or contains only whitespace, the method returns Binding.DoNothing.
  /// The method also returns Binding.DoNothing if the input string does not meet the length requirements for the target
  /// type.</remarks>
  /// <param name="value">The value to convert, expected to be a string containing a hexadecimal representation.</param>
  /// <param name="targetType">The type to convert the value to. This can be HexBinary, HexChar, HexInt, HexLong, or a nullable version of these
  /// types.</param>
  /// <param name="parameter">An optional parameter that can specify the target type, which may override the targetType argument.</param>
  /// <param name="culture">The culture information to use in the conversion. This parameter is not used.</param>
  /// <returns>An object representing the converted value of the specified target type, or Binding.DoNothing if the conversion
  /// cannot be performed. Returns null if the input value is null.</returns>
  /// <exception cref="NotImplementedException">Thrown if the specified target type is not supported by the converter.</exception>
  public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    if (value == null)
      return null;

    if (value is string str)
    {
      var normalized = str.Replace(" ", string.Empty);
      if (string.IsNullOrEmpty(normalized))
        return Binding.DoNothing;

      targetType = (parameter as Type)?.GetNotNullableType() ?? Nullable.GetUnderlyingType(targetType) ?? targetType;
      if (targetType == typeof(HexBinary))
      {
        if (normalized.Length % 2 != 0)
          return Binding.DoNothing;

        return new HexBinary(normalized);
      }
      if (targetType == typeof(HexChar))
      {
        if (normalized.Length > 4)
          return Binding.DoNothing;

        return new HexChar(normalized);
      }
      if (targetType == typeof(HexInt))
      {
        if (normalized.Length > 8)
          return Binding.DoNothing;
        return new HexInt(normalized);
      }
      if (targetType == typeof(HexLong))
      {
        if (normalized.Length > 16)
          return Binding.DoNothing;

        return new HexLong(normalized);
      }

    }
    throw new NotImplementedException();
  }
}
