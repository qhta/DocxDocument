namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for SByte value to/from Open XML.
/// </summary>
public static class SByteOpenXmlConverter
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
  /// Converts an OpenXml SByteValue to SByte.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;

    return SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? CreateSByteValue(SByte? value)
  {
    if (value == null) return null;

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to SByte.
  /// </summary>
  /// <param name="int16Value">The Int16Value to convert.</param>
  /// <returns>The SByte int16Value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < SByte.MinValue || int16Value > SByte.MaxValue)
      throw new OverflowException($"Value {int16Value} is out of range for SByte");

    return (SByte)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? CreateInt16Value(SByte? value)
  {
    if (value == null) return null;

    return new DX.Int16Value { Value = (SByte)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to SByte.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value< SByte.MinValue || Int32Value.Value > SByte.MaxValue)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for SByte");

    return (SByte)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? CreateInt32Value(SByte? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (SByte)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to SByte.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < SByte.MinValue || Int64Value.Value > SByte.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for SByte");

    return (SByte)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? CreateInt64Value(SByte? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to SByte.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < SByte.MinValue || IntegerValue.Value > SByte.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for SByte");

    return (SByte)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? CreateIntegerValue(SByte? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (SByte)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to SByte.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;
    if (ByteValue.Value > SByte.MaxValue)
      throw new OverflowException($"Value {ByteValue.Value} is out of range for SByte");
    return (SByte)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? CreateByteValue(SByte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to SByte.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;
    if (UInt16Value.Value > SByte.MaxValue)
      throw new OverflowException($"Value {UInt16Value.Value} is out of range for SByte");
    return (SByte)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? CreateUInt16Value(SByte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to SByte.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;
    if ( UInt32Value.Value > SByte.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range for SByte");

    return (SByte)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? CreateUInt32Value(SByte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt32");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to SByte.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The SByte value, or null if the element has no content.</returns>
  public static SByte? ConvertToSByte(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > (UInt16)SByte.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for SByte");

    return (SByte)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an SByte value.
  /// </summary>
  /// <param name="value">The SByte value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? CreateUInt64Value(SByte? value)
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
  public static object? ConvertToOpenXml(SByte? value, Type targetType)
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
  /// Converts an Open XML value to a nullable SByte integer, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an SByte integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int32Value,
  /// UInt32Value, UInt64Value, and StringValue. May be null.</param>
  /// <returns>An SByte representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static SByte? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.SByteValue sbyteValue)
      return ConvertToSByte(sbyteValue);
    if (value is DX.Int16Value int16Value)
      return ConvertToSByte(int16Value);
    if (value is DX.Int32Value int32Value)
      return ConvertToSByte(int32Value);
    if (value is DX.Int64Value int64Value)
      return ConvertToSByte(int64Value);

    if (value is DX.IntegerValue integerValue)
      return ConvertToSByte(integerValue);

    if (value is DX.ByteValue byteValue)
      return ConvertToSByte(byteValue);
    if (value is DX.UInt16Value uInt16Value)
      return ConvertToSByte(uInt16Value);
    if (value is DX.UInt32Value uintValue)
      return ConvertToSByte(uintValue);
    if (value is DX.UInt64Value uInt64Value)
      return ConvertToSByte(uInt64Value);

    if (value is DX.StringValue stringValue)
    {
      if (SByte.TryParse(stringValue.Value, out var result))
        return result;
      return null;
    }

    throw new InvalidOperationException($"Conversion from {sourceType} is not supported");
  }

  #endregion
}