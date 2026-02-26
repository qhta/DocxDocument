namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="Twips"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes twips values as strings for compatibility with Office Open XML conventions.
/// </remarks>
public class TwipsJsonConverter : JsonConverter<Twips>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="Twips"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid twips measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with numeric values and optional unit suffixes (e.g., "1440", "1in", "72pt", "25.4mm", "2.54cm")</description></item>
  /// <item><description>Numeric tokens as integer values representing twips directly</description></item>
  /// </list>
  /// </remarks>
  public override Twips Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for Twips, but got null");

      try
      {
        return new Twips(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid Twips string '{value}'. " +
          $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new Twips(longValue);
        }

        if (reader.TryGetUInt64(out ulong ulongValue))
        {
          return new Twips(ulongValue);
        }

        if (reader.TryGetDecimal(out decimal decimalValue))
        {
          return new Twips(decimalValue);
        }

        if (reader.TryGetDouble(out double doubleValue))
        {
          return new Twips(doubleValue);
        }

        throw new JsonException($"Invalid numeric value for Twips");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for Twips. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for Twips, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="Twips"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="Twips"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the twips value as a numeric string without unit suffix.
  /// For example, a value of 1440 twips is written as "1440".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, Twips value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}