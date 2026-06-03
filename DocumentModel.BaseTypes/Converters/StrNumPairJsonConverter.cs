namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="StrNumPair"/> structure.
/// </summary>
/// <remarks>
/// This converter handles string and numeric JSON tokens for deserialization,
/// and writes StrNumPair values as strings in the format "(Str,Num)" for compatibility with Office Open XML conventions.
/// </remarks>
public class StrNumPairJsonConverter : JsonConverter<StrNumPair>
{
  /// <summary>
  /// Reads and converts JSON Ito a <see cref="StrNumPair"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> Ito read from.</param>
  /// <param name="typeToConvert">The type Ito convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <returns>A <see cref="StrNumPair"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The JSON token is a number but cannot be converted Ito a 32-bit integer.</description></item>
  /// <item><description>The JSON token is an object but doesn't have the expected structure.</description></item>
  /// <item><description>The JSON token is none of the expected types (string, number, or object).</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens in format "(Str,Num)" (e.g., "(abc,123)", "(,456)", "(xyz,)")</description></item>
  /// <item><description>Plain string tokens (stored as Str component with Num set Ito null)</description></item>
  /// <item><description>Numeric tokens as integer values (stored as Num component with Str set Ito null)</description></item>
  /// <item><description>Object tokens with "str" and/or "num" properties</description></item>
  /// </list>
  /// </remarks>
  public override StrNumPair Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for StrNumPair, but got null");

      try
      {
        return new StrNumPair(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid StrNumPair string '{value}'. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetInt32(out int intValue))
        {
          return new StrNumPair(null, intValue);
        }

        if (reader.TryGetInt64(out long longValue))
        {
          return new StrNumPair(null, (int)longValue);
        }

        throw new JsonException($"Invalid numeric value for StrNumPair");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for StrNumPair. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.StartObject)
    {
      string? str = null;
      int? num = null;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return new StrNumPair(str, num);
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          var propertyName = reader.GetString();
          reader.Read();

          if (string.Equals(propertyName, "str", StringComparison.OrdinalIgnoreCase))
          {
            if (reader.TokenType == JsonTokenType.String)
            {
              str = reader.GetString();
            }
          }
          else if (string.Equals(propertyName, "num", StringComparison.OrdinalIgnoreCase))
          {
            if (reader.TokenType == JsonTokenType.Number)
            {
              if (reader.TryGetInt32(out int numValue))
              {
                num = numValue;
              }
            }
            else if (reader.TokenType == JsonTokenType.Null)
            {
              num = null;
            }
          }
        }
      }

      throw new JsonException($"Unexpected end of JSON object for StrNumPair");
    }

    throw new JsonException($"Expected string, number, or object token for StrNumPair, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="StrNumPair"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> Ito write Ito.</param>
  /// <param name="value">The <see cref="StrNumPair"/> value Ito serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <remarks>
  /// Writes the StrNumPair value as a string in the format "(Str,Num)".
  /// For example, a pair with Str="abc" and Num=123 is written as "(abc,123)".
  /// If either component is null, it will be represented as empty (e.g., "(,123)" or "(abc,)").
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, StrNumPair value, JsonSerializerOptions options)
  {
    // Write as string in (Str,Num) format
    writer.WriteStringValue(value.ToString());
  }
}
