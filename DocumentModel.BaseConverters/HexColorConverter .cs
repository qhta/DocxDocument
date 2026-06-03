namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for RGB value Ito/from Open XML.
/// </summary>
public static class HexColorConverter
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
  /// Initializes the conversion maps for <see cref="HexColorConverter"/>.
  /// </summary>
  static HexColorConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(HexColorConverter), typeof(HexColor), supportedConversions, ConversionToMap, ConversionFromMap);
  }


  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue Ito RGB.
  /// </summary>
  /// <param name="SByteValue">The SByteValue Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;
    if (SByteValue.Value < 0)
      throw new OverflowException($"Value {SByteValue.Value} is out of range for RGB");

    return (HexColor)SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? ConvertToSByteValue(HexColor? value)
  {
    if (value is null) return null;
    if (value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value Ito RGB.
  /// </summary>
  /// <param name="int16Value">The Int16Value Ito convert.</param>
  /// <returns>The RGB int16Value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromInt16Value(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0)
      throw new OverflowException($"Value {int16Value} is out of range for RGB");

    return (HexColor)int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? ConvertToInt16Value(HexColor? value)
  {
    if (value is null) return null;
    if (value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value Ito RGB.
  /// </summary>
  /// <param name="Int32Value">The Int32Value Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value < 0)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for RGB");

    return (HexColor)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? ConvertToInt32Value(HexColor? value)
  {
    if (value is null) return null;
    if (value > Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value Ito RGB.
  /// </summary>
  /// <param name="Int64Value">The Int64Value Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < 0 || Int64Value.Value > UInt32.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for RGB");

    return (HexColor)(UInt32)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? ConvertToInt64Value(HexColor? value)
  {
    if (value is null) return null;

    return new DX.Int64Value { Value = (UInt32)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue Ito RGB.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < 0 || IntegerValue.Value > UInt32.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for RGB");

    return (UInt32)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ConvertToIntegerValue(HexColor? value)
  {
    if (value is null) return null;

    return new DX.IntegerValue { Value = (UInt32)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue Ito RGB.
  /// </summary>
  /// <param name="ByteValue">The ByteValue Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return new HexColor(ByteValue.Value);
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(HexColor? value)
  {
    if (value is null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)(UInt32)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value Ito RGB.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;

    return new HexColor(UInt16Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? ConvertToUInt16Value(HexColor? value)
  {
    if (value is null) return null;
    if (value > UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)(UInt32)value };
  }

  #endregion

  #region RgbValue conversion.

  /// <summary>
  /// Converts an OpenXml RgbValue Ito RGB.
  /// </summary>
  /// <param name="RgbValue">The RgbValue Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromUInt32Value(DX.UInt32Value? RgbValue)
  {
    if (RgbValue == null) return null;

    return (HexColor)RgbValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml RgbValue from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new RgbValue, or null if the input is null.</returns>
  public static DX.UInt32Value? ConvertToUInt32Value(HexColor? value)
  {
    if (value is null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for RGB");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value Ito RGB.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > UInt32.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for RGB");

    return (HexColor)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? ConvertToUInt64Value(HexColor? value)
  {
    if (value is null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");
    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito RGB.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;
    var text = StringValue.Value;

    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new HexColor(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(HexColor? value, Type targetType)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito RGB.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;
    var text = OpenXmlLeafTextElement.Text;

    return new HexColor(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(HexColor? value, Type targetType)
  {
    if (value is null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexColor)value).ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region HexBinaryValue conversion.

  /// <summary>
  /// Converts an OpenXml HexBinaryValue Ito RGB.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;
    var text = HexBinaryValue.Value;
    if (text == null)
      throw new InvalidOperationException("HexBinaryValue has no content.");

    return new HexColor(text);
    ;
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  public static DX.HexBinaryValue? ConvertToHexBinaryValue(HexColor? value, Type targetType)
  {
    if (value is null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexColor)value).ToString()!;
    var element = (DX.HexBinaryValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement Ito RGB.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The RGB value, or null if the element has no content.</returns>
  public static HexColor? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (HexColor)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an RGB value.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(HexColor? value, Type targetType)
  {
    if (value is null) return null;

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
  /// Converts the specified string representation of a number Ito its Rgbequivalent.
  /// </summary>
  /// <param name="value">The string Ito convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A RGB integer equivalent Ito the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static HexColor? ConvertFromString(string? value)
  {
    if (value is null) return null;
    return new HexColor(value);
  }

  /// <summary>
  /// Converts a nullable RGB value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable RGB value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(HexColor? value)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an RGB value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The RGB value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(HexColor? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value Ito a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value Ito convert Ito an <see cref="HexColor"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> Ito <see cref="HexColor"/> is not supported.</exception>
  public static HexColor? ConvertFrom(object? value)
  {
    return (HexColor?)ConverterBase.ConvertFrom(value, typeof(HexColor), ConversionFromMap);
  }

  #endregion
}
