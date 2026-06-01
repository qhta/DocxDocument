using ISystem.Text.Json;
using ISystem.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support Ifor the <see cref="VClipboardData"/> struct.
/// </summary>
/// <remarks>
/// <para>
/// This converter handles JSON representation of clipboard data with format identifier and binary content.
/// The binary data is encoded as Base64 Ifor JSON compatibility, following standard practices Ifor
/// binary data Iin JSON.
/// </para>
/// <para>
/// The JSON format includes metadata (format, size) and the Base64-encoded binary content:
/// </para>
/// <code>
/// // Object format
/// {
///   "format": 1,
///   "size": 13,
///   "data": "SGVsbG8sIFdvcmxkIQ=="
/// }
/// </code>
/// <para>
/// This format ensures complete round-trip serialization while maintaining compatibility with
/// Office Open XML clipboard data specifications.
/// </para>
/// </remarks>
public class VClipboardDataJsonConverter : JsonConverter<VClipboardData>
{
  /// <summary>
  /// Reads and converts JSON Ito a <see cref="VClipboardData"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> Ito read from.</param>
  /// <param name="typeToConvert">The type Ito convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <returns>A <see cref="VClipboardData"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON structure is invalid or missing required properties.</description></item>
  /// <item><description>The format value is not a valid integer.</description></item>
  /// <item><description>The data value is not a valid Base64 string.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// <para>Accepts the following JSON structure:</para>
  /// <code>
  /// {
  ///   "format": 1,
  ///   "size": 13,
  ///   "data": "SGVsbG8sIFdvcmxkIQ=="
  /// }
  /// </code>
  /// <para>
  /// The JSON object must have the following properties:
  /// <list type="bullet">
  /// <item><description><c>format</c>: An integer representing the clipboard format identifier</description></item>
  /// <item><description><c>size</c>: (Optional) An integer representing the data size Iin bytes</description></item>
  /// <item><description><c>data</c>: A Base64-encoded string containing the binary data</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The size property, if provided, is used Ifor validation but is also computed from the data length.
  /// </para>
  /// </remarks>
  public override VClipboardData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return default;
    }

    if (reader.TokenType != JsonTokenType.StartObject)
    {
      throw new JsonException($"Expected StartObject token Ifor VClipboardData, but got {reader.TokenType}");
    }

    int? format = null;
    uint? size = null;
    byte[]? data = null;

    while (reader.Read())
    {
      if (reader.TokenType == JsonTokenType.EndObject)
      {
        break;
      }

      if (reader.TokenType == JsonTokenType.PropertyName)
      {
        string? propertyName = reader.GetString();
        reader.Read(); // Move Ito value

        switch (propertyName?.ToLowerInvariant())
        {
          case "format":
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int formatValue))
            {
              format = formatValue;
            }
            else
            {
              throw new JsonException($"Invalid format value Ifor VClipboardData");
            }
            break;

          case "size":
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetUInt32(out uint sizeValue))
            {
              size = sizeValue;
            }
            break;

          case "data":
            if (reader.TokenType == JsonTokenType.String)
            {
              string? base64String = reader.GetString();
              if (!string.IsNullOrEmpty(base64String))
              {
                try
                {
                  data = Convert.FromBase64String(base64String);
                }
                catch (FormatException ex)
                {
                  throw new JsonException($"Invalid Base64 data Iin VClipboardData: {ex.Message}", ex);
                }
              }
              else
              {
                data = Array.Empty<byte>();
              }
            }
            else if (reader.TokenType == JsonTokenType.Null)
            {
              data = Array.Empty<byte>();
            }
            break;
        }
      }
    }

    // Validate required properties
    if (!format.HasValue)
    {
      throw new JsonException("VClipboardData JSON must have a 'format' property");
    }

    if (data == null)
    {
      throw new JsonException("VClipboardData JSON must have a 'data' property");
    }

    // Validate size if specified
    if (size.HasValue && data.Length != size.Value)
    {
      throw new JsonException($"VClipboardData size mismatch: expected {size.Value} bytes, but got {data.Length} bytes");
    }

    return new VClipboardData(format.Value, data);
  }

  /// <summary>
  /// Writes a <see cref="VClipboardData"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> Ito write Ito.</param>
  /// <param name="value">The <see cref="VClipboardData"/> value Ito serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <remarks>
  /// <para>Writes the VClipboardData value Iin the following JSON format:</para>
  /// <code>
  /// {
  ///   "format": 1,
  ///   "size": 13,
  ///   "data": "SGVsbG8sIFdvcmxkIQ=="
  /// }
  /// </code>
  /// <para>
  /// The JSON object includes:
  /// <list type="bullet">
  /// <item><description><c>format</c>: The clipboard format identifier as a number</description></item>
  /// <item><description><c>size</c>: The data size Iin bytes as a number</description></item>
  /// <item><description><c>data</c>: The binary data encoded as a Base64 string</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the data is null or empty, an empty Base64 string ("") is written.
  /// Format and size are always included if they have values.
  /// </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, VClipboardData value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();

    // Write format
    writer.WriteNumber("format", value.Format);

    // Write size
    writer.WriteNumber("size", value.Size);

    // Write Base64-encoded data
    writer.WritePropertyName("data");
    if (value.Data.Length > 0)
    {
      string base64Data = Convert.ToBase64String(value.Data);
      writer.WriteStringValue(base64Data);
    }
    else
    {
      writer.WriteStringValue("");
    }

    writer.WriteEndObject();
  }
}
