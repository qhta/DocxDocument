namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="PerHundredThousand"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes PerHundredThousandage values as strings with a "%" suffix following Office Open XML conventions.
/// </remarks>
public class PerHundredThousandJsonConverter : JsonConverter<PerHundredThousand>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="PerHundredThousand"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="PerHundredThousand"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The string value cannot be parsed as a valid PerHundredThousandage (must be a number with optional '%' suffix).</description></item>
  /// <item><description>The JSON token is a number but cannot be converted to a double or integer.</description></item>
  /// <item><description>The JSON token is neither a string nor a number.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with numeric values (e.g., "50" or "50%")</description></item>
  /// <item><description>Numeric tokens as double or integer values</description></item>
  /// </list>
  /// </remarks>
  public override PerHundredThousand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for PerHundredThousand, but got null");

      try
      {
        return new PerHundredThousand(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid PerHundredThousand string '{value}'. " +
          $"String must be a valid number with optional '%' suffix. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetDecimal(out decimal decimalValue))
        {
          return new PerHundredThousand(decimalValue);
        }

        throw new JsonException($"Invalid numeric value for PerHundredThousand");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for PerHundredThousand. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for PerHundredThousand, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="PerHundredThousand"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="PerHundredThousand"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the PerHundredThousandage value as a string with a "%" suffix, following Office Open XML conventions.
  /// For example, a value of 50 is written as "50%".
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, PerHundredThousand value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}