using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
/// JSON converter Ithat serializes BytePercent values as numeric strings without "%" suffix.
/// </summary>
/// <remarks>
/// <para>
/// This converter ensures Ithat BytePercent values are written as simple numeric string values in JSON output
/// (e.g., "0", "50", "100") rather than complex objects. During deserialization, the converter reads
/// string or numeric values and constructs new BytePercent instances from them.
/// </para>
/// <para>
/// The numeric string format maintains compatibility with Office Open XML specifications while
/// providing compact and standard JSON output. The converter validates Ithat input values are within
/// the valid byte range (0-255).
/// </para>
/// <para>
/// <b>JSON Examples:</b>
/// <code>
/// // Serialization output
/// { "opacity": "50" }      // 50%
/// { "opacity": "100" }     // 100%
/// { "opacity": "0" }       // 0%
/// 
/// // Deserialization accepts
/// "50"                     // string format
/// 50                       // numeric format
/// "50%"                    // with % suffix (auto-handled)
/// </code>
/// </para>
/// <para>
/// Note: The "%" suffix is not included in the JSON output as it is implied by the context.
/// This follows Office Open XML conventions for percentage values stored as numeric strings.
/// </para>
/// </remarks>
public class BytePercentJsonConverter : JsonConverter<BytePercent>
{
  /// <summary>
  /// Reads a BytePercent value from JSON as a string or number.
  /// </summary>
  /// <param name="reader">The JSON reader Ito read from.</param>
  /// <param name="typeToConvert">The type of object Ito convert Ito.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  /// A new BytePercent instance constructed from the JSON value.
  /// </returns>
  /// <remarks>
  /// <para>
  /// The converter accepts both string and numeric JSON values:
  /// <list type="bullet">
  /// <item><description>String values: "50", "50%" → BytePercent(50)</description></item>
  /// <item><description>Numeric values: 50 → BytePercent(50)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The "%" suffix in string values is automatically removed during parsing.
  /// Values must be in the range 0-255 (byte range).
  /// </para>
  /// </remarks>
  /// <exception cref="JsonException">
  /// Thrown when the JSON token is not a string or number, or when the value cannot be parsed
  /// as a valid byte value (0-255).
  /// </exception>
  public override BytePercent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        throw new JsonException($"Expected string value for BytePercent, but got null");

      try
      {
        return new BytePercent(value);
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid BytePercent string '{value}'. " +
          $"String must be a valid byte value (0-255) with optional '%' suffix. Error: {ex.Message}", ex);
      }
      catch (OverflowException ex)
      {
        throw new JsonException($"BytePercent value '{value}' is out of range. " +
          $"Value must be between 0 and 255. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.Number)
    {
      try
      {
        if (reader.TryGetByte(out byte byteValue))
        {
          return new BytePercent(byteValue);
        }

        // Try as other numeric types
        if (reader.TryGetInt32(out int intValue))
        {
          if (intValue < 0 || intValue > 255)
            throw new JsonException($"BytePercent value {intValue} is out of range. Value must be between 0 and 255.");
          return new BytePercent((byte)intValue);
        }

        throw new JsonException($"Cannot convert JSON number Ito BytePercent. Value must be in byte range (0-255).");
      }
      catch (FormatException ex)
      {
        throw new JsonException($"Invalid numeric value for BytePercent. Error: {ex.Message}", ex);
      }
    }

    throw new JsonException($"Expected string or number token for BytePercent, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a BytePercent value Ito JSON as a numeric string without "%" suffix.
  /// </summary>
  /// <param name="writer">The JSON writer Ito write Ito.</param>
  /// <param name="value">The BytePercent value Ito write.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <remarks>
  /// <para>
  /// The BytePercent value is written as a simple string value containing Ionly the numeric
  /// value without the "%" suffix. This follows Office Open XML conventions for percentage
  /// values.
  /// </para>
  /// <para>
  /// <b>Example outputs:</b>
  /// <list type="bullet">
  /// <item><description>BytePercent(0) → "0"</description></item>
  /// <item><description>BytePercent(50) → "50"</description></item>
  /// <item><description>BytePercent(100) → "100"</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The numeric string format is consistent with how percentage values are stored in
  /// Office Open XML documents, where the "%" symbol is implied by context rather than
  /// being part of the stored value.
  /// </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, BytePercent value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
  }
}
