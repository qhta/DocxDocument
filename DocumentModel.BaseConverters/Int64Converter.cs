namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Int64 value to/from Open XML.
/// </summary>
public static class Int64Converter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.SByteValue), nameof(ConvertFromSByteValue), nameof(ConvertToSByteValue)),
    new(typeof(DX.Int16Value), nameof(ConvertFromInt16Value), nameof(ConvertToInt16Value)),
    new(typeof(DX.Int32Value), nameof(ConvertFromInt32Value), nameof(ConvertToInt32Value)),
    new(typeof(DX.Int64Value), nameof(ConvertFromInt64Value), nameof(ConvertToInt64Value)),
    new(typeof(DX.IntegerValue), nameof(ConvertFromIntegerValue), nameof(ConvertToIntegerValue)),
    new(typeof(DX.ByteValue), nameof(ConvertFromByteValue), nameof(ConvertToByteValue)),
    new(typeof(DX.UInt16Value), nameof(ConvertFromUInt16Value), nameof(ConvertToUInt16Value)),
    new(typeof(DX.UInt32Value), nameof(ConvertFromUInt32Value), nameof(ConvertToUInt32Value)),
    new(typeof(DX.UInt64Value), nameof(ConvertFromUInt64Value), nameof(ConvertToUInt64Value)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.HexBinaryValue), nameof(ConvertFromHexBinaryValue), nameof(ConvertToHexBinaryValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString))
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for this converter.
  /// </summary>
  static Int64Converter()
  {
    ConverterBase.RegisterConversionMethods(typeof(Int64Converter), typeof(Int64), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue to Int64.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;

    return SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? ConvertToSByteValue(Int64? value)
  {
    if (value == null) return null;

    if (value < SByte.MinValue || value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to Int64.
  /// </summary>
  /// <param name="Int16Value">The Int16Value to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromInt16Value(DX.Int16Value? Int16Value)
  {
    if (Int16Value == null) return null;

    return Int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? ConvertToInt16Value(Int64? value)
  {
    if (value == null) return null;

    if (value < Int16.MinValue || value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Int64.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? ConvertToInt32Value(Int64? value)
  {
    if (value == null) return null;

    if (value < Int32.MinValue || value > Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to Int64.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;

    return (Int64)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? ConvertToInt64Value(Int64? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to Int64.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;

    return (Int64)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ConvertToIntegerValue(Int64? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Int64)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to Int64.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(Int64? value)
  {
    if (value == null) return null;

    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to Int64.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;

    return UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? ConvertToUInt16Value(Int64? value)
  {
    if (value == null) return null;

    if (value < 0 || value > UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Int64.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;

    return (Int64)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? ConvertToUInt32Value(Int64? value)
  {
    if (value == null) return null;

    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt32");

    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to Int64.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  public static Int64? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;

    if (UInt64Value.Value > Int64.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for Int64");

    return (Int64)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? ConvertToUInt64Value(Int64? value)
  {
    if (value == null) return null;

    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");

    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to Int64.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  private static Int64? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return Int64.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  private static DX.StringValue? ConvertToStringValue(Int64? value, Type targetType)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region String conversion.

  /// <summary>
  /// Converts the specified string representation of a number to its 64-bit signed integer equivalent.
  /// </summary>
  /// <param name="value">The string to convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A 64-bit signed integer equivalent to the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static Int64? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!Int64.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 64-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 64-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(Int64? value)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Int64.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  private static Int64? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!Int64.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Int64? value, Type targetType)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement to Int64.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  private static Int64? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
  {
    if (OpenXmlLeafElement == null) return null;

    var sourceType = OpenXmlLeafElement.GetType();
    var valProp = OpenXmlLeafElement.GetType().GetProperty("Val");
    if (valProp == null)
    {
      var allProps = sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        throw new InvalidOperationException($"OpenXmlLeafElement of type {sourceType} does not have a string Val property");
    }
    var value = valProp.GetValue(OpenXmlLeafElement);
    var convertedValue = ConvertFrom(value);
    return (Int64)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Int64? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProp = element.GetType().GetProperty("Val");
    if (valProp == null)
    {
      var allProps = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        throw new InvalidOperationException($"OpenXmlLeafElement of type {element.GetType()} does not have a string Val property");
    }
    var convertedValue = ConvertTo(value, valProp.PropertyType);
    valProp.SetValue(element, convertedValue);
    return element;
  }

  #endregion

  #region HexBinaryValue conversion.

  /// <summary>
  /// Converts an OpenXml HexBinaryValue to Int64.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue to convert.</param>
  /// <returns>The Int64 value, or null if the element has no content.</returns>
  private static Int64? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;

    var text = HexBinaryValue.Value;
    if (!Int64.TryParse(text, NumberStyles.HexNumber, null, out var result))
      throw new InvalidOperationException($"Conversion of {text} to Int64 failed.");

    return result;
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value to convert.</param>
  /// <param name="targetType">The target type for the created HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  private static DX.HexBinaryValue? ConvertToHexBinaryValue(Int64? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((Int64)value).ToString("X16")!;
    var element = (DX.HexBinaryValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
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
  public static object? ConvertTo(Int64? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts an Open XML value to a nullable Int64, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an Int64 integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int64Value,
  /// UInt64Value, UInt64Value, and StringValue. May be null.</param>
  /// <returns>An Int64 representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Int64? ConvertFrom(object? value)
  {
    return (Int64?)ConverterBase.ConvertFrom(value, typeof(Int64), ConversionFromMap);
  }

  #endregion
}