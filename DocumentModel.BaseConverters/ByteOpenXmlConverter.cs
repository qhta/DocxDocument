namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Byte value to/from Open XML.
/// </summary>
public static class ByteOpenXmlConverter
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
  /// Converts an OpenXml SByteValue to Byte.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;
    if (SByteValue.Value < 0)
      throw new OverflowException($"Value {SByteValue.Value} is out of range for Byte");

    return (Byte)SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? CreateSByteValue(Byte? value)
  {
    if (value == null) return null;
    if (value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to Byte.
  /// </summary>
  /// <param name="int16Value">The Int16Value to convert.</param>
  /// <returns>The Byte int16Value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0 || int16Value > Byte.MaxValue)
      throw new OverflowException($"Value {int16Value} is out of range for Byte");

    return (Byte)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? CreateInt16Value(Byte? value)
  {
    if (value == null) return null;

    return new DX.Int16Value { Value = (Byte)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Byte.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value< 0 || Int32Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for Byte");

    return (Byte)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? CreateInt32Value(Byte? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (Byte)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to Byte.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < 0 || Int64Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for Byte");

    return (Byte)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? CreateInt64Value(Byte? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to Byte.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < 0 || IntegerValue.Value > Byte.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for Byte");

    return (Byte)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? CreateIntegerValue(Byte? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Byte)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to Byte.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return (Byte)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? CreateByteValue(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to Byte.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;
    if (UInt16Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {UInt16Value.Value} is out of range for Byte");
    return (Byte)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? CreateUInt16Value(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Byte.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;
    if ( UInt32Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range for Byte");

    return (Byte)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? CreateUInt32Value(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt32");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to Byte.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertToByte(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for Byte");

    return (Byte)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? CreateUInt64Value(Byte? value)
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
  public static object? ConvertToOpenXml(Byte? value, Type targetType)
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

    throw new InvalidOperationException($"Conversion from Byte to {targetType} is not supported");
  }

  /// <summary>
  /// Converts an Open XML value to a nullable Byte integer, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an Byte integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int32Value,
  /// UInt32Value, UInt64Value, and StringValue. May be null.</param>
  /// <returns>An Byte representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Byte? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.SByteValue sbyteValue)
      return ConvertToByte(sbyteValue);
    if (value is DX.Int16Value int16Value)
      return ConvertToByte(int16Value);
    if (value is DX.Int32Value int32Value)
      return ConvertToByte(int32Value);
    if (value is DX.Int64Value int64Value)
      return ConvertToByte(int64Value);

    if (value is DX.IntegerValue integerValue)
      return ConvertToByte(integerValue);

    if (value is DX.ByteValue byteValue)
      return ConvertToByte(byteValue);
    if (value is DX.UInt16Value uInt16Value)
      return ConvertToByte(uInt16Value);
    if (value is DX.UInt32Value uintValue)
      return ConvertToByte(uintValue);
    if (value is DX.UInt64Value uInt64Value)
      return ConvertToByte(uInt64Value);

    if (value is DX.StringValue stringValue)
    {
      if (Byte.TryParse(stringValue.Value, out var result))
        return result;
      return null;
    }

    throw new InvalidOperationException($"Conversion from {sourceType} to is not supported");
  }

  #endregion
}