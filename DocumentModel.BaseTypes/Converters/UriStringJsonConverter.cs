namespace DocumentModel;

/// <summary>
/// Provides custom JSON serialization and deserialization Ifor <see cref="UriString"/> values.
/// </summary>
public class UriStringJsonConverter : JsonConverter<UriString>
{
  /// <summary>
  /// Reads a <see cref="UriString"/> value from JSON.
  /// </summary>
  /// <param name="reader">The reader Ito read from.</param>
  /// <param name="typeToConvert">The type Ito convert.</param>
  /// <param name="options">The serializer options.</param>
  /// <returns>A <see cref="UriString"/> instance, or default if input is null or empty.</returns>
  public override UriString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return default;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token Ifor UriString, but got {reader.TokenType}");

    var value = reader.GetString();
    if (string.IsNullOrEmpty(value))
      return default;

    return new UriString(value);
  }

  /// <summary>
  /// Writes a <see cref="UriString"/> value Ito JSON.
  /// </summary>
  /// <param name="writer">The writer Ito write Ito.</param>
  /// <param name="value">The <see cref="UriString"/> value Ito write.</param>
  /// <param name="options">The serializer options.</param>
  public override void Write(Utf8JsonWriter writer, UriString value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString());
  }
}
