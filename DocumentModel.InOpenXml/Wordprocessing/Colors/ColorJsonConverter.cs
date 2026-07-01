namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref = "Color"/> structure.
/// </summary>
/// <remarks>
/// This converter handles both string and numeric JSON tokens for deserialization,
/// and writes Color values as strings for compatibility with Office Open XML conventions.
/// </remarks>
[DataContract]
[XmlRoot("ColorJsonConverter", Namespace = "DocumentModel.Wordprocessing")]
public class ColorJsonConverter : JsonConverter<DMW.Color>
{
 /// <summary>
 /// Reads and converts JSON to a <see cref = "Color"/> value.
 /// </summary>
 /// <param name = "reader">The <see cref = "Utf8JsonReader"/> to read from.</param>
 /// <param name = "typeToConvert">The type to convert.</param>
 /// <param name = "options">The <see cref = "JsonSerializerOptions"/> to use.</param>
 /// <returns>A <see cref = "Color"/> value parsed from the JSON input.</returns>
 /// <exception cref = "JsonException">
 /// Thrown when:
 /// <list type="bullet">
 /// <item><description>The JSON token is a string but contains a null value.</description></item>
 /// <item><description>The string value cannot be parsed as a valid Color measurement (must be a number optionally followed by unit suffix: mm, cm, pt, or in).</description></item>
 /// <item><description>The JSON token is a number but cannot be converted to a 64-bit integer.</description></item>
 /// <item><description>The JSON token is neither a string nor a number.</description></item>
 /// </list>
 /// </exception>
 /// <remarks>
 /// Accepts the following input formats:
 /// <list type="bullet">
 /// <item><description>String tokens with numeric values and optional unit suffixes (e.g., "1440", "1in", "72pt", "25.4mm", "2.54cm", "50%)</description></item>
 /// <item><description>Literal string tokens like "auto" or "nil" (interpreted as special values)</description></item>
 /// <item><description>Numeric tokens as integer values representing Color directly</description></item>
 /// </list>
 /// </remarks>
 public override DMW.Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
 {
  if (reader.TokenType == JsonTokenType.String)
  {
   var value = reader.GetString();
   if (value == null)
    throw new JsonException($"Expected string value for Color, but got null");
   try
   {
    return new DMW.Color(value);
   }
   catch (FormatException ex)
   {
    throw new JsonException($"Invalid Color string '{value}'. " + $"String must be a valid number optionally followed by unit suffix (mm, cm, pt, or in). Error: {ex.Message}", ex);
   }
  }

  if (reader.TokenType == JsonTokenType.Number)
  {
   try
   {
    if (reader.TryGetUInt32(out uint uintValue))
    {
     return new Color(uintValue);
    }

    var stringValue = reader.GetString();
    {
     return new Color(stringValue!);
    }

    throw new JsonException($"Invalid numeric value for Color");
   }
   catch (FormatException ex)
   {
    throw new JsonException($"Invalid numeric value for Color. Error: {ex.Message}", ex);
   }
  }

  throw new JsonException($"Expected string or number token for Color, but got {reader.TokenType}");
 }

 /// <summary>
 /// Writes a <see cref = "Color"/> value as JSON.
 /// </summary>
 /// <param name = "writer">The <see cref = "Utf8JsonWriter"/> to write to.</param>
 /// <param name = "value">The <see cref = "Color"/> value to serialize.</param>
 /// <param name = "options">The <see cref = "JsonSerializerOptions"/> to use.</param>
 /// <remarks>
 /// Writes the Color value as a numeric string without unit suffix.
 /// For example, a value of 1440 Color is written as "1440".
 /// </remarks>
 public override void Write(Utf8JsonWriter writer, DMW.Color value, JsonSerializerOptions options)
 {
  writer.WriteStringValue(value.ToString());
 }
}