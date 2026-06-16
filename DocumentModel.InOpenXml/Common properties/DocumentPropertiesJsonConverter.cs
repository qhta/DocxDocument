namespace DocumentModel;

/// <summary>
/// Converts <see cref="DocumentProperties"/> to and from JSON.
/// </summary>
public class DocumentPropertiesJsonConverter : JsonConverter<DocumentProperties>
{
  /// <summary>
  /// Reads JSON and deserializes it into <see cref="DocumentProperties"/>.
  /// </summary>
  /// <param name="reader">The JSON reader.</param>
  /// <param name="typeToConvert">The target type.</param>
  /// <param name="options">Serializer options.</param>
  /// <returns>The deserialized <see cref="DocumentProperties"/> instance.</returns>
  /// <exception cref="JsonException">Thrown when the JSON structure is invalid.</exception>
  public override DocumentProperties? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return null;

    if (reader.TokenType != JsonTokenType.StartArray)
      throw new JsonException("DocumentProperties JSON must be an array.");

    var result = new DocumentProperties();

    while (reader.Read())
    {
      if (reader.TokenType == JsonTokenType.EndArray)
        return result;

      using var jsonDocument = JsonDocument.ParseValue(ref reader);
      var element = jsonDocument.RootElement;
      var itemJson = element.GetRawText();

      DocumentProperty? property;
      if (element.TryGetProperty("PropertyId", out _))
        property = JsonSerializer.Deserialize<CustomProperty>(itemJson, options);
      else
        property = JsonSerializer.Deserialize<BuiltInProperty>(itemJson, options);

      if (property != null)
        result.Add(property);
    }

    throw new JsonException("Invalid JSON while reading DocumentProperties.");
  }

  /// <summary>
  /// Writes <see cref="DocumentProperties"/> as JSON.
  /// </summary>
  /// <param name="writer">The JSON writer.</param>
  /// <param name="value">The value to serialize.</param>
  /// <param name="options">Serializer options.</param>
  public override void Write(Utf8JsonWriter writer, DocumentProperties value, JsonSerializerOptions options)
  {
    writer.WriteStartArray();
    foreach (var property in value)
    {
      if (property is CustomProperty customProperty)
      {
        JsonSerializer.Serialize(writer, customProperty, options);
        continue;
      }

      if (property is BuiltInProperty builtInProperty)
      {
        JsonSerializer.Serialize(writer, builtInProperty, options);
        continue;
      }

      JsonSerializer.Serialize(writer, property, property.GetType(), options);
    }

    writer.WriteEndArray();
  }
}