namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Percent value to/from Open XML.
/// </summary>
public static class PercentConverter
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
  /// Initializes the conversion maps for <see cref="PercentConverter"/>.
  /// </summary>
  static PercentConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(PercentConverter), typeof(Percent), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue to Percent.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromSByteValue(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;

    return SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  private static DX.SByteValue? ConvertToSByteValue(Percent? value)
  {
    if (value == null) return null;

    if (value < SByte.MinValue || value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to Percent.
  /// </summary>
  /// <param name="Int16Value">The Int16Value to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromInt16Value(DX.Int16Value? Int16Value)
  {
    if (Int16Value == null) return null;

    return Int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  private static DX.Int16Value? ConvertToInt16Value(Percent? value)
  {
    if (value == null) return null;

    if (value < Int16.MinValue || value > Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Percent.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  private static DX.Int32Value? ConvertToInt32Value(Percent? value)
  {
    if (value == null) return null;

    if (value < Int32.MinValue || value > Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to Percent.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;

    return new Percent(Int64Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  private static DX.Int64Value? ConvertToInt64Value(Percent? value)
  {
    if (value == null) return null;

    if (value < Int64.MinValue || value > Int64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int64");

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to Percent.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;

    return new Percent(IntegerValue.Value);
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  private static DX.IntegerValue? ConvertToIntegerValue(Percent? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Int32)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to Percent.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  private static DX.ByteValue? ConvertToByteValue(Percent? value)
  {
    if (value == null) return null;

    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to Percent.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;

    return UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  private static DX.UInt16Value? ConvertToUInt16Value(Percent? value)
  {
    if (value == null) return null;

    if (value < 0 || value > UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Percent.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;

    return (Percent)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UPercent value.
  /// </summary>
  /// <param name="value">The UPercent value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  private static DX.UInt32Value? ConvertToUInt32Value(Percent? value)
  {
    if (value == null) return null;

    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UPercent");

    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to Percent.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;

    return new Percent(UInt64Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  private static DX.UInt64Value? ConvertToUInt64Value(Percent? value)
  {
    if (value == null) return null;

    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");

    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to Percent.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return Percent.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  private static DX.StringValue? ConvertToStringValue(Percent? value, Type targetType)
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
  private static Percent? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!Percent.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 32-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 32-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(Percent? value)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Percent.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!Percent.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Percent? value, Type targetType)
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
  /// Converts an OpenXml OpenXmlLeafElement to Percent.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The Percent value, or null if the element has no content.</returns>
  private static Percent? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (Percent)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Percent? value, Type targetType)
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
  /// Converts an Percent value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(Percent? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value to convert to an <see cref="Percent"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="Percent"/> is not supported.</exception>
  public static Percent? ConvertFrom(object? value)
  {
    return (Percent?)ConverterBase.ConvertFrom(value, typeof(Percent), ConversionFromMap);
  }

  #endregion
}
