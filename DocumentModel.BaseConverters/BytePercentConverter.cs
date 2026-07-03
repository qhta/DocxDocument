namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for BytePercent value to/from Open XML.
/// </summary>
public static class BytePercentConverter
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
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString))
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="BytePercentConverter"/>.
  /// </summary>
  static BytePercentConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(BytePercentConverter), typeof(BytePercent), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue to BytePercent.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;

    return SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  private static DX.SByteValue? ConvertToSByteValue(BytePercent? value)
  {
    if (value == null) return null;

    if (value < SByte.MinValue || value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to BytePercent.
  /// </summary>
  /// <param name="Int16Value">The Int16Value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromInt16Value(DX.Int16Value? Int16Value)
  {
    if (Int16Value == null) return null;

    return Int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  private static DX.Int16Value? ConvertToInt16Value(BytePercent? value)
  {
    if (value == null) return null;

    if (value < Int16.MinValue || value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to BytePercent.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  private static DX.Int32Value? ConvertToInt32Value(BytePercent? value)
  {
    if (value == null) return null;

    if (value < Int32.MinValue || value > Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml value to BytePercent.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromInt64Value(DX.Int64Value? value)
  {
    if (value == null) return null;
    
    if (value < Byte.MinValue || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for byte");
    return new BytePercent((byte)value.Value);
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  private static DX.Int64Value? ConvertToInt64Value(BytePercent? value)
  {
    if (value == null) return null;
    
    return new DX.Int64Value { Value = (Byte)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml value to BytePercent.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromIntegerValue(DX.IntegerValue? value)
  {
    if (value == null) return null;

    if (value < Byte.MinValue || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for byte");

    return new BytePercent((byte)value);
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  private static DX.IntegerValue? ConvertToIntegerValue(BytePercent? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Int32)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml value to BytePercent.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromByteValue(DX.ByteValue? value)
  {
    if (value == null) return null;

    if (value < Byte.MinValue || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for byte");

    return value.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  private static DX.ByteValue? ConvertToByteValue(BytePercent? value)
  {
    if (value == null) return null;

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml value to BytePercent.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromUInt16Value(DX.UInt16Value? value)
  {
    if (value == null) return null;

    if (value < Byte.MinValue || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for byte");

    return value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  private static DX.UInt16Value? ConvertToUInt16Value(BytePercent? value)
  {
    if (value == null) return null;

    if (value < 0 || value > UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml value to BytePercent.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromUInt32Value(DX.UInt32Value? value)
  {
    if (value == null) return null;
    
    if (value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for byte");

    return (BytePercent)value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UBytePercent value.
  /// </summary>
  /// <param name="value">The UBytePercent value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  private static DX.UInt32Value? ConvertToUInt32Value(BytePercent? value)
  {
    if (value == null) return null;

    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UBytePercent");

    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml value to BytePercent.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromUInt64Value(DX.UInt64Value? value)
  {
    if (value == null) return null;

    if (value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for byte");

    return new BytePercent((Byte)value);
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  private static DX.UInt64Value? ConvertToUInt64Value(BytePercent? value)
  {
    if (value == null) return null;

    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");

    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to BytePercent.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return BytePercent.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  private static DX.StringValue? ConvertToStringValue(BytePercent? value, Type targetType)
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
  /// Converts the specified string representation of a number to its 32-bit signed integer equivalent.
  /// </summary>
  /// <param name="value">The string to convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A 32-bit signed integer equivalent to the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static BytePercent? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!BytePercent.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 32-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 32-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(BytePercent? value)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to BytePercent.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!BytePercent.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(BytePercent? value, Type targetType)
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
  /// Converts an OpenXml OpenXmlLeafElement to BytePercent.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The BytePercent value, or null if the element has no content.</returns>
  private static BytePercent? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (BytePercent)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an BytePercent value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(BytePercent? value, Type targetType)
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

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an BytePercent value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(BytePercent? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value to convert to an <see cref="BytePercent"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="BytePercent"/> is not supported.</exception>
  public static BytePercent? ConvertFrom(object? value)
  {
    return (BytePercent?)ConverterBase.ConvertFrom(value, typeof(BytePercent), ConversionFromMap);
  }

  #endregion
}
