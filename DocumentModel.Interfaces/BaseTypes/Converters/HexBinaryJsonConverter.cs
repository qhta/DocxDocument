namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexBinary values as hexadecimal strings.
/// </summary>
/// <remarks>
///   This converter ensures that HexBinary values are written as simple string values in JSON output
///   (e.g., "A1B2C3") rather than complex objects or byte arrays. During deserialization, the converter
///   reads string values and constructs HexBinary instances from them.
/// </remarks>
public class HexBinaryJsonConverter : System.Text.Json.Serialization.JsonConverter<HexBinary>
{
  /// <summary>
  ///   Reads a HexBinary value from JSON as a string.
  /// </summary>
  public override HexBinary? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return null;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token for HexBinary, but got {reader.TokenType}");

    string? hexString = reader.GetString();
    if (string.IsNullOrEmpty(hexString))
      return null;

    // Create instance using the concrete implementation class
    var hexBinary = CreateHexBinaryInstance();
    hexBinary.FromString(hexString);
    return hexBinary;
  }

  /// <summary>
  ///   Writes a HexBinary value to JSON as a string.
  /// </summary>
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

  /// <summary>
  ///   Creates an instance of the concrete HexBinary implementation.
  /// </summary>
  /// <remarks>
  ///   This method should be updated to use your concrete implementation class.
  ///   Replace 'HexBinaryImpl' with your actual implementation class name.
  /// </remarks>
  private static HexBinary CreateHexBinaryInstance()
  {
    return new HexBinary(Array.Empty<byte>());
  }
}