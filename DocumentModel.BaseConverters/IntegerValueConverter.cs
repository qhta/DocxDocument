namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for IntegerValue in Open XML.
/// </summary>
public static class IntegerValueConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.IntegerValue),
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

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to long.
  /// </summary>
  /// <param name="integerValue">The IntegerValue to convert.</param>
  /// <returns>The long value, or null if the element has no content.</returns>
  public static long? GetValue(this DX.IntegerValue? integerValue)
  {
    if (integerValue == null) return null;

    return integerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from a long value.
  /// </summary>
  /// <param name="value">The long value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ToIntegerValue(this long? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (long)value };
  }

  #endregion

  #region Generic OpenXml conversion methods

  public static object? ConvertToOpenXml(long? value, Type targetType)
  {
    if (value == null)
      return null;
    if (targetType == typeof(SByte))
      return new DX.SByteValue((SByte)value);
    if (targetType == typeof(DX.Int16Value))
      return new DX.Int16Value((Int16)value);
    if (targetType == typeof(DX.Int32Value))
      return new DX.Int32Value((Int32)value);
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

  public static long? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.SByteValue sbyteValue)
      return (long)sbyteValue.Value;
    if (value is DX.ByteValue byteValue)
      return (long)byteValue.Value;
    if (value is DX.Int16Value shortValue)
      return (long)shortValue.Value;
    if (value is DX.UInt16Value ushortValue)
      return (long)ushortValue.Value;
    if (value is DX.Int32Value intValue)
      return intValue.Value;
    if (value is DX.UInt32Value uintValue)
      return (long)uintValue.Value;
    if (value is DX.UInt64Value ulongValue)
      return (long)ulongValue.Value;
    if (value is DX.StringValue stringValue)
    {
      if (long.TryParse(stringValue.Value, out var result))
        return result;

      return null;
    }

    throw new InvalidOperationException($"Conversion from {sourceType} is not supported.");
  }

  #endregion
}