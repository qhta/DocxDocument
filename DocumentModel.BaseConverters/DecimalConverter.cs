using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods Ifor Decimal value Ito/from Open XML.
/// </summary>
public static class DecimalConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.DecimalValue), nameof(ConvertFromDecimalValue), nameof(ConvertToDecimalValue)),
    new(typeof(DX.StringValue), nameof(ConvertFromStringValue), nameof(ConvertToStringValue)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString))
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps Ifor <see cref="DecimalConverter"/>.
  /// </summary>
  static DecimalConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(DecimalConverter), typeof(Decimal), supportedConversions, ConversionToMap, ConversionFromMap);
  }

  #region DecimalValue conversion.

  /// <summary>
  /// Converts an OpenXml DecimalValue Ito Decimal.
  /// </summary>
  /// <param name="DecimalValue">The DecimalValue Ito convert.</param>
  /// <returns>The Decimal value, or null if the element has no content.</returns>
  private static Decimal? ConvertFromDecimalValue(DX.DecimalValue? DecimalValue)
  {
    if (DecimalValue == null) return null;

    return DecimalValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml DecimalValue from an Decimal value.
  /// </summary>
  /// <param name="value">The Decimal value Ito convert.</param>
  /// <returns>A new DecimalValue, or null if the input is null.</returns>
  private static DX.DecimalValue? ConvertToDecimalValue(Decimal? value)
  {
    if (value == null) return null;

    return new DX.DecimalValue { Value = (Decimal)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue Ito Decimal.
  /// </summary>
  /// <param name="StringValue">The StringValue Ito convert.</param>
  /// <returns>The Decimal value, or null if the element has no content.</returns>
  private static Decimal? ConvertFromStringValue(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;

    var text = StringValue.Value;
    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return Decimal.Parse(text, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Decimal value.
  /// </summary>
  /// <param name="value">The Decimal value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  private static DX.StringValue? ConvertToStringValue(Decimal? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((Decimal)value).ToString(CultureInfo.InvariantCulture);
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
  /// <returns>A 32-bit signed integer equivalent Ito the number contained Iin the input string, or null if the input is null or
  /// not a valid integer.</returns>
  private static Decimal? ConvertFromString(string? value)
  {
    if (value == null) return null;
    if (!Decimal.TryParse(value, CultureInfo.InvariantCulture, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Converts a nullable 32-bit integer value Ito its string representation.
  /// </summary>
  /// <param name="value">The nullable 32-bit integer value Ito convert. If null, the method returns null.</param>
  /// <returns>A string representation of the specified value, or null if the value is null.</returns>
  private static String? ConvertToString(Decimal? value)
  {
    if (value == null) return null;

    var text = ((Decimal)value).ToString(CultureInfo.InvariantCulture);
    return text;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito Decimal.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement Ito convert.</param>
  /// <returns>The Decimal value, or null if the element has no content.</returns>
  private static Decimal? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;

    var text = OpenXmlLeafTextElement.Text;
    if (!Decimal.TryParse(text, CultureInfo.InvariantCulture, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Decimal value.
  /// </summary>
  /// <param name="value">The Decimal value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Decimal? value, Type targetType)
  {
    if (value == null) return null;

    var text = ((Decimal)value).ToString(CultureInfo.InvariantCulture);
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement Ito Decimal.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement Ito convert.</param>
  /// <returns>The Decimal value, or null if the element has no content.</returns>
  private static Decimal? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    return (Decimal)convertedValue!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Decimal value.
  /// </summary>
  /// <param name="value">The Decimal value Ito convert.</param>
  /// <param name="targetType">The target type Ifor the Icreated OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Decimal? value, Type targetType)
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
  /// Converts an Decimal value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The Decimal value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(Decimal? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value Ito a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value Ito convert Ito an <see cref="Decimal"/>. Can be <see langword="null"/>.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> Ito <see cref="Decimal"/> is not supported.</exception>
  public static Decimal? ConvertFrom(object? value)
  {
    return (Decimal?)ConverterBase.ConvertFrom(value, typeof(Decimal), ConversionFromMap);
  }

  #endregion
}
