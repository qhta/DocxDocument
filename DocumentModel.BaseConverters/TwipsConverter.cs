using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Twips value to/from Open XML.
/// </summary>
public static class TwipsConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.Int16Value), nameof(ConvertFromInt16Value), nameof(ConvertToInt16Value)),
    new(typeof(DX.Int32Value), nameof(ConvertFromInt32Value), nameof(ConvertToInt32Value)),
    new(typeof(DX.Int64Value), nameof(ConvertFromInt64Value), nameof(ConvertToInt64Value)),
    new(typeof(DX.IntegerValue), nameof(ConvertFromIntegerValue), nameof(ConvertToIntegerValue)),
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
  /// Initializes the conversion maps for <see cref="Int32Converter"/>.
  /// </summary>
  static TwipsConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(TwipsConverter), typeof(Twips), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to Twips.
  /// </summary>
  /// <param name="Int16Value">The Int16Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromInt16Value(DX.Int16Value? Int16Value)
  {
    if (Int16Value == null) return null;

    return Int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  private static DX.Int16Value? ConvertToInt16Value(Twips? value)
  {
    if (value is null) return null;
    if ((decimal)value < (decimal)Int16.MinValue || (decimal)value > (decimal)Int16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int16");

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Twips.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromInt32Value(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  private static DX.Int32Value? ConvertToInt32Value(Twips? value)
  {
    if (value is null) return null;
    if ((double)value < (double)Int32.MinValue || (double)value > (double)Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to Twips.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromInt64Value(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;

    return (Twips)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  private static DX.Int64Value? ConvertToInt64Value(Twips? value)
  {
    if (value is null) return null;

    if ((double)value < Int64.MinValue || (double)value > Int64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Twips");

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to Twips.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromIntegerValue(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;

    return (Twips)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  private static DX.IntegerValue? ConvertToIntegerValue(Twips? value)
  {
    if (value is null) return null;
    if ((double)value < Int64.MinValue || (double)value > Int64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Twips");

    return new DX.IntegerValue { Value = (Int64)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to Twips.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromUInt16Value(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;

    return UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  private static DX.UInt16Value? ConvertToUInt16Value(Twips? value)
  {
    if (value is null) return null;
    if ((double)value < (double)UInt16.MinValue || (double)value > (double)UInt16.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Twips.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;

    return UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  private static DX.UInt32Value? ConvertToUInt32Value(Twips? value)
  {
    if (value is null) return null;
    if ((double)value < (double)UInt32.MinValue || (double)value > (double)UInt32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt32");

    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to Twips.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromUInt64Value(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;

    return (Twips)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  private static DX.UInt64Value? ConvertToUInt64Value(Twips? value)
  {
    if (value is null) return null;

    if ((double)value < UInt64.MinValue || (double)value > UInt64.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Twips");

    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to Twips.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return Twips.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  private static DX.StringValue? ConvertToStringValue(Twips? value, Type targetType)
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
  /// Converts the specified string representation of a number to its 32-bit signed integer equivalent.
  /// </summary>
  /// <param name="value">The string to convert. The string may be null or contain a valid integer representation.</param>
  /// <returns>A 32-bit signed integer equivalent to the number contained in the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static Twips? ConvertFromString(string? value)
  {
    if (value is null) return null;
    if (!Twips.TryParse(value, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 32-bit integer value to its string representation.
  /// </summary>
  /// <param name="value">The nullable 32-bit integer value to convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(Twips? value)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Twips.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!Twips.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Twips? value, Type targetType)
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
  /// Converts an OpenXml OpenXmlLeafElement to Twips.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  private static Twips? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (Twips)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Twips? value, Type targetType)
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
  /// Converts an Twips value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(Twips? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value to convert to an <see cref="Twips"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="Twips"/> is not supported.</exception>
  public static Twips? ConvertFrom(object? value)
  {
    return (Twips?)ConverterBase.ConvertFrom(value, typeof(Twips), ConversionFromMap);
  }

  #endregion
}
