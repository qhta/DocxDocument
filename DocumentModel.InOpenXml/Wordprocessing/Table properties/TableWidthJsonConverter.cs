namespace DocumentModel.Wordprocessing;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="TableWidth"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes TableWidth values as strings for compatibility with Office Open XML conventions.
/// </remarks>
public class TableWidthJsonConverter : JsonConverter<DMW.TableWidth>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="TableWidth"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="TableWidth"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid TableWidth measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with numeric values and optional unit suffixes (e.g., "1440", "1in", "72pt", "25.4mm", "2.54cm")</description></item>
  /// <item><description>Numeric tokens as integer values representing TableWidth directly</description></item>
  /// </list>
  /// </remarks>
  public override DMW.TableWidth Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for TableWidth, but got null");

      try
      {
        return new DMW.TableWidth(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid TableWidth string '{value}'. " +
          $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt64(out long longValue))
        {
          return new TableWidth(longValue);
        }

        if (reader.TryGetUInt64(out ulong ulongValue))
        {
          return new TableWidth(ulongValue);
        }

        if (reader.TryGetDecimal(out decimal decimalValue))
        {
          return new TableWidth(decimalValue);
        }

        if (reader.TryGetDouble(out double doubleValue))
        {
          return new TableWidth(doubleValue);
        }

        throw new JsonException($"Invalid numeric value for TableWidth");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for TableWidth. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for TableWidth, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="TableWidth"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="TableWidth"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the TableWidth value as a numeric string without unit suffix.
  /// For example, a value of 1440 TableWidth is written as "1440".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, DMW.TableWidth value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString());
  }
}