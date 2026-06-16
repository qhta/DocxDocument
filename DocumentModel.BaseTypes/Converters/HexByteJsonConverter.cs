namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexByte values as hexadecimal strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that HexByte values are written as hexadecimal string values in JSON output
///   (e.g., "41") rather than numeric values or complex objects. During deserialization, the converter
///   reads string values and constructs HexByte instances from them.
///   </para>
///   <para>
///   All output uses uppercase hexadecimal digits (A-F) for consistency. During deserialization, both
///   uppercase and lowercase hex digits are accepted, and the converter validates that input strings
///   contain only valid hexadecimal characters.
///   </para>
///   <para>
///   <b>Usage Context:</b> This converter is automatically applied to HexByte properties when the type
///   is used in JSON serialization, ensuring consistent hexadecimal string representation across all
///   JSON operations in Office Open XML document processing.
///   </para>
/// </remarks>
public class HexByteJsonConverter : JsonConverter<HexByte>
{
  /// <summary>
  ///   Reads a HexByte value from JSON as a hexadecimal string.
  /// </summary>
  /// <param name="reader">The JSON reader to read from.</param>
  /// <param name="typeToConvert">The type of object to convert to.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  ///   A HexByte value constructed from the hexadecimal string, or a default HexByte if the value is null or empty.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The input string must contain only valid hexadecimal characters (0-9, A-F, a-f) and should be
  ///   2 characters long. The method accepts both uppercase and lowercase hexadecimal digits.
  ///   </para>
  /// </remarks>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or when the string cannot be parsed as a valid hexadecimal value.
  /// </exception>
  public override HexByte? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return null;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token for HexByte, but got {reader.TokenType}");

    var str = reader.GetString();
    if (string.IsNullOrEmpty(str))
      return null;

    try
    {
      return new HexByte(str!);
    }
    catch (Exception ex)
    {
      throw new JsonException($"Invalid hexadecimal string '{str}' for HexByte. Expected 2 or 4 hex digits (0-9, A-F).", ex);
    }
  }

  /// <summary>
  ///   Writes a HexByte value to JSON as a hexadecimal string.
  /// </summary>
  /// <param name="writer">The JSON writer to write to.</param>
  /// <param name="value">The HexByte value to write.</param>
  /// <param name="options">The JSON serializer options.</param>
  public override void Write(Utf8JsonWriter writer, HexByte value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}
