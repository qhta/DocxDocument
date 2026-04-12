namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexChar values as hexadecimal strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that HexChar values are written as hexadecimal string values in JSON output
///   (e.g., "41", "03B1") rather than numeric values or complex objects. During deserialization, the converter
///   reads string values and constructs HexChar instances from them.
///   </para>
///   <para>
///   The hexadecimal string format maintains compatibility with Office Open XML specifications while
///   providing human-readable JSON output. The converter uses automatic formatting based on value range:
///   <list type="bullet">
///   <item><description><b>ASCII range (0-255):</b> 2-digit format for compact representation</description></item>
///   <item><description><b>Extended range (256-65535):</b> 4-digit format for full Unicode BMP support</description></item>
///   </list>
///   </para>
///   <para>
///   All output uses uppercase hexadecimal digits (A-F) for consistency. During deserialization, both
///   uppercase and lowercase hex digits are accepted, and the converter validates that input strings
///   contain only valid hexadecimal characters.
///   </para>
///   <para>
///   <b>Usage Context:</b> This converter is automatically applied to HexChar properties when the type
///   is used in JSON serialization, ensuring consistent hexadecimal string representation across all
///   JSON operations in Office Open XML document processing.
///   </para>
/// </remarks>
public class HexCharJsonConverter : JsonConverter<HexChar>
{
  /// <summary>
  ///   Reads a HexChar value from JSON as a hexadecimal string.
  /// </summary>
  /// <param name="reader">The JSON reader to read from.</param>
  /// <param name="typeToConvert">The type of object to convert to.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  ///   A HexChar value constructed from the hexadecimal string, or a default HexChar if the value is null or empty.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The input string must contain only valid hexadecimal characters (0-9, A-F, a-f) and should be
  ///   2 or 4 characters long. The method accepts both uppercase and lowercase hexadecimal digits.
  ///   </para>
  ///   <para>
  ///   <b>Examples of valid input:</b>
  ///   <list type="bullet">
  ///   <item><description>"41" → HexChar(65) for 'A'</description></item>
  ///   <item><description>"20" → HexChar(32) for space</description></item>
  ///   <item><description>"03b1" or "03B1" → HexChar(945) for Greek alpha</description></item>
  ///   <item><description>"FFFF" → HexChar(65535) for maximum value</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or when the string cannot be parsed as a valid hexadecimal value.
  /// </exception>
  public override HexChar? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return null;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token for HexChar, but got {reader.TokenType}");

    var str = reader.GetString();
    if (string.IsNullOrEmpty(str))
      return null;

    try
    {
      return new HexChar(str);
    }
    catch (Exception ex)
    {
      throw new JsonException($"Invalid hexadecimal string '{str}' for HexChar. Expected 2 or 4 hex digits (0-9, A-F).", ex);
    }
  }

  /// <summary>
  ///   Writes a HexChar value to JSON as a hexadecimal string.
  /// </summary>
  /// <param name="writer">The JSON writer to write to.</param>
  /// <param name="value">The HexChar value to write.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <remarks>
  ///   <para>
  ///   The HexChar value is written as a simple string value containing only uppercase hexadecimal characters.
  ///   The output format is automatically selected based on the value range:
  ///   <list type="bullet">
  ///   <item><description>Values 0-255: 2-digit format (e.g., "00", "41", "FF")</description></item>
  ///   <item><description>Values 256-65535: 4-digit format (e.g., "0100", "03B1", "FFFF")</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   <b>Example outputs:</b>
  ///   <list type="bullet">
  ///   <item><description>HexChar(0) → "00"</description></item>
  ///   <item><description>HexChar(65) → "41"</description></item>
  ///   <item><description>HexChar(255) → "FF"</description></item>
  ///   <item><description>HexChar(256) → "0100"</description></item>
  ///   <item><description>HexChar(945) → "03B1"</description></item>
  ///   <item><description>HexChar(65535) → "FFFF"</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HexChar value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}