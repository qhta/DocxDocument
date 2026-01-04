namespace DocumentModel;

/// <summary>
///   XML type converter that handles conversion of HexChar values to and from hexadecimal string representation.
/// </summary>
/// <remarks>
///   <para>
///   This converter provides bidirectional conversion between HexChar values and their hexadecimal string
///   representations for XML serialization through the .NET type conversion infrastructure. HexChar represents
///   Unicode character codes (0-65535) stored as hexadecimal strings in Office Open XML documents.
///   </para>
///   <para>
///   The converter ensures consistent hexadecimal formatting based on value range:
///   <list type="bullet">
///   <item><description><b>ASCII range (0-255):</b> 2-digit hexadecimal format (e.g., "41" for 'A')</description></item>
///   <item><description><b>Extended range (256-65535):</b> 4-digit hexadecimal format (e.g., "03B1" for Greek alpha α)</description></item>
///   </list>
///   </para>
///   <para>
///   All hexadecimal strings use uppercase letters (A-F) for consistency with Office Open XML specifications.
///   During deserialization, the converter accepts both uppercase and lowercase hexadecimal digits.
///   </para>
///   <para>
///   <b>Usage Context:</b> This converter is automatically invoked by the XML serialization framework when
///   processing HexChar properties in Office Open XML document parts, including character codes, symbol
///   identifiers, and Unicode character references in Word, Excel, and PowerPoint documents.
///   </para>
/// </remarks>
public class HexCharXmlConverter : TypeConverter
{
  /// <summary>
  ///   Determines whether this converter can convert from the specified source type to a HexChar.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="sourceType">
  ///   A <see cref="Type"/> that represents the type to convert from.
  /// </param>
  /// <returns>
  ///   <see langword="true"/> if the source type is <see cref="String"/>; otherwise <see langword="false"/>.
  /// </returns>
  /// <remarks>
  ///   This converter only supports conversion from string type, which should contain a valid hexadecimal
  ///   representation of a character code (2 or 4 hex digits).
  /// </remarks>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  ///   Determines whether this converter can convert a HexChar to the specified destination type.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="destinationType">
  ///   A <see cref="Type"/> that represents the type to convert to.
  /// </param>
  /// <returns>
  ///   <see langword="true"/> if the destination type is <see cref="String"/>; otherwise <see langword="false"/>.
  /// </returns>
  /// <remarks>
  ///   This converter only supports conversion to string type, which produces a hexadecimal string
  ///   representation suitable for XML serialization.
  /// </remarks>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  /// <summary>
  ///   Converts a hexadecimal string to a HexChar object.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="culture">
  ///   A <see cref="CultureInfo"/>. This parameter is ignored as hexadecimal parsing is culture-invariant.
  /// </param>
  /// <param name="value">
  ///   The string to convert. Must contain a valid hexadecimal character code (2 or 4 hex digits).
  /// </param>
  /// <returns>
  ///   A HexChar object representing the parsed character code.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The conversion delegates to the HexChar constructor, which parses the hexadecimal string using
  ///   <see cref="NumberStyles.HexNumber"/>. The parsing accepts both uppercase and lowercase hex digits.
  ///   </para>
  ///   <para>
  ///   <b>Example conversions:</b>
  ///   <list type="bullet">
  ///   <item><description>"41" → HexChar(65) representing 'A'</description></item>
  ///   <item><description>"20" → HexChar(32) representing space character</description></item>
  ///   <item><description>"03B1" → HexChar(945) representing Greek alpha (α)</description></item>
  ///   <item><description>"FFFF" → HexChar(65535) representing maximum BMP character</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The culture parameter is ignored because hexadecimal number parsing is culture-independent.
  ///   </para>
  /// </remarks>
  /// <exception cref="NotSupportedException">
  ///   Thrown when the source type is not <see cref="String"/>.
  /// </exception>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds 65535 (ushort.MaxValue).
  /// </exception>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
      return new HexChar(str);
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  ///   Converts a HexChar value to its hexadecimal string representation.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="culture">
  ///   A <see cref="CultureInfo"/>. This parameter is ignored as hexadecimal formatting is culture-invariant.
  /// </param>
  /// <param name="value">
  ///   The HexChar object to convert.
  /// </param>
  /// <param name="destinationType">
  ///   The <see cref="Type"/> to convert to. This should be <see cref="String"/>.
  /// </param>
  /// <returns>
  ///   A hexadecimal string representation of the HexChar value, or null if the value is null or not a HexChar.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The conversion delegates to the HexChar.ToString() method, which produces a hexadecimal string
  ///   with automatic formatting based on the value range:
  ///   <list type="bullet">
  ///   <item><description>Values 0-255: 2-digit uppercase hex (e.g., "41", "FF")</description></item>
  ///   <item><description>Values 256-65535: 4-digit uppercase hex (e.g., "0100", "FFFF")</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   <b>Example conversions:</b>
  ///   <list type="bullet">
  ///   <item><description>HexChar(65) → "41"</description></item>
  ///   <item><description>HexChar(32) → "20"</description></item>
  ///   <item><description>HexChar(945) → "03B1"</description></item>
  ///   <item><description>HexChar(256) → "0100"</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The culture parameter is ignored because hexadecimal formatting is culture-independent.
  ///   All output uses uppercase hexadecimal digits for consistency with Office Open XML standards.
  ///   </para>
  /// </remarks>
  /// <exception cref="NotSupportedException">
  ///   Thrown when destinationType is not <see cref="String"/>.
  /// </exception>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is HexChar hexChar)
      return hexChar.ToString(CultureInfo.InvariantCulture);
    return base.ConvertTo(context, culture, value, destinationType);
  }
}