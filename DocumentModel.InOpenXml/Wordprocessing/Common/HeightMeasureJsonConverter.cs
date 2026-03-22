namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="HeightMeasure"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes HeightMeasure values as strings for compatibility with Office Open XML conventions.
/// </remarks>
public class HeightMeasureJsonConverter : JsonConverter<DMW.HeightMeasure>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="HeightMeasure"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="HeightMeasure"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid HeightMeasure measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with numeric values and optional unit suffixes (e.g., "1440", "1in", "72pt", "25.4mm", "2.54cm", "50%)</description></item>
  /// <item><description>Literal string tokens like "auto" or "nil" (interpreted as special values)</description></item>
  /// <item><description>Numeric tokens as integer values representing HeightMeasure directly</description></item>
  /// </list>
  /// </remarks>
  public override DMW.HeightMeasure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for HeightMeasure, but got null");
      try
      {
        return new DMW.HeightMeasure(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid HeightMeasure string '{value}'. " +
          $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
      }
    }
    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new HeightMeasure(longValue);
        }
        if (reader.TryGetUInt64(out ulong ulongValue))
        {
          return new HeightMeasure(ulongValue);
        }
        if (reader.TryGetDecimal(out decimal decimalValue))
        {
          return new HeightMeasure(decimalValue);
        }
        if (reader.TryGetDouble(out double doubleValue))
        {
          return new HeightMeasure(doubleValue);
        }
        throw new JsonException($"Invalid numeric value for HeightMeasure");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for HeightMeasure. Error: {ex.Message}", ex);
      }
    }
    throw new JsonException($"Expected string or number token for HeightMeasure, but got {reader.TokenType}");
  }
  /// <summary>
  /// Writes a <see cref="HeightMeasure"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="HeightMeasure"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the HeightMeasure value as a numeric string without unit suffix.
  /// For example, a value of 1440 HeightMeasure is written as "1440".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, DMW.HeightMeasure value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString());
  }
}