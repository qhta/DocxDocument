using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexInt values as hexadecimal strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that HexInt values are written as hexadecimal string values in JSON output
///   (e.g., "A1B2C3D4") rather than complex objects or numeric values. During deserialization, the converter
///   reads string values and constructs HexInt instances from them.
///   </para>
///   <para>
///   The hexadecimal string format maintains compatibility with Office Open XML specifications while
///   providing human-readable JSON output. The converter handles null values appropriately and validates
///   that input strings contain only valid hexadecimal characters.
///   </para>
///   <para>
///   This converter is automatically applied to HexInt properties when the type is used in JSON serialization,
///   ensuring consistent hexadecimal string representation across all JSON operations.
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
  ///   The input string must contain only valid hexadecimal characters (0-9, A-F, a-f) and have an even length.
  ///   The method accepts both uppercase and lowercase hexadecimal digits.
  ///   </para>
  ///   <para>
  ///   Examples of valid input: "A1B2", "0F1E2D", "AABBCCDD", "00112233"
  ///   </para>
  /// </remarks>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or when the string cannot be parsed as a valid hexadecimal value.
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
    catch (Exception ex)
    {
      throw new JsonException($"Invalid hexadecimal string '{value}' for HexInt", ex);
    }
  }

  /// <summary>
  ///   Writes a HexInt value to JSON as a hexadecimal string.
  /// </summary>
  /// <param name="writer">The JSON writer to write to.</param>
  /// <param name="value">The HexInt value to write.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <remarks>
  ///   <para>
  ///   The HexInt value is written as a simple string value containing only hexadecimal characters.
  ///   The output string uses uppercase hexadecimal digits by default and has an even length.
  ///   </para>
  ///   <para>
  ///   Example outputs: "A1B2C3D4", "0F1E2D3C", "00112233"
  ///   </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HexInt value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture)??"");
  }
}