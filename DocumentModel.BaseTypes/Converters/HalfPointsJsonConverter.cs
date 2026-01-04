namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="HalfPoints"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes half-points values as strings for compatibility with Office Open XML conventions.
/// </remarks>
public class HalfPointsJsonConverter : JsonConverter<HalfPoints>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="HalfPoints"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="HalfPoints"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid half-points measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with numeric values and optional unit suffixes (e.g., "144", "1in", "12pt", "25.4mm", "2.54cm")</description></item>
  /// <item><description>Numeric tokens as integer values representing half-points directly</description></item>
  /// </list>
  /// Note: When using "pt" suffix, the value is multiplied by 2 (e.g., "12pt" becomes 24 half-points).
  /// </remarks>
  public override HalfPoints Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for HalfPoints, but got null");

      try
      {
        return new HalfPoints(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid HalfPoints string '{value}'. " +
          $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new HalfPoints(longValue);
        }

        if (reader.TryGetUInt64(out ulong ulongValue))
        {
          return new HalfPoints(ulongValue);
        }

        // Try as 32-bit integer
        if (reader.TryGetInt32(out int intValue))
        {
          return new HalfPoints(intValue);
        }

        // Try as 32-bit unsigned integer
        if (reader.TryGetUInt32(out uint uintValue))
        {
          return new HalfPoints(uintValue);
        }

        throw new JsonException($"Invalid numeric value for HalfPoints");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for HalfPoints. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for HalfPoints, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="HalfPoints"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="HalfPoints"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the half-points value as a numeric string without unit suffix.
  /// For example, a value of 144 half-points (1 inch) is written as "144".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HalfPoints value, JsonSerializerOptions options)
  {
    // Write as numeric string without unit suffix
    writer.WriteStringValue(((Int64)value).ToString());
  }
}