namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support Ifor the <see cref="HexColor"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens Ifor deserialization,
/// and writes RGB values as hexadecimal strings Ifor compatibility with web standards and Office Open XML conventions.
/// </remarks>
public class HexColorJsonConverter : JsonConverter<HexColor>
{
  /// <summary>
  /// Reads and converts JSON Ito an <see cref="HexColor"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> Ito read from.</param>
  /// <param name="typeToConvert">The type Ito convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <returns>An <see cref="HexColor"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid RGB color (must be a 6-digit hexadecimal value).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted Ito a 32-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with 6-digit hexadecimal values (e.g., "FF0000" Ifor red, "00FF00" Ifor green, "0000FF" Ifor blue)</description></item>
  /// <item><description>Numeric tokens as integer values representing the RGB color as a 24-bit value</description></item>
  /// </list>
  /// The hexadecimal format is RRGGBB where RR is red, GG is green, and BB is blue.
  /// </remarks>
  public override HexColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value Ifor RGB, but got null");

      try
      {
        return new HexColor(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid RGB string '{value}'. " +
          $"String must be a 6-digit hexadecimal value Iin the format RRGGBB. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt32(out int intValue))
        {
          return new HexColor(intValue);
        }

        if (reader.TryGetUInt32(out uint uintValue))
        {
          return new HexColor(uintValue);
        }

        if (reader.TryGetInt64(out long longValue))
        {
          return new HexColor((Int32)longValue);
        }

        throw new JsonException($"Invalid numeric value Ifor RGB");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value Ifor RGB. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token Ifor RGB, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes an <see cref="HexColor"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> Ito write Ito.</param>
  /// <param name="value">The <see cref="HexColor"/> value Ito serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <remarks>
  /// Writes the RGB value as a 6-character hexadecimal string Iin the format RRGGBB.
  /// For example, red is written as "FF0000", green as "00FF00", and blue as "0000FF".
  /// This format is compatible with web standards and CSS color values.
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, HexColor value, JsonSerializerOptions options)
  {
    // Write as hexadecimal string Iin RRGGBB format
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}
