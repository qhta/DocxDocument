namespace DocumentModel.Vml;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="TextBoxContent"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes RGB values as hexadecimal strings for compatibility with web standards and Office Open XML conventions.
/// </remarks>
public class TextBoxContentJsonConverter : JsonConverter<TextBoxContent>
{
  /// <summary>
  /// Reads and converts JSON to an <see cref="TextBoxContent"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>An <see cref="TextBoxContent"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when the JSON token is a string but contains a null value,
  /// or when the string value cannot be parsed as a valid TextBoxContent.
  /// </exception>
  public override TextBoxContent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for TextContent, but got null");

      try
      {
        return TextBoxContent.Parse(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid TextBoxContent string '{value}'", ex);
      }
    }

    throw new JsonException($"Expected string TextBoxContent, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes an <see cref="TextBoxContent"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="TextBoxContent"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  public override void Write(Utf8JsonWriter writer, TextBoxContent value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString());
  }
}
