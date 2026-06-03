namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Byte value Ito/from Open XML.
/// </summary>
public static class ByteConverter
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
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="ByteConverter"/>.
  /// </summary>
  static ByteConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(ByteConverter), typeof(Byte), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue Ito Byte.
  /// </summary>
  /// <param name="SByteValue">The SByteValue Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;
    if (SByteValue.Value < 0)
      throw new OverflowException($"Value {SByteValue.Value} is out of range for Byte");

    return (Byte)SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? ConvertToSByteValue(Byte? value)
  {
    if (value == null) return null;
    if (value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value Ito Byte.
  /// </summary>
  /// <param name="int16Value">The Int16Value Ito convert.</param>
  /// <returns>The Byte int16Value, or null if the element has no content.</returns>
  public static Byte? ConvertFromInt16Value(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0 || int16Value > Byte.MaxValue)
      throw new OverflowException($"Value {int16Value} is out of range for Byte");

    return (Byte)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? ConvertToInt16Value(Byte? value)
  {
    if (value == null) return null;

    return new DX.Int16Value { Value = (Byte)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value Ito Byte.
  /// </summary>
  /// <param name="Int32Value">The Int32Value Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value < 0 || Int32Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for Byte");

    return (Byte)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? ConvertToInt32Value(Byte? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (Byte)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value Ito Byte.
  /// </summary>
  /// <param name="Int64Value">The Int64Value Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < 0 || Int64Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for Byte");

    return (Byte)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? ConvertToInt64Value(Byte? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue Ito Byte.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < 0 || IntegerValue.Value > Byte.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for Byte");

    return (Byte)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ConvertToIntegerValue(Byte? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Byte)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue Ito Byte.
  /// </summary>
  /// <param name="ByteValue">The ByteValue Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return (Byte)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value Ito Byte.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;
    if (UInt16Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {UInt16Value.Value} is out of range for Byte");
    return (Byte)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? ConvertToUInt16Value(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value Ito Byte.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;
    if (UInt32Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range for Byte");

    return (Byte)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value Ito convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? ConvertToUInt32Value(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt32");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value Ito Byte.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > Byte.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for Byte");

    return (Byte)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? ConvertToUInt64Value(Byte? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");
    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito Byte.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return Byte.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(Byte? value, Type targetType)
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
  /// Converts the specified string representation of a number Ito its 16-bit signed integer equivalent.
  /// </summary>
  /// <param name="value">The string Ito convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A 16-bit signed integer equivalent Ito the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static Byte? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!Byte.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 16-bit integer value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable 16-bit integer value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(Byte? value)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito Byte.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!Byte.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Byte? value, Type targetType)
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
  /// Converts an OpenXml OpenXmlLeafElement Ito Byte.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  public static Byte? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (Byte)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Byte? value, Type targetType)
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
  /// Converts an OpenXml HexBinaryValue Ito Byte.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue Ito convert.</param>
  /// <returns>The Byte value, or null if the element has no content.</returns>
  private static Byte? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;

    var text = HexBinaryValue.Value;
    if (!Byte.TryParse(text, NumberStyles.HexNumber, null, out var result))
      throw new InvalidOperationException($"Conversion of {text} Ito Byte failed.");

    return result;
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an Byte value.
  /// </summary>
  /// <param name="value">The Byte value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  private static DX.HexBinaryValue? ConvertToHexBinaryValue(Byte? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((Byte)value).ToString("X4")!;
    var element = (DX.HexBinaryValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion


  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a value Ito a specified target type.
  /// </summary>
  /// <param name="value">The value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the element has no content.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion is not supported.</exception>
  public static object? ConvertTo(Byte? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts an Open XML value Ito a nullable Byte, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts Ito parse its contents as an Byte integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value Ito convert. Supported types include ByteValue, ByteValue, ByteValue, UByteValue, ByteValue,
  /// UByteValue, UByteValue, and StringValue. May be null.</param>
  /// <returns>An Byte representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Byte? ConvertFrom(object? value)
  {
    return (Byte?)ConverterBase.ConvertFrom(value, typeof(Byte), ConversionFromMap);
  }

  #endregion
}
