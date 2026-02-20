using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexInt values as 8-character hexadecimal strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that HexInt values are written as hexadecimal string values in JSON output
///   (e.g., "0000007B", "FFFFFFFF") rather than numeric values or complex objects. During deserialization,
///   the converter reads string values and constructs HexInt instances from them.
///   </para>
///   <para>
///   The hexadecimal string format maintains compatibility with Office Open XML specifications while
///   providing human-readable JSON output. HexInt always uses an 8-character uppercase format with
///   leading zeros to represent 32-bit integer values consistently.
///   </para>
///   <para>
///   All output uses uppercase hexadecimal digits (A-F) for consistency. During deserialization, both
///   uppercase and lowercase hex digits are accepted, and the converter validates that input strings
///   contain only valid hexadecimal characters.
///   </para>
///   <para>
///   <b>JSON Format Examples:</b>
///   <code>
///   // Serialization output
///   {
///     "revisionId": "0000007B",        // 123 decimal
///     "documentHash": "DEADBEEF",      // -559038737 decimal
///     "colorValue": "FF0000FF",        // ARGB red color
///     "negativeOne": "FFFFFFFF",       // -1 decimal
///     "zero": "00000000"               // 0 decimal
///   }
///   
///   // Deserialization accepts
///   "0000007B"   // uppercase
///   "0000007b"   // lowercase
///   "7B"         // without leading zeros (parsed correctly)
///   "FFFFFFFF"   // maximum/negative values
///   </code>
///   </para>
///   <para>
///   <b>Usage Context:</b> This converter is automatically applied to HexInt properties when the type
///   is used in JSON serialization, ensuring consistent 8-character hexadecimal string representation
///   across all JSON operations in Office Open XML document processing.
///   </para>
/// </remarks>
public class HexIntJsonConverter : JsonConverter<HexInt>
{
  /// <summary>
  ///   Reads a HexInt value from JSON as a hexadecimal string.
  /// </summary>
  /// <param name="reader">The JSON reader to read from.</param>
  /// <param name="typeToConvert">The type of object to convert to.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  ///   A HexInt value constructed from the hexadecimal string, or a default HexInt if the value is null or empty.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The input string must contain only valid hexadecimal characters (0-9, A-F, a-f) and should represent
  ///   a 32-bit integer value. The method accepts both uppercase and lowercase hexadecimal digits and handles
  ///   strings with or without leading zeros.
  ///   </para>
  ///   <para>
  ///   <b>Examples of valid input:</b>
  ///   <list type="bullet">
  ///   <item><description>"7B" or "0000007B" → HexInt(123)</description></item>
  ///   <item><description>"DEADBEEF" → HexInt(-559038737)</description></item>
  ///   <item><description>"00000000" → HexInt(0)</description></item>
  ///   <item><description>"FFFFFFFF" → HexInt(-1)</description></item>
  ///   <item><description>"7FFFFFFF" → HexInt(2147483647) - maximum positive</description></item>
  ///   <item><description>"80000000" → HexInt(-2147483648) - minimum negative</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Null or empty JSON values result in a default HexInt (value 0). This allows for consistent
  ///   handling of absent data in JSON documents.
  ///   </para>
  /// </remarks>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or when the string cannot be parsed as a valid
  ///   hexadecimal value representing a 32-bit integer.
  /// </exception>
  public override HexInt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return default;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token for HexInt, but got {reader.TokenType}");

    var value = reader.GetString();
    if (string.IsNullOrEmpty(value))
      return default;

    try
    {
      return new HexInt(value);
    }
    catch (FormatException ex)
    {
      throw new JsonException($"Invalid hexadecimal string '{value}' for HexInt. Expected hex digits (0-9, A-F) representing a 32-bit integer.", ex);
    }
    catch (OverflowException ex)
    {
      throw new JsonException($"Hexadecimal value '{value}' is out of range for HexInt. Must represent a 32-bit signed integer.", ex);
    }
  }

  /// <summary>
  ///   Writes a HexInt value to JSON as an 8-character hexadecimal string.
  /// </summary>
  /// <param name="writer">The JSON writer to write to.</param>
  /// <param name="value">The HexInt value to write.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <remarks>
  ///   <para>
  ///   The HexInt value is written as a simple string value containing exactly 8 uppercase hexadecimal
  ///   characters with leading zeros. This fixed-width format ensures consistency across all JSON output
  ///   and maintains compatibility with Office Open XML standards.
  ///   </para>
  ///   <para>
  ///   All output uses uppercase hexadecimal digits (0-9, A-F) and includes leading zeros to maintain
  ///   the 8-character format regardless of the actual value.
  ///   </para>
  ///   <para>
  ///   <b>Output examples:</b>
  ///   <list type="bullet">
  ///   <item><description>HexInt(0) → "00000000"</description></item>
  ///   <item><description>HexInt(1) → "00000001"</description></item>
  ///   <item><description>HexInt(123) → "0000007B"</description></item>
  ///   <item><description>HexInt(255) → "000000FF"</description></item>
  ///   <item><description>HexInt(256) → "00000100"</description></item>
  ///   <item><description>HexInt(65536) → "00010000"</description></item>
  ///   <item><description>HexInt(-1) → "FFFFFFFF"</description></item>
  ///   <item><description>HexInt(-559038737) → "DEADBEEF"</description></item>
  ///   <item><description>HexInt(2147483647) → "7FFFFFFF" (max positive)</description></item>
  ///   <item><description>HexInt(-2147483648) → "80000000" (min negative)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The 8-character format is fixed and does not vary based on the value, ensuring predictable
  ///   JSON structure and simplifying parsing operations in consuming applications.
  ///   </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HexInt value, JsonSerializerOptions options)
  {
    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    writer.WriteStringValue(value.ToString());
  }
}