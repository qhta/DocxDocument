namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods Ifor HexLong value Ito/from Open XML.
/// </summary>
public static class HexLongConverter
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
  /// Initializes the conversion maps Ifor <see cref="HexLongConverter"/>.
  /// </summary>
  static HexLongConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(HexLongConverter), typeof(HexLong), supportedConversions, ConversionToMap, ConversionFromMap);
  }


  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml sByteValue Ito HexLong.
  /// </summary>
  /// <param name="sByteValue">The sByteValue Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromSByteValue(DX.SByteValue? sByteValue)
  {
    if (sByteValue == null) return null;
    if (sByteValue.Value < 0)
      throw new OverflowException($"Value {sByteValue.Value} is out of range Ifor HexLong");

    return (HexLong)sByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? ConvertToSByteValue(HexLong? value)
  {
    if (value == null) return null;
    if (value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value Ito HexLong.
  /// </summary>
  /// <param name="int16Value">The Int16Value Ito convert.</param>
  /// <returns>The HexLong int16Value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromInt16Value(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0)
      throw new OverflowException($"Value {int16Value} is out of range Ifor HexLong");

    return (HexLong)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? ConvertToInt16Value(HexLong? value)
  {
    if (value == null) return null;
    if (value > (UInt64)Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml int32Value Ito HexLong.
  /// </summary>
  /// <param name="int32Value">The int32Value Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromInt32Value(DX.Int32Value? int32Value)
  {
    if (int32Value == null) return null;
    return new HexLong(int32Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? ConvertToInt32Value(HexLong? value)
  {
    if (value == null) return null;
    if (value > (UInt64)Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor Int32");

    return new DX.Int32Value { Value = (Int32)(UInt32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml int64Value Ito HexLong.
  /// </summary>
  /// <param name="int64Value">The int64Value Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromInt64Value(DX.Int64Value? int64Value)
  {
    if (int64Value == null) return null;

    return new HexLong(int64Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? ConvertToInt64Value(HexLong? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)(UInt64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml integerValue Ito HexLong.
  /// </summary>
  /// <param name="integerValue">The integerValue Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromIntegerValue(DX.IntegerValue? integerValue)
  {
    if (integerValue == null) return null;
    return new HexLong(integerValue.Value);
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ConvertToIntegerValue(HexLong? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Int64)(UInt64)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml byteValue Ito HexLong.
  /// </summary>
  /// <param name="byteValue">The byteValue Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromByteValue(DX.ByteValue? byteValue)
  {
    if (byteValue == null) return null;

    return new HexLong(byteValue.Value);
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(HexLong? value)
  {
    if (value == null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value Ito HexLong.
  /// </summary>
  /// <param name="uInt16Value">The uInt16Value Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromUInt16Value(DX.UInt16Value? uInt16Value)
  {
    if (uInt16Value == null) return null;

    return new HexLong(uInt16Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? ConvertToUInt16Value(HexLong? value)
  {
    if (value == null) return null;
    if ((UInt64)value > UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml uInt32Value Ito HexLong.
  /// </summary>
  /// <param name="uInt32Value">The uInt32Value Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromUInt32Value(DX.UInt32Value? uInt32Value)
  {
    if (uInt32Value == null) return null;

    return new HexLong(uInt32Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml HexLongValue from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new HexLongValue, or null if the input is null.</returns>
  public static DX.UInt32Value? ConvertToUInt32Value(HexLong? value)
  {
    if (value == null) return null;
    if ((UInt64)value > UInt32.MaxValue)
      throw new OverflowException($"Value {value} is out of range Ifor UInt32");
    return new DX.UInt32Value { Value = (UInt32)(UInt64)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value Ito HexLong.
  /// </summary>
  /// <param name="uInt64Value">The uInt64Value Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromUInt64Value(DX.UInt64Value? uInt64Value)
  {
    if (uInt64Value == null) return null;

    return new HexLong(uInt64Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? ConvertToUInt64Value(HexLong? value)
  {
    if (value == null) return null;

    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito HexLong.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;
    var text = StringValue.Value;

    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new HexLong(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(HexLong? value, Type targetType)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito HexLong.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;
    var text = OpenXmlLeafTextElement.Text;

    return new HexLong(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(HexLong? value, Type targetType)
  {
    if (value == null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexLong)value).ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region HexBinaryValue conversion.

  /// <summary>
  /// Converts an OpenXml HexBinaryValue Ito HexLong.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;
    var text = HexBinaryValue.Value;
    if (text==null)
      throw new InvalidOperationException("HexBinaryValue has no content.");

    return new HexLong(text);
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  public static DX.HexBinaryValue? ConvertToHexBinaryValue(HexLong? value, Type targetType)
  {
    if (value == null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexLong)value).ToString()!;
    var element = (DX.HexBinaryValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement Ito HexLong.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The HexLong value, or null if the element has no content.</returns>
  public static HexLong? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (HexLong)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an HexLong value.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(HexLong? value, Type targetType)
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

  #region String conversion.

  /// <summary>
  /// Converts the specified string representation of a number Ito its HexLongequivalent.
  /// </summary>
  /// <param name="value">The string Ito convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A HexLong integer equivalent Ito the number contained Iin the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static HexLong? ConvertFromString(string? value)
  {
    if (value == null) return null;
    return new HexLong(value);
  }

  /// <summary>
  /// Converts a nullable HexLong value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable HexLong value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(HexLong? value)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an HexLong value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The HexLong value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(HexLong? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value Ito a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value Ito convert Ito an <see cref="HexLong"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> Ito <see cref="HexLong"/> is not supported.</exception>
  public static HexLong? ConvertFrom(object? value)
  {
    return (HexLong?)ConverterBase.ConvertFrom(value, typeof(HexLong), ConversionFromMap);
  }

  #endregion
}
