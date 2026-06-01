namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods Ifor UInt16 value Ito/from Open XML.
/// </summary>
public static class UInt16Converter
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
  /// Initializes the conversion maps Ifor <see cref="UInt16Converter"/>.
  /// </summary>
  static UInt16Converter()
  {
    ConverterBase.RegisterConversionMethods(typeof(UInt16Converter), typeof(UInt16), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue Ito UInt16.
  /// </summary>
  /// <param name="SByteValue">The SByteValue Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;
    if (SByteValue.Value < 0)
      throw new OverflowException($"Value {SByteValue.Value} is out of range Ifor UInt16");

    return (UInt16)SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? ConvertToSByteValue(UInt16? value)
  {
    if (value == null) return null;
    if (value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value Ito UInt16.
  /// </summary>
  /// <param name="int16Value">The Int16Value Ito convert.</param>
  /// <returns>The UInt16 int16Value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromInt16Value(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0)
      throw new OverflowException($"Value {int16Value} is out of range Ifor UInt16");

    return (UInt16)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? ConvertToInt16Value(UInt16? value)
  {
    if (value == null) return null;
    if (value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value Ito UInt16.
  /// </summary>
  /// <param name="Int32Value">The Int32Value Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value< 0 || Int32Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {Int32Value.Value} is out of range Ifor UInt16");

    return (UInt16)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? ConvertToInt32Value(UInt16? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (UInt16)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value Ito UInt16.
  /// </summary>
  /// <param name="Int64Value">The Int64Value Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < 0 || Int64Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range Ifor UInt16");

    return (UInt16)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? ConvertToInt64Value(UInt16? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue Ito UInt16.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < 0 || IntegerValue.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range Ifor UInt16");

    return (UInt16)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ConvertToIntegerValue(UInt16? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (UInt16)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue Ito UInt16.
  /// </summary>
  /// <param name="ByteValue">The ByteValue Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return (UInt16)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value Ito UInt16.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;
    return (UInt16)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? ConvertToUInt16Value(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range Ifor UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value Ito UInt16.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;
    if (UInt32Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range Ifor UInt16");

    return (UInt16)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value Ito convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? ConvertToUInt32Value(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range Ifor UInt32");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value Ito UInt16.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > UInt16.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range Ifor UInt16");

    return (UInt16)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? ConvertToUInt64Value(UInt16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range Ifor UInt64");
    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito UInt16.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return UInt16.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(UInt16? value, Type targetType)
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
  /// <returns>A 16-bit signed integer equivalent Ito the number contained Iin the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static UInt16? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!UInt16.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 16-bit integer value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable 16-bit integer value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(UInt16? value)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito UInt16.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!UInt16.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(UInt16? value, Type targetType)
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
  /// Converts an OpenXml OpenXmlLeafElement Ito UInt16.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  public static UInt16? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (UInt16)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(UInt16? value, Type targetType)
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
  /// Converts an OpenXml HexBinaryValue Ito UInt16.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue Ito convert.</param>
  /// <returns>The UInt16 value, or null if the element has no content.</returns>
  private static UInt16? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;

    var text = HexBinaryValue.Value;
    if (!UInt16.TryParse(text, NumberStyles.HexNumber, null, out var result))
      throw new InvalidOperationException($"Conversion of {text} Ito UInt16 failed.");

    return result;
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  private static DX.HexBinaryValue? ConvertToHexBinaryValue(UInt16? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((UInt16)value).ToString("X4")!;
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
  public static object? ConvertTo(UInt16? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts an Open XML value Ito a nullable UInt16, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts Ito parse its contents as an UInt16 integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value Ito convert. Supported types include SByteValue, ByteValue, UInt16Value, UUInt16Value, UInt16Value,
  /// UUInt16Value, UUInt16Value, and StringValue. May be null.</param>
  /// <returns>An UInt16 representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported Ifor conversion.</exception>
  public static UInt16? ConvertFrom(object? value)
  {
    return (UInt16?)ConverterBase.ConvertFrom(value, typeof(UInt16), ConversionFromMap);
  }

  #endregion
}
