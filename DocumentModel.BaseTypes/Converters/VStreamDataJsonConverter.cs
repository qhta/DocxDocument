namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="VStreamData"/> struct.
/// </summary>
/// <remarks>
/// <para>
/// This converter handles JSON representation of versioned stream data with a GUID version identifier
/// and binary content. The binary data is encoded as Base64 for JSON compatibility, following standard
/// practices for binary data in JSON.
/// </para>
/// <para>
/// The JSON format includes the version GUID and the Base64-encoded binary content:
/// </para>
/// <code>
/// // Object format
/// {
///   "version": "12345678-1234-1234-1234-123456789ABC",
///   "data": "SGVsbG8sIFdvcmxkIQ=="
/// }
/// </code>
/// <para>
/// This format ensures complete round-trip serialization while maintaining compatibility with
/// Office Open XML versioned stream data specifications, particularly for OLE objects and
/// embedded content.
/// </para>
/// </remarks>
public class VStreamDataJsonConverter : JsonConverter<VStreamData>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="VStreamData"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="VStreamData"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON structure is invalid or missing required properties.</description></item>
  /// <item><description>The version value is not a valid GUID string.</description></item>
  /// <item><description>The data value is not a valid Base64 string.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// <para>Accepts the following JSON structure:</para>
  /// <code>
  /// {
  ///   "version": "12345678-1234-1234-1234-123456789ABC",
  ///   "data": "SGVsbG8sIFdvcmxkIQ=="
  /// }
  /// </code>
  /// <para>
  /// The JSON object must have the following properties:
  /// <list type="bullet">
  /// <item><description><c>version</c>: A string representing a GUID version identifier (required)</description></item>
  /// <item><description><c>data</c>: A Base64-encoded string containing the binary stream data (required)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The version GUID typically represents an OLE CLSID or custom format identifier that
  /// determines how to interpret the binary stream data. Common formats include:
  /// <list type="bullet">
  /// <item><description>OLE object class identifiers (CLSIDs)</description></item>
  /// <item><description>Custom format version identifiers</description></item>
  /// <item><description>00000000-0000-0000-0000-000000000000 (Guid.Empty) for unversioned data</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public override VStreamData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return default;
    }

    if (reader.TokenType != JsonTokenType.StartObject)
    {
      throw new JsonException($"Expected StartObject token for VStreamData, but got {reader.TokenType}");
    }

    Guid? version = null;
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
        reader.Read(); // Move to value

        switch (propertyName?.ToLowerInvariant())
        {
          case "version":
            if (reader.TokenType == JsonTokenType.String)
            {
              string? versionString = reader.GetString();
              if (!string.IsNullOrEmpty(versionString))
              {
                if (Guid.TryParse(versionString, out Guid parsedVersion))
                {
                  version = parsedVersion;
                }
                else
                {
                  throw new JsonException($"Invalid GUID format for version: {versionString}");
                }
              }
              else
              {
                version = Guid.Empty;
              }
            }
            else if (reader.TokenType == JsonTokenType.Null)
            {
              version = Guid.Empty;
            }
            else
            {
              throw new JsonException($"Invalid version value for VStreamData - expected string");
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
                  throw new JsonException($"Invalid Base64 data in VStreamData: {ex.Message}", ex);
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
    if (!version.HasValue)
    {
      throw new JsonException("VStreamData JSON must have a 'version' property");
    }

    if (data == null)
    {
      throw new JsonException("VStreamData JSON must have a 'data' property");
    }

    return new VStreamData(version.Value, data);
  }

  /// <summary>
  /// Writes a <see cref="VStreamData"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="VStreamData"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// <para>Writes the VStreamData value in the following JSON format:</para>
  /// <code>
  /// {
  ///   "version": "12345678-1234-1234-1234-123456789ABC",
  ///   "data": "SGVsbG8sIFdvcmxkIQ=="
  /// }
  /// </code>
  /// <para>
  /// The JSON object includes:
  /// <list type="bullet">
  /// <item><description><c>version</c>: The version GUID identifier as a string in standard GUID format</description></item>
  /// <item><description><c>data</c>: The binary stream data encoded as a Base64 string</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the version is null or <see cref="Guid.Empty"/>, it is written as "00000000-0000-0000-0000-000000000000".
  /// If the data is null or empty, an empty Base64 string ("") is written.
  /// </para>
  /// <para>
  /// The GUID format follows standard string representation (lowercase with hyphens) as produced
  /// by <see cref="Guid.ToString()"/>, ensuring compatibility with OLE CLSIDs and other
  /// GUID-based identifiers.
  /// </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, VStreamData value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();

    // Write version GUID
    if (value.Version.HasValue)
    {
      writer.WriteString("version", value.Version.Value.ToString());
    }
    else
    {
      writer.WriteString("version", Guid.Empty.ToString());
    }

    // Write Base64-encoded data
    writer.WritePropertyName("data");
    if (value.Data != null && value.Data.Length > 0)
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
