using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexBinary values as hexadecimal strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that HexBinary values are written as simple string values in JSON output
///   (e.g., "A1B2C3", "DEADBEEF") rather than complex objects or byte arrays. During deserialization,
///   the converter reads string values and constructs new HexBinary instances from them.
///   </para>
///   <para>
///   The hexadecimal string format maintains compatibility with Office Open XML specifications while
///   providing human-readable JSON output. The converter validates that input strings contain only
///   valid hexadecimal characters (0-9, A-F, a-f) and have even length.
///   </para>
///   <para>
///   All output uses uppercase hexadecimal digits (A-F) for consistency. During deserialization, both
///   uppercase and lowercase hex digits are accepted.
///   </para>
///   <para>
///   <b>JSON Examples:</b>
///   <code>
///   // Serialization
///   { "binaryData": "DEADBEEF" }
///   { "hash": "A1B2C3D4E5F6" }
///   { "empty": "" }
///   { "nullValue": null }
///   
///   // Deserialization accepts
///   "DEADBEEF"  // uppercase
///   "deadbeef"  // lowercase
///   "DeAdBeEf"  // mixed case
///   ""          // empty string
///   null        // null value
///   </code>
///   </para>
/// </remarks>
public class HexBinaryJsonConverter : JsonConverter<HexBinary>
{
  /// <summary>
  ///   Reads a HexBinary value from JSON as a hexadecimal string.
  /// </summary>
  /// <param name="reader">The JSON reader to read from.</param>
  /// <param name="typeToConvert">The type of object to convert to.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  ///   A new HexBinary instance constructed from the hexadecimal string, or null if the JSON value is null.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The input string must contain only valid hexadecimal characters (0-9, A-F, a-f) and must have
  ///   an even length (each byte requires two hex digits). The method accepts both uppercase and
  ///   lowercase hexadecimal digits.
  ///   </para>
  ///   <para>
  ///   <b>Examples of valid input:</b>
  ///   <list type="bullet">
  ///   <item><description>"DEADBEEF" → HexBinary with 4 bytes</description></item>
  ///   <item><description>"A1B2C3" → HexBinary with 3 bytes</description></item>
  ///   <item><description>"" or null → Returns null</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Empty strings and null values both result in null being returned. This allows for
  ///   consistent handling of absent data in JSON documents.
  ///   </para>
  /// </remarks>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or null, or when the string cannot be parsed
  ///   as a valid hexadecimal value (invalid characters or odd length).
  /// </exception>
  public override HexBinary? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return null;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token for HexBinary, but got {reader.TokenType}");

    string? hexString = reader.GetString();
    if (string.IsNullOrEmpty(hexString))
      return null;

    try
    {
      // Create a new HexBinary instance directly using the constructor
      // This maintains immutability by creating a new instance rather than modifying an existing one
      return new HexBinary(hexString);
    }
    catch (InvalidOperationException ex)
    {
      throw new JsonException($"Invalid hexadecimal string '{hexString}' for HexBinary. " +
        $"Expected even-length string with hex digits (0-9, A-F). Error: {ex.Message}", ex);
    }
    catch (FormatException ex)
    {
      throw new JsonException($"Invalid hexadecimal format in string '{hexString}' for HexBinary. " +
        $"String must contain only valid hex characters (0-9, A-F, a-f). Error: {ex.Message}", ex);
    }
  }

  /// <summary>
  ///   Writes a HexBinary value to JSON as a hexadecimal string.
  /// </summary>
  /// <param name="writer">The JSON writer to write to.</param>
  /// <param name="value">The HexBinary value to write.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <remarks>
  ///   <para>
  ///   The HexBinary value is written as a simple string value containing only uppercase hexadecimal
  ///   characters (0-9, A-F). The output format ensures compatibility with Office Open XML standards.
  ///   </para>
  ///   <para>
  ///   Null values are written as JSON null. Empty HexBinary instances (zero bytes) are written as
  ///   empty strings (""), which can be distinguished from null in JSON.
  ///   </para>
  ///   <para>
  ///   <b>Example outputs:</b>
  ///   <list type="bullet">
  ///   <item><description>4 bytes [0xDE, 0xAD, 0xBE, 0xEF] → "DEADBEEF"</description></item>
  ///   <item><description>3 bytes [0xA1, 0xB2, 0xC3] → "A1B2C3"</description></item>
  ///   <item><description>Empty (0 bytes) → ""</description></item>
  ///   <item><description>null → null</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HexBinary? value, JsonSerializerOptions options)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    string hexString = value.ToString();
    writer.WriteStringValue(hexString);
  }
}