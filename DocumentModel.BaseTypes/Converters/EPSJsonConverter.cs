namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="EPS"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes eighth-points values as strings for compatibility with Office Open XML conventions.
/// </remarks>
public class EPSJsonConverter : JsonConverter<EPS>
{
  /// <summary>
  /// Reads and converts JSON to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>An <see cref="EPS"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid eighth-points measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with numeric values and optional unit suffixes (e.g., "576", "1in", "12pt", "25.4mm", "2.54cm")</description></item>
  /// <item><description>Numeric tokens as integer values representing eighth-points directly</description></item>
  /// </list>
  /// Note: When using "pt" suffix, the value is multiplied by 8 (e.g., "12pt" becomes 96 eighth-points).
  /// </remarks>
  public override EPS Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for EighthPoints, but got null");

      try
      {
        return new EPS(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid EighthPoints string '{value}'. " +
          $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new EPS(longValue);
        }

        if (reader.TryGetUInt64(out ulong ulongValue))
        {
          return new EPS(ulongValue);
        }

        // Try as 32-bit integer
        if (reader.TryGetInt32(out int intValue))
        {
          return new EPS(intValue);
        }

        // Try as 32-bit unsigned integer
        if (reader.TryGetUInt32(out uint uintValue))
        {
          return new EPS(uintValue);
        }

        throw new JsonException($"Invalid numeric value for EighthPoints");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for EighthPoints. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for EighthPoints, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes an <see cref="EPS"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="EPS"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the eighth-points value as a numeric string without unit suffix.
  /// For example, a value of 576 eighth-points (1 inch) is written as "576".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, EPS value, JsonSerializerOptions options)
  {
    // Write as numeric string without unit suffix
    writer.WriteStringValue(((Int64)value).ToString());
  }
}