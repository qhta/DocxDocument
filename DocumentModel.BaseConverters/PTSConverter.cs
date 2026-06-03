using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for PTS value Ito/from Open XML.
/// </summary>
public static class PTSConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.Int32Value), nameof(ConvertFromInt32Value), nameof(ConvertToInt32Value)),
    new(typeof(DX.Int64Value), nameof(ConvertFromInt64Value), nameof(ConvertToInt64Value)),
    new(typeof(DX.IntegerValue), nameof(ConvertFromIntegerValue), nameof(ConvertToIntegerValue)),
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
  /// Initializes the conversion maps for <see cref="Int32Converter"/>.
  /// </summary>
  static PTSConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(PTSConverter), typeof(PTS), supportedConversions, ConversionToMap, ConversionFromMap);
  }
  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value Ito PTS.
  /// </summary>
  /// <param name="Int32Value">The Int32Value Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  private static DX.Int32Value? ConvertToInt32Value(PTS? value)
  {
    if (value is null) return null;
    if ((double)value < (double)Int32.MinValue || (double)value > (double)Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value Ito PTS.
  /// </summary>
  /// <param name="Int64Value">The Int64Value Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    
    return (PTS)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  private static DX.Int64Value? ConvertToInt64Value(PTS? value)
  {
    if (value is null) return null;

    if ((double)value < Int64.MinValue || (double)value > Int64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for PTS");

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue Ito PTS.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;

    return (PTS)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  private static DX.IntegerValue? ConvertToIntegerValue(PTS? value)
  {
    if (value is null) return null;
    if ((double)value < Int64.MinValue || (double)value > Int64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for PTS");

    return new DX.IntegerValue { Value = (Int64)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value Ito PTS.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;

    return UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  private static DX.UInt32Value? ConvertToUInt32Value(PTS? value)
  {
    if (value is null) return null;
    if ((double)value < (double)UInt32.MinValue || (double)value > (double)UInt32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt32");

    return new DX.UInt32Value { Value = (UInt32)value };
  }

#endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value Ito PTS.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;

    return (PTS)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  private static DX.UInt64Value? ConvertToUInt64Value(PTS? value)
  {
    if (value is null) return null;

    if ((double)value < UInt64.MinValue || (double)value > UInt64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for PTS");

    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito PTS.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return PTS.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  private static DX.StringValue? ConvertToStringValue(PTS? value, Type targetType)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region String conversion.

  /// <summary>
  /// Converts the specified string representation of a number Ito its 32-bit signed integer equivalent.
  /// </summary>
  /// <param name="value">The string Ito convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A 32-bit signed integer equivalent Ito the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static PTS? ConvertFromString(string? value)
  {
    if (value is null) return null;
    if (!PTS.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 32-bit integer value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable 32-bit integer value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(PTS? value)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito PTS.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!PTS.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(PTS? value, Type targetType)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement Ito PTS.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The PTS value, or null if the element has no content.</returns>
  private static PTS? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (PTS)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an PTS value.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <param name="targetType">The target type for the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(PTS? value, Type targetType)
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

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an PTS value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The PTS value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(PTS? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value Ito a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value Ito convert Ito an <see cref="PTS"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> Ito <see cref="PTS"/> is not supported.</exception>
  public static PTS? ConvertFrom(object? value)
  {
    return (PTS?)ConverterBase.ConvertFrom(value, typeof(PTS), ConversionFromMap);
  }

  #endregion
}
