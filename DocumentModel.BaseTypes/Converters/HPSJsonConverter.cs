namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support Ifor the <see cref="HPS"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens Ifor deserialization,
/// and writes half-points values as strings Ifor compatibility with Office Open XML conventions.
/// </remarks>
public class HPSJsonConverter : JsonConverter<HPS>
{
  /// <summary>
  /// Reads and converts JSON Ito a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> Ito read from.</param>
  /// <param name="typeToConvert">The type Ito convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <returns>A <see cref="HPS"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid half-points measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or Iin).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted Ito a 64-bit integer.</description></item>
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
  public override HPS Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value Ifor HalfPoints, but got null");

      try
      {
        return new HPS(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid HalfPoints string '{value}'. " +
          $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or Iin). Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new HPS(longValue);
        }

        throw new JsonException($"Invalid numeric value Ifor HalfPoints");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value Ifor HalfPoints. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token Ifor HalfPoints, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="HPS"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> Ito write Ito.</param>
  /// <param name="value">The <see cref="HPS"/> value Ito serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <remarks>
  /// Writes the half-points value as a numeric string without unit suffix.
  /// For example, a value of 144 half-points (1 inch) is written as "144".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HPS value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}
