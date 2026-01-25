namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Int32Value in Open XML.
/// </summary>
public static class Int32ValueConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.Int32Value),
    typeof(DX.Int64Value),
    typeof(DX.Int16Value),
    typeof(DX.SByteValue),
    typeof(DX.UInt32Value),
    typeof(DX.UInt64Value),
    typeof(DX.UInt16Value),
    typeof(DX.ByteValue),
    typeof(DX.StringValue)
  ];

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Int32.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Int32 value, or null if the element has no content.</returns>
  public static Int32? GetValue(this DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Int32 value.
  /// </summary>
  /// <param name="value">The Int32 value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? CreateInt32Value(this Int32? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a value to a specified target type.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the element has no content.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion is not supported.</exception>
  public static object? ConvertToOpenXml(Int32? value, Type targetType)
  {
    if (value == null)
      return null;
    if (targetType == typeof(SByte))
      return new DX.SByteValue((SByte)value);
    if (targetType == typeof(DX.Int16Value))
      return new DX.Int16Value((Int16)value);
    if (targetType == typeof(DX.Int32Value))
      return new DX.Int32Value(value);
    if (targetType == typeof(DX.IntegerValue))
      return new DX.IntegerValue(value);
    if (targetType == typeof(Byte))
      return new DX.ByteValue((Byte)value);
    if (targetType == typeof(DX.UInt16Value))
      return new DX.UInt16Value((UInt16)value);
    if (targetType == typeof(DX.UInt32Value))
      return new DX.UInt32Value((UInt32)value);
    if (targetType == typeof(DX.UInt64Value))
      return new DX.UInt64Value((UInt64)value);
    if (targetType == typeof(DX.StringValue))
      return new DX.StringValue(value.ToString());

    throw new InvalidOperationException($"Conversion to {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an Open XML value to a nullable 32-bit integer, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as a 32-bit integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int32Value,
  /// UInt32Value, UInt64Value, and StringValue. May be null.</param>
  /// <returns>A 32-bit integer representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Int32? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.SByteValue sbyteValue)
      return (int)sbyteValue.Value;
    if (value is DX.ByteValue byteValue)
      return (int)byteValue.Value;
    if (value is DX.Int16Value shortValue)
      return (int)shortValue.Value;
    if (value is DX.UInt16Value ushortValue)
      return (int)ushortValue.Value;
    if (value is DX.Int32Value intValue)
      return intValue.Value;
    if (value is DX.UInt32Value uintValue)
      return (int)uintValue.Value;
    if (value is DX.UInt64Value ulongValue)
      return (int)ulongValue.Value;
    if (value is DX.StringValue stringValue)
    {
      if (Int32.TryParse(stringValue.Value, out var result))
        return result;
      return null;
    }

    throw new InvalidOperationException($"Conversion from {sourceType} is not supported.");
  }

  #endregion
}