namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="CPS"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes hundredths of a point values as strings for compatibility with Office Open XML conventions.
/// </remarks>
public class CPSJsonConverter : JsonConverter<CPS>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="CPS"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="CPS"/> value parsed from the JSON input.</returns>
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
  /// Note: When using "pt" suffix, the value is multiplied by 100 (e.g., "12pt" becomes 1200 hundredths of a point).
  /// </remarks>
  public override CPS Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for HalfPoints, but got null");

      try
      {
        return new CPS(value);
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
          return new CPS(longValue);
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
  /// Writes a <see cref="CPS"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="CPS"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the hundredths of a point value as a numeric string without unit suffix.
  /// For example, a value of 7200 hundredths of a point (1 inch) is written as "7200".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, CPS value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}
