namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for HexPercent value Ito/from Open XML.
/// </summary>
public static class HexPercentConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.ByteValue), nameof(ConvertFromByteValue), nameof(ConvertToByteValue)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.HexBinaryValue), nameof(ConvertFromHexBinaryValue), nameof(ConvertToHexBinaryValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="HexPercentConverter"/>.
  /// </summary>
  static HexPercentConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(HexPercentConverter), typeof(HexPercent), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue Ito HexPercent.
  /// </summary>
  /// <param name="ByteValue">The ByteValue Ito convert.</param>
  /// <returns>The HexPercent value, or null if the element has no content.</returns>
  public static HexPercent? ConvertFromByteValue(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return (HexPercent)ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an HexPercent value.
  /// </summary>
  /// <param name="value">The HexPercent value Ito convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? ConvertToByteValue(HexPercent? value)
  {
    if (value is null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito HexPercent.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The HexPercent value, or null if the element has no content.</returns>
  public static HexPercent? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;
    var text = StringValue.Value;

    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new HexPercent(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an HexPercent value.
  /// </summary>
  /// <param name="value">The HexPercent value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? ConvertToStringValue(HexPercent? value, Type targetType)
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
  /// Converts an OpenXml OpenXmlLeafTextElement Ito HexPercent.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The HexPercent value, or null if the element has no content.</returns>
  public static HexPercent? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;
    var text = OpenXmlLeafTextElement.Text;

    return new HexPercent(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an HexPercent value.
  /// </summary>
  /// <param name="value">The HexPercent value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(HexPercent? value, Type targetType)
  {
    if (value is null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexPercent)value).ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region HexBinaryValue conversion.

  /// <summary>
  /// Converts an OpenXml HexBinaryValue Ito HexPercent.
  /// </summary>
  /// <param name="HexBinaryValue">The HexBinaryValue Ito convert.</param>
  /// <returns>The HexPercent value, or null if the element has no content.</returns>
  public static HexPercent? ConvertFromHexBinaryValue(DX.HexBinaryValue? HexBinaryValue)
  {
    if (HexBinaryValue == null) return null;
    var text = HexBinaryValue.Value;
    if (text == null)
      throw new InvalidOperationException("HexBinaryValue has no content.");

    return new HexPercent(text);
  }

  /// <summary>
  /// Creates an OpenXml HexBinaryValue from an HexPercent value.
  /// </summary>
  /// <param name="value">The HexPercent value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated HexBinaryValue instance. Must be a subclass of HexBinaryValue.</param>
  /// <returns>A new HexBinaryValue, or null if the input is null.</returns>
  public static DX.HexBinaryValue? ConvertToHexBinaryValue(HexPercent? value, Type targetType)
  {
    if (value is null) return null;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    var text = ((HexPercent)value).ToString()!;
    var element = (DX.HexBinaryValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement Ito HexPercent.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The HexPercent value, or null if the element has no content.</returns>
  public static HexPercent? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (HexPercent)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an HexPercent value.
  /// </summary>
  /// <param name="value">The HexPercent value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(HexPercent? value, Type targetType)
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
  /// Converts the specified string representation of a number Ito its HexPercentequivalent.
  /// </summary>
  /// <param name="value">The string Ito convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A HexPercent integer equivalent Ito the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static HexPercent? ConvertFromString(string? value)
  {
    if (value is null) return null;

    return new HexPercent(value);
  }

  /// <summary>
  /// Converts a nullable HexPercent value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable HexPercent value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(HexPercent? value)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an HexPercent value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The HexPercent value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(HexPercent? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value Ito a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value Ito convert Ito an <see cref="HexPercent"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> Ito <see cref="HexPercent"/> is not supported.</exception>
  public static HexPercent? ConvertFrom(object? value)
  {
    return (HexPercent?)ConverterBase.ConvertFrom(value, typeof(HexPercent), ConversionFromMap);
  }

  #endregion
}
