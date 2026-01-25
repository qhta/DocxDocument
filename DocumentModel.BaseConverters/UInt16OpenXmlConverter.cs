namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for UInt16 value to/from Open XML.
/// </summary>
public static class UInt16OpenXmlConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.SByteValue),
    typeof(DX.Int16Value),
    typeof(DX.Int32Value),
    typeof(DX.Int64Value),
    typeof(DX.IntegerValue),
    typeof(DX.ByteValue),
    typeof(DX.UInt16Value),
    typeof(DX.UInt32Value),
    typeof(DX.UInt64Value),
    typeof(DX.StringValue)
  ];

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue to UInt16.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;
    if (SByteValue.Value < 0)
      throw new OverflowException($"Value {SByteValue.Value} is out of range for UInt16");

    return (UInt16)SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? CreateSByteValue(UInt16? value)
  {
    if (value == null) return null;
    if (value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to UInt16.
  /// </summary>
  /// <param name="int16Value">The Int16Value to convert.</param>
  /// <returns>The UInt16 int16Value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0)
      throw new OverflowException($"Value {int16Value} is out of range for UInt16");

    return (UInt16)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? CreateInt16Value(UInt16? value)
  {
    if (value == null) return null;
    if (value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to UInt16.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value< 0 || Int32Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for UInt16");

    return (UInt16)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? CreateInt32Value(UInt16? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (UInt16)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to UInt16.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < 0 || Int64Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for UInt16");

    return (UInt16)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? CreateInt64Value(UInt16? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to UInt16.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < 0 || IntegerValue.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for UInt16");

    return (UInt16)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? CreateIntegerValue(UInt16? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (UInt16)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to UInt16.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return (UInt16)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? CreateByteValue(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to UInt16.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;
    if (UInt16Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {UInt16Value.Value} is out of range for UInt16");
    return (UInt16)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? CreateUInt16Value(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to UInt16.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;
    if ( UInt32Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range for UInt16");

    return (UInt16)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? CreateUInt32Value(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt32");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to UInt16.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertToUInt16(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for UInt16");

    return (UInt16)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? CreateUInt64Value(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");
    return new DX.UInt64Value { Value = (UInt64)value };
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
  public static object? ConvertToOpenXml(UInt16? value, Type targetType)
  {
    if (value == null)
      return null;
    if (targetType == typeof(DX.SByteValue))
      return CreateSByteValue(value);
    if (targetType == typeof(DX.Int16Value))
      return CreateInt16Value(value);
    if (targetType == typeof(DX.Int32Value))
      return CreateInt32Value(value);
    if (targetType == typeof(DX.Int64Value))
      return CreateInt64Value(value);

    if (targetType == typeof(DX.IntegerValue))
      return CreateIntegerValue(value);

    if (targetType == typeof(DX.ByteValue))
      return CreateByteValue(value);
    if (targetType == typeof(DX.UInt16Value))
      return CreateUInt16Value(value);
    if (targetType == typeof(DX.UInt32Value))
      return CreateUInt32Value(value);
    if (targetType == typeof(DX.UInt64Value))
      return CreateUInt64Value(value);

    if (targetType == typeof(DX.StringValue))
      return new DX.StringValue(value.ToString());

    throw new InvalidOperationException($"Conversion to {targetType} is not supported");
  }

  /// <summary>
  /// Converts an Open XML value to a nullable UInt16 integer, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an UInt16 integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int32Value,
  /// UInt32Value, UInt64Value, and StringValue. May be null.</param>
  /// <returns>An UInt16 representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static UInt16? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.SByteValue sbyteValue)
      return ConvertToUInt16(sbyteValue);
    if (value is DX.Int16Value int16Value)
      return ConvertToUInt16(int16Value);
    if (value is DX.Int32Value int32Value)
      return ConvertToUInt16(int32Value);
    if (value is DX.Int64Value int64Value)
      return ConvertToUInt16(int64Value);

    if (value is DX.IntegerValue integerValue)
      return ConvertToUInt16(integerValue);

    if (value is DX.ByteValue byteValue)
      return ConvertToUInt16(byteValue);
    if (value is DX.UInt16Value uInt16Value)
      return ConvertToUInt16(uInt16Value);
    if (value is DX.UInt32Value uintValue)
      return ConvertToUInt16(uintValue);
    if (value is DX.UInt64Value uInt64Value)
      return ConvertToUInt16(uInt64Value);

    if (value is DX.StringValue stringValue)
    {
      if (UInt16.TryParse(stringValue.Value, out var result))
        return result;
      return null;
    }

    throw new InvalidOperationException($"Conversion from {sourceType} is not supported");
  }

  #endregion
}