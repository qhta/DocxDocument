namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="StringList"/> class.
/// </summary>
/// <remarks>
/// This converter handles string, array, and object JSON tokens for deserialization,
/// and writes StringList values as JSON arrays for compatibility with standard JSON conventions.
/// </remarks>
public class StringListJsonConverter : JsonConverter<StringList>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="StringList"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="StringList"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The JSON token is an array but contains non-string values.</description></item>
  /// <item><description>The JSON token is none of the expected types (string, array, or null).</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with comma-separated values (e.g., "apple,banana,cherry" or "item1, item2, item3")</description></item>
  /// <item><description>Array tokens with string elements (e.g., ["apple", "banana", "cherry"])</description></item>
  /// <item><description>Null tokens (returns null)</description></item>
  /// </list>
  /// </remarks>
  public override StringList? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return null;
    }

    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        return null;

      try
      {
        return new StringList(value);
      }
      catch (Exception ex)
      {
        throw new JsonException($"Invalid StringList string '{value}'. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.StartArray)
    {
      var list = new StringList();

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndArray)
        {
          return list;
        }

        if (reader.TokenType == JsonTokenType.String)
        {
          var item = reader.GetString();
          if (item != null)
          {
            list.Add(item);
          }
        }
        else if (reader.TokenType == JsonTokenType.Null)
        {
          // Skip null values in array
          continue;
        }
        else
        {
          throw new JsonException($"Expected string value in array for StringList, but got {reader.TokenType}");
        }
      }

      throw new JsonException($"Unexpected end of JSON array for StringList");
    }

    throw new JsonException($"Expected string, array, or null token for StringList, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="StringList"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="StringList"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the StringList value as a JSON array of strings.
  /// For example, a list containing "apple", "banana", "cherry" is written as ["apple", "banana", "cherry"].
  /// If the value is null, a JSON null is written.
  /// If the list is empty, an empty array [] is written.
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, StringList? value, JsonSerializerOptions options)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    writer.WriteStartArray();
    foreach (var item in value)
    {
      writer.WriteStringValue(item);
    }
    writer.WriteEndArray();
  }
}