namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref = "PixelsMeasure"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes PixelsMeasure values as strings for compatibility with Office Open XML conventions.
/// </remarks>
[DataContract]
[XmlRoot("PixelsMeasureJsonConverter", Namespace = "DocumentModel.Wordprocessing")]
public class PixelsMeasureJsonConverter : JsonConverter<DMW.PixelsMeasure>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref = "PixelsMeasure"/> value.
  /// </summary>
  /// <param name = "reader">The <see cref = "Utf8JsonReader"/> to read from.</param>
  /// <param name = "typeToConvert">The type to convert.</param>
  /// <param name = "options">The <see cref = "JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref = "PixelsMeasure"/> value parsed from the JSON input.</returns>
  /// <exception cref = "JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid PixelsMeasure measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  public override DMW.PixelsMeasure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for PixelsMeasure, but got null");
      try
      {
        return new DMW.PixelsMeasure(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid PixelsMeasure string '{value}'. " + $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new PixelsMeasure(longValue);
        }

        if (reader.TryGetUInt64(out ulong ulongValue))
        {
          return new PixelsMeasure(ulongValue);
        }

        if (reader.TryGetDecimal(out decimal decimalValue))
        {
          return new PixelsMeasure(decimalValue);
        }

        if (reader.TryGetDouble(out double doubleValue))
        {
          return new PixelsMeasure(doubleValue);
        }

        throw new JsonException($"Invalid numeric value for PixelsMeasure");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for PixelsMeasure. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for PixelsMeasure, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref = "PixelsMeasure"/> value as JSON.
  /// </summary>
  /// <param name = "writer">The <see cref = "Utf8JsonWriter"/> to write to.</param>
  /// <param name = "value">The <see cref = "PixelsMeasure"/> value to serialize.</param>
  /// <param name = "options">The <see cref = "JsonSerializerOptions"/> to use.</param>
  public override void Write(Utf8JsonWriter writer, DMW.PixelsMeasure value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString());
  }
}