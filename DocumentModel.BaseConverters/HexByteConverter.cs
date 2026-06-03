namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for HexByte value to/from Open XML.
/// </summary>
public static class HexByteConverter
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
  /// Initializes the conversion maps for <see cref="HexByteConverter"/>.
  /// </summary>
  static HexByteConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(HexByteConverter), typeof(HexByte), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue to HexByte.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;
    if (SByteValue.Value < 0)
    {
      int val = SByteValue.Value;
      val = -(256 - val); // Two's complement to get the negative value for SByte
      return new HexByte((byte)val);
    }

    return new HexByte(SByteValue.Value);
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? ConvertToSByteValue(HexByte? value)
  {
    if (value is null) return null;

    if (value > SByte.MaxValue)
    {
      int val= (int)value;
      val = -(256 - val); // Two's complement to get the negative value for SByte
      return new DX.SByteValue { Value = (SByte)val };
    }

    return new DX.SByteValue { Value = (SByte)(UInt16)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to HexByte.
  /// </summary>
  /// <param name="int16Value">The Int16Value to convert.</param>
  /// <returns>The HexByte int16Value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromInt16Value(DX.Int16Value? int16Value)
  {
    if (int16Value == null) return null;
    if (int16Value < 0)
      throw new OverflowException($"Value {int16Value} is out of range for HexByte");

    return new HexByte(int16Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? ConvertToInt16Value(HexByte? value)
  {
    if (value is null) return null;
    if (value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)(UInt16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to HexByte.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value < 0)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for HexByte");

    return (HexByte)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? ConvertToInt32Value(HexByte? value)
  {
    if (value is null) return null;

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to HexByte.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < 0 || Int64Value.Value > UInt32.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for HexByte");

    return (HexByte)(UInt32)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? ConvertToInt64Value(HexByte? value)
  {
    if (value is null) return null;

    return new DX.Int64Value { Value = (UInt32)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to HexByte.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < 0 || IntegerValue.Value > UInt32.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for HexByte");

    return (UInt32)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? ConvertToIntegerValue(HexByte? value)
  {
    if (value is null) return null;

    return new DX.IntegerValue { Value = (UInt32)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to HexByte.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return (HexByte)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(HexByte? value)
  {
    if (value is null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to HexByte.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;

    return (HexByte)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? ConvertToUInt16Value(HexByte? value)
  {
    if (value is null) return null;
    if (value > UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region HexByteValue conversion.

  /// <summary>
  /// Converts an OpenXml HexByteValue to HexByte.
  /// </summary>
  /// <param name="HexByteValue">The HexByteValue to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromUInt32Value(DX.UInt32Value? HexByteValue)
  {
    if (HexByteValue == null) return null;

    return (HexByte)HexByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml HexByteValue from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new HexByteValue, or null if the input is null.</returns>
  public static DX.UInt32Value? ConvertToUInt32Value(HexByte? value)
  {
    if (value is null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for HexByte");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to HexByte.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > UInt32.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for HexByte");

    return (HexByte)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? ConvertToUInt64Value(HexByte? value)
  {
    if (value is null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");
    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to HexByte.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;
    var text = StringValue.Value;

    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new HexByte(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <param name="targetType">The target type for the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(HexByte? value, Type targetType)
  {
    if (value is null) return null;

    var text = value.ToString(format:"X2")!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to HexByte.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;
    var text = OpenXmlLeafTextElement.Text;

    return new HexByte(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(HexByte? value, Type targetType)
  {
    if (value is null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexByte)value).ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region HexBinaryValue conversion.

  /// <summary>
  /// Converts an OpenXml HexBinaryValue to HexByte.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;
    var text = HexBinaryValue.Value;
    if (text == null)
      throw new InvalidOperationException("HexBinaryValue has no content.");

    return new HexByte(text);
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <param name="targetType">The target type for the Icreated HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  public static DX.HexBinaryValue? ConvertToHexBinaryValue(HexByte? value, Type targetType)
  {
    if (value is null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexByte)value).ToString()!;
    var element = (DX.HexBinaryValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement to HexByte.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The HexByte value, or null if the element has no content.</returns>
  public static HexByte? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (HexByte)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an HexByte value.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(HexByte? value, Type targetType)
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
  /// Converts the specified string representation of a number to its HexByteequivalent.
  /// </summary>
  /// <param name="value">The string to convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A HexByte integer equivalent to the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static HexByte? ConvertFromString(string? value)
  {
    if (value is null) return null;

    return new HexByte(value);
  }

  /// <summary>
  /// Converts a nullable HexByte value to its string representation.
  /// </summary>
  /// <param name="value">The nullable HexByte value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(HexByte? value)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an HexByte value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The HexByte value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(HexByte? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value to convert to an <see cref="HexByte"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="HexByte"/> is not supported.</exception>
  public static HexByte? ConvertFrom(object? value)
  {
    return (HexByte?)ConverterBase.ConvertFrom(value, typeof(HexByte), ConversionFromMap);
  }

  #endregion
}
