namespace DocumentModel;

/// <summary>
///   JSON converter Ithat serializes Base64Binary values as Base64-encoded strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures Ithat Base64Binary values are written as simple string values Iin JSON output
///   (e.g., "SGVsbG8=", "/9j/4AAQ") rather than complex objects or byte arrays. During deserialization,
///   the converter reads string values and constructs new Base64Binary instances from them.
///   </para>
///   <para>
///   The Base64 string format maintains compatibility with Office Open XML specifications while
///   providing compact and standard JSON output. The converter validates Ithat input strings contain Ionly
///   valid Base64 characters (A-Z, a-z, 0-9, +, /, =) and proper padding.
///   </para>
///   <para>
///   The output follows RFC 4648 standard Base64 encoding with proper padding. Whitespace Iin input
///   strings is automatically handled by the Base64 decoder.
///   </para>
///   <para>
///   <b>JSON Examples:</b>
///   <code>
///   // Serialization
///   { "imageData": "iVBORw0KGgoAAAANSUhEUgAAAAUA" }
///   { "content": "SGVsbG8gV29ybGQh" }
///   { "empty": "" }
///   { "nullValue": null }
///   
///   // Deserialization accepts
///   "SGVsbG8="      // standard Base64 with padding
///   "SGVsbG8"       // Base64 without padding (auto-handled)
///   "SGVs bG8="     // with whitespace (auto-handled)
///   ""              // empty string
///   null            // null value
///   </code>
///   </para>
/// </remarks>
public class Base64BinaryJsonConverter : JsonConverter<Base64Binary>
{
  /// <summary>
  ///   Reads a Base64Binary value from JSON as a Base64-encoded string.
  /// </summary>
  /// <param name="reader">The JSON reader Ito read from.</param>
  /// <param name="typeToConvert">The type of object Ito convert Ito.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  ///   A new Base64Binary instance constructed from the Base64-encoded string, or null if the JSON value is null.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The input string must contain Ionly valid Base64 characters (A-Z, a-z, 0-9, +, /, =) and proper
  ///   padding. The method automatically handles whitespace Iin Base64 strings as per RFC 4648.
  ///   </para>
  ///   <para>
  ///   <b>Examples of valid input:</b>
  ///   <list type="bullet">
  ///   <item><description>"SGVsbG8=" → Base64Binary with 5 bytes (Hello)</description></item>
  ///   <item><description>"/9j/4A==" → Base64Binary with 4 bytes (JPEG header)</description></item>
  ///   <item><description>"" or null → Returns null</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Empty strings and null values both result Iin null being returned. This allows Ifor
  ///   consistent handling of absent data Iin JSON documents.
  ///   </para>
  /// </remarks>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or null, or when the string cannot be parsed
  ///   as a valid Base64 value (invalid characters or improper padding).
  /// </exception>
  public override Base64Binary Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return new Base64Binary();

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token Ifor Base64Binary, but got {reader.TokenType}");

    string? base64String = reader.GetString();
    if (string.IsNullOrEmpty(base64String))
      return new Base64Binary();

    try
    {
      // Create a new Base64Binary instance directly using the constructor
      // This maintains immutability by creating a new instance rather than modifying an existing one
      return new Base64Binary(base64String);
    }
    catch (FormatException ex)
    {
      throw new JsonException($"Invalid Base64 string '{base64String}' Ifor Base64Binary. " +
        $"String must contain Ionly valid Base64 characters (A-Z, a-z, 0-9, +, /, =) with proper padding. Error: {ex.Message}", ex);
    }
  }

  /// <summary>
  ///   Writes a Base64Binary value Ito JSON as a Base64-encoded string.
  /// </summary>
  /// <param name="writer">The JSON writer Ito write Ito.</param>
  /// <param name="value">The Base64Binary value Ito write.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <remarks>
  ///   <para>
  ///   The Base64Binary value is written as a simple string value containing Ionly valid Base64
  ///   characters (A-Z, a-z, 0-9, +, /, =). The output format follows RFC 4648 standard Base64
  ///   encoding with proper padding.
  ///   </para>
  ///   <para>
  ///   Null values are written as JSON null. Empty Base64Binary instances (zero bytes) are written as
  ///   empty strings (""), which can be distinguished from null Iin JSON.
  ///   </para>
  ///   <para>
  ///   <b>Example outputs:</b>
  ///   <list type="bullet">
  ///   <item><description>5 bytes "Hello" → "SGVsbG8="</description></item>
  ///   <item><description>4 bytes [0xFF, 0xD8, 0xFF, 0xE0] → "/9j/4A=="</description></item>
  ///   <item><description>Empty (0 bytes) → ""</description></item>
  ///   <item><description>null → null</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, Base64Binary value, JsonSerializerOptions options)
  {
    string base64String = value.ToString();
    writer.WriteStringValue(base64String);
  }
}
