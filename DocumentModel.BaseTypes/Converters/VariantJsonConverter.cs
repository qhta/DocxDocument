using System.Text.Json;
using System.Text.Json.Serialization;

using Qhta.TypeUtils;

namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="Variant"/> class.
/// </summary>
/// <remarks>
/// <para>
/// This converter handles JSON representation of variant values with type information and content.
/// The JSON format includes the VariantType classification and the value in an appropriate format.
/// </para>
/// <para>
/// The JSON format includes metadata (type, valueType) and the value:
/// </para>
/// <code>
/// // Simple types
/// {
///   "type": "Int32",
///   "value": 42
/// }
/// 
/// // String type
/// {
///   "type": "String",
///   "value": "Hello"
/// }
/// 
/// // Enum type with valueType
/// {
///   "type": "Enum",
///   "valueType": "System.DayOfWeek, System.Private.CoreLib",
///   "value": "Monday"
/// }
/// 
/// // Binary data (Base64-encoded)
/// {
///   "type": "Blob",
///   "value": "SGVsbG8sIFdvcmxkIQ=="
/// }
/// </code>
/// <para>
/// This format ensures complete round-trip serialization while maintaining compatibility with
/// Office Open XML variant type specifications.
/// </para>
/// </remarks>
[JsonConverter(typeof(VariantJsonConverter))]
public class VariantJsonConverter : JsonConverter<Variant>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="Variant"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="Variant"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON structure is invalid or missing required properties.</description></item>
  /// <item><description>The type value is not a valid VariantType.</description></item>
  /// <item><description>The value cannot be converted to the specified type.</description></item>
  /// <item><description>The valueType cannot be resolved for Enum or Object types.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// <para>Accepts the following JSON structure:</para>
  /// <code>
  /// {
  ///   "type": "Int32",
  ///   "value": 42
  /// }
  /// {
  ///   "type": "Enum",
  ///   "valueType": "System.DayOfWeek, System.Private.CoreLib",
  ///   "value": "Monday"
  /// }
  /// </code>
  /// <para>
  /// The JSON object must have the following properties:
  /// <list type="bullet">
  /// <item><description><c>type</c>: A string representing the VariantType name (required)</description></item>
  /// <item><description><c>valueType</c>: The full .NET type name for Enum and Object types (optional)</description></item>
  /// <item><description><c>value</c>: The value in appropriate JSON format (required for non-Empty/Null types)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value formats by type:
  /// <list type="bullet">
  /// <item><description>Numeric types: JSON number</description></item>
  /// <item><description>String types: JSON string</description></item>
  /// <item><description>Boolean: JSON boolean</description></item>
  /// <item><description>Date/DateTime: ISO 8601 string</description></item>
  /// <item><description>Binary types: Base64-encoded string</description></item>
  /// <item><description>Null/Empty: null or omitted</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public override Variant Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return new Variant(VariantType.Null);
    }

    if (reader.TokenType != JsonTokenType.StartObject)
    {
      throw new JsonException($"Expected StartObject token for Variant, but got {reader.TokenType}");
    }

    VariantType? variantType = null;
    Type? valueType = null;
    JsonElement? valueElement = null;

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
          case "type":
            if (reader.TokenType == JsonTokenType.String)
            {
              string? typeString = reader.GetString();
              if (!string.IsNullOrEmpty(typeString))
              {
                if (Enum.TryParse<VariantType>(typeString, out VariantType parsedType))
                {
                  variantType = parsedType;
                }
                else
                {
                  throw new JsonException($"Invalid VariantType: {typeString}");
                }
              }
            }
            else
            {
              throw new JsonException("Expected string value for 'type' property");
            }
            break;

          case "valuetype":
            if (reader.TokenType == JsonTokenType.String)
            {
              string? valueTypeString = reader.GetString();
              if (!string.IsNullOrEmpty(valueTypeString))
              {
                valueType = Type.GetType(valueTypeString);
                if (valueType == null)
                {
                  throw new JsonException($"Could not resolve type: {valueTypeString}");
                }
              }
            }
            break;

          case "value":
            // Store the value element for later processing
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
              valueElement = doc.RootElement.Clone();
            }
            break;
        }
      }
    }

    // Validate required properties
    if (!variantType.HasValue)
    {
      throw new JsonException("Variant JSON must have a 'type' property");
    }

    // Parse the value based on the variant type
    object? value = null;
    if (valueElement.HasValue && variantType.Value != VariantType.Empty && variantType.Value != VariantType.Null)
    {
      try
      {
        value = ParseValueFromJson(variantType.Value, valueElement.Value, valueType);
      }
      catch (Exception ex)
      {
        throw new JsonException($"Failed to parse Variant value for type {variantType.Value}: {ex.Message}", ex);
      }
    }
    else if (variantType.Value == VariantType.Null)
    {
      value = DBNull.Value;
    }

    return new Variant(variantType.Value, valueType, value);
  }

  /// <summary>
  /// Writes a <see cref="Variant"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="Variant"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// <para>Writes the Variant value in the following JSON format:</para>
  /// <code>
  /// {
  ///   "type": "Int32",
  ///   "value": 42
  /// }
  /// {
  ///   "type": "Enum",
  ///   "valueType": "System.DayOfWeek, System.Private.CoreLib",
  ///   "value": "Monday"
  /// }
  /// </code>
  /// <para>
  /// The JSON object includes:
  /// <list type="bullet">
  /// <item><description><c>type</c>: The VariantType name as a string</description></item>
  /// <item><description><c>valueType</c>: The full .NET type name for Enum and Object types</description></item>
  /// <item><description><c>value</c>: The value in appropriate JSON format</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Value formatting:
  /// <list type="bullet">
  /// <item><description>Numeric types: Written as JSON numbers</description></item>
  /// <item><description>String types: Written as JSON strings</description></item>
  /// <item><description>Boolean: Written as JSON boolean</description></item>
  /// <item><description>Date: Formatted as "yyyy-MM-dd" string</description></item>
  /// <item><description>DateTime: ISO 8601 string</description></item>
  /// <item><description>Binary types: Base64-encoded string</description></item>
  /// <item><description>Null/Empty: Written as JSON null</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, Variant value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();

    // Write type
    writer.WriteString("type", value.VariantType.ToString(CultureInfo.InvariantCulture));

    // Write valueType for Enum and Object types
    if ((value.VariantType == VariantType.Enum || value.VariantType == VariantType.Object) && value.ValueType != null)
    {
      writer.WriteString("valueType", value.ValueType.AssemblyQualifiedName ?? value.ValueType.FullName);
    }

    // Write value
    writer.WritePropertyName("value");
    WriteValueToJson(writer, value.VariantType, value.Value, options);

    writer.WriteEndObject();
  }

  #region Helper Methods

  /// <summary>
  /// Parses a JSON element into the appropriate .NET type based on the VariantType.
  /// </summary>
  private static object? ParseValueFromJson(VariantType variantType, JsonElement element, Type? valueType)
  {
    switch (variantType)
    {
      case VariantType.Boolean:
        return element.GetBoolean();

      case VariantType.SByte:
        return element.GetSByte();

      case VariantType.Byte:
        return element.GetByte();

      case VariantType.Int16:
        return element.GetInt16();

      case VariantType.UInt16:
        return element.GetUInt16();

      case VariantType.Int32:
        return element.GetInt32();

      case VariantType.UInt32:
        return element.GetUInt32();

      case VariantType.Int64:
        return element.GetInt64();

      case VariantType.UInt64:
        return element.GetUInt64();

      case VariantType.Integer:
      case VariantType.UnsignedInteger:
      case VariantType.Decimal:
      case VariantType.Currency:
        return element.GetDecimal();

      case VariantType.Single:
        return element.GetSingle();

      case VariantType.Double:
        return element.GetDouble();

      case VariantType.Char:
        string? charStr = element.GetString();
        if (string.IsNullOrEmpty(charStr) || charStr!.Length != 1)
          throw new JsonException("Char value must be a single character");
        return charStr[0];

      case VariantType.String:
      case VariantType.Lpstr:
      case VariantType.Lpwstr:
      case VariantType.Bstr:
        return element.GetString();

      case VariantType.Date:
        string? dateStr = element.GetString();
        if (string.IsNullOrEmpty(dateStr))
          throw new JsonException("Date value cannot be empty");
        return DateOnly.Parse(dateStr!);

      case VariantType.DateTime:
        return element.GetDateTime();

      case VariantType.Guid:
        return element.GetGuid();

      case VariantType.HexInt:
        string? hexStr = element.GetString();
        if (string.IsNullOrEmpty(hexStr))
          throw new JsonException("HexInt value cannot be empty");
        return new HexInt(hexStr!);

      case VariantType.Enum:
        if (valueType == null)
          throw new JsonException("Enum type requires valueType");
        string? enumStr = element.GetString();
        if (string.IsNullOrEmpty(enumStr))
          throw new JsonException("Enum value cannot be empty");
        return Enum.Parse(valueType, enumStr);

      case VariantType.Blob:
      case VariantType.OBlob:
      case VariantType.Storage:
      case VariantType.OStorage:
      case VariantType.Stream:
      case VariantType.OStream:
        string? base64Str = element.GetString();
        if (string.IsNullOrEmpty(base64Str))
          return Array.Empty<byte>();
        return Convert.FromBase64String(base64Str);

      case VariantType.ClipboardData:
        string? clipDataStr = element.GetString();
        if (string.IsNullOrEmpty(clipDataStr))
          return Array.Empty<byte>();
        return Convert.FromBase64String(clipDataStr);

      case VariantType.VStream:
        string? streamDataStr = element.GetString();
        if (string.IsNullOrEmpty(streamDataStr))
          return Array.Empty<byte>();
        return Convert.FromBase64String(streamDataStr);

      case VariantType.Variant:
        // Nested variant - deserialize recursively
        string? variantJson = element.GetRawText();
        if (string.IsNullOrEmpty(variantJson))
          return null;
        return JsonSerializer.Deserialize<Variant>(variantJson);

      case VariantType.Object:
        // For objects, try to deserialize based on valueType
        if (valueType != null)
        {
          string? objJson = element.GetRawText();
          if (string.IsNullOrEmpty(objJson))
            return null;
          return JsonSerializer.Deserialize(objJson, valueType);
        }
        return element.GetString();

      case VariantType.Null:
        return DBNull.Value;

      case VariantType.Empty:
        return null;

      default:
        return element.GetString();
    }
  }

  /// <summary>
  /// Writes a variant value to JSON in the appropriate format.
  /// </summary>
  private static void WriteValueToJson(Utf8JsonWriter writer, VariantType variantType, object? value, JsonSerializerOptions options)
  {
    if (value == null || variantType == VariantType.Empty)
    {
      writer.WriteNullValue();
      return;
    }

    switch (variantType)
    {
      case VariantType.Boolean:
        writer.WriteBooleanValue((bool)value);
        break;

      case VariantType.SByte:
        writer.WriteNumberValue((sbyte)value);
        break;

      case VariantType.Byte:
        writer.WriteNumberValue((byte)value);
        break;

      case VariantType.Int16:
        writer.WriteNumberValue((short)value);
        break;

      case VariantType.UInt16:
        writer.WriteNumberValue((ushort)value);
        break;

      case VariantType.Int32:
        writer.WriteNumberValue((int)value);
        break;

      case VariantType.UInt32:
        writer.WriteNumberValue((uint)value);
        break;

      case VariantType.Int64:
        writer.WriteNumberValue((long)value);
        break;

      case VariantType.UInt64:
        writer.WriteNumberValue((ulong)value);
        break;

      case VariantType.Integer:
      case VariantType.UnsignedInteger:
      case VariantType.Decimal:
      case VariantType.Currency:
        writer.WriteNumberValue((decimal)value);
        break;

      case VariantType.Single:
        writer.WriteNumberValue((float)value);
        break;

      case VariantType.Double:
        writer.WriteNumberValue((double)value);
        break;

      case VariantType.Char:
        writer.WriteStringValue(value.ToString());
        break;

      case VariantType.String:
      case VariantType.Lpstr:
      case VariantType.Lpwstr:
      case VariantType.Bstr:
        writer.WriteStringValue(value.ToString());
        break;

      case VariantType.Date:
        if (value is DateOnly dateOnly)
          writer.WriteStringValue(dateOnly.ToString("yyyy-MM-dd"));
        else if (value is DateTime dt)
          writer.WriteStringValue(DateOnly.FromDateTime(dt).ToString("yyyy-MM-dd"));
        else
          writer.WriteStringValue(value.ToString());
        break;

      case VariantType.DateTime:
        if (value is DateTime dateTime)
          writer.WriteStringValue(dateTime);
        else
          writer.WriteStringValue(value.ToString());
        break;

      case VariantType.Guid:
        if (value is Guid guid)
          writer.WriteStringValue(guid);
        else
          writer.WriteStringValue(value.ToString());
        break;

      case VariantType.HexInt:
        writer.WriteStringValue(value.ToString());
        break;

      case VariantType.Enum:
        writer.WriteStringValue(value.ToString());
        break;

      case VariantType.Blob:
      case VariantType.OBlob:
      case VariantType.Storage:
      case VariantType.OStorage:
      case VariantType.Stream:
      case VariantType.OStream:
        if (value is byte[] bytes)
          writer.WriteStringValue(Convert.ToBase64String(bytes));
        else
          writer.WriteNullValue();
        break;

      case VariantType.ClipboardData:
        if (value is VClipboardData clipData)
          writer.WriteStringValue(Convert.ToBase64String(clipData.Data));
        else if (value is byte[] clipBytes)
          writer.WriteStringValue(Convert.ToBase64String(clipBytes));
        else
          writer.WriteNullValue();
        break;

      case VariantType.VStream:
        if (value is VStreamData streamData)
          writer.WriteStringValue(Convert.ToBase64String(streamData.Data));
        else if (value is byte[] streamBytes)
          writer.WriteStringValue(Convert.ToBase64String(streamBytes));
        else
          writer.WriteNullValue();
        break;

      case VariantType.Variant:
        if (value is Variant variant)
          JsonSerializer.Serialize(writer, variant, options);
        else
          writer.WriteStringValue(value.ToString());
        break;

      case VariantType.Object:
        // For objects, serialize using JsonSerializer
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
        break;

      case VariantType.Null:
        writer.WriteNullValue();
        break;

      default:
        writer.WriteStringValue(value.ToString());
        break;
    }
  }

  #endregion
}
