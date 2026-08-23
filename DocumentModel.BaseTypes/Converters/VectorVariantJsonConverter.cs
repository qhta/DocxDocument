namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="VectorVariant"/> class.
/// </summary>
/// <remarks>
/// This converter handles JSON representation of vector variants with their optional base type metadata
/// and element values. The JSON format includes the vector configuration and elements for complete
/// round-trip serialization.
/// </remarks>
public class VectorVariantJsonConverter : JsonConverter<VectorVariant>
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="VectorVariant"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="VectorVariant"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON structure is invalid or missing required properties.</description></item>
  /// <item><description>The baseType value is not a valid <see cref="VariantType"/>.</description></item>
  /// <item><description>Vector items cannot be converted to the specified base type.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// <para>Accepts the following JSON structures:</para>
  /// <code>
  /// // Object format with optional baseType
  /// {
  ///   "baseType": "Int32",
  ///   "items": [10, 20, 30]
  /// }
  /// 
  /// // Simple array format (no baseType)
  /// [10, 20, 30]
  /// </code>
  /// <para>
  /// The JSON object may have the following properties:
  /// <list type="bullet">
  /// <item><description><c>baseType</c>: (optional) A string representing a valid <see cref="VariantType"/> enum value</description></item>
  /// <item><description><c>items</c>: An array of values. If baseType is specified, values should match that type</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For simple array format, the vector is created without a specific base type, and elements
  /// are stored as-is.
  /// </para>
  /// <para>
  /// Null values in the items array are preserved and set as null in the VectorVariant.
  /// </para>
  /// </remarks>
  public override VectorVariant? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return null;
    }

    // Handle simple array format
    if (reader.TokenType == JsonTokenType.StartArray)
    {
      return ReadSimpleArray(ref reader);
    }

    // Handle object format with optional baseType
    if (reader.TokenType == JsonTokenType.StartObject)
    {
      return ReadObjectFormat(ref reader);
    }

    throw new JsonException($"Expected StartObject, StartArray, or Null token for VectorVariant, but got {reader.TokenType}");
  }

  /// <summary>
  /// Reads a VectorVariant from a simple JSON array.
  /// </summary>
  private VectorVariant ReadSimpleArray(ref Utf8JsonReader reader)
  {
    var result = new VectorVariant();

    while (reader.Read())
    {
      if (reader.TokenType == JsonTokenType.EndArray)
      {
        break;
      }

      object? item = ReadJsonValue(ref reader);
      result.Add(item);
    }

    return result;
  }

  /// <summary>
  /// Reads a VectorVariant from a JSON object with optional baseType.
  /// </summary>
  private VectorVariant ReadObjectFormat(ref Utf8JsonReader reader)
  {
    VariantType? baseType = null;
    IList<object?>? items = null;

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
          case "basetype":
            if (reader.TokenType == JsonTokenType.String)
            {
              string? baseTypeStr = reader.GetString();
              if (baseTypeStr != null && Enum.TryParse<VariantType>(baseTypeStr, out var parsedType))
              {
                baseType = parsedType;
              }
              else
              {
                throw new JsonException($"Invalid baseType value: {baseTypeStr}");
              }
            }
            break;

          case "items":
            if (reader.TokenType == JsonTokenType.StartArray)
            {
              items = new List<object?>();

              while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
              {
                object? item = ReadJsonValue(ref reader);
                items.Add(item);
              }
            }
            break;
        }
      }
    }

    // Create VectorVariant
    var result = baseType.HasValue ? new VectorVariant(baseType.Value) : new VectorVariant();

    // Populate items
    if (items != null)
    {
      foreach (var item in items)
      {
        try
        {
          object? convertedValue = baseType.HasValue ? ConvertJsonValue(item, baseType.Value) : item;
          result.Add(convertedValue);
        }
        catch (Exception ex)
        {
          throw new JsonException($"Failed to convert item to type {baseType}: {ex.Message}", ex);
        }
      }
    }

    return result;
  }

  /// <summary>
  /// Writes a <see cref="VectorVariant"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="VectorVariant"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// <para>Writes the VectorVariant value in the following JSON format:</para>
  /// <code>
  /// // With baseType specified
  /// {
  ///   "baseType": "Int32",
  ///   "items": [10, 20, 30]
  /// }
  /// 
  /// // Without baseType (simple array)
  /// [10, 20, 30]
  /// </code>
  /// <para>
  /// The JSON format depends on whether <see cref="VectorVariant.BaseType"/> is specified:
  /// <list type="bullet">
  /// <item><description>If <c>baseType</c> is set: Writes as an object with baseType and items properties</description></item>
  /// <item><description>If <c>baseType</c> is null: Writes as a simple JSON array</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is null, a JSON null is written.
  /// Null items in the vector are written as JSON null values.
  /// </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, VectorVariant? value, JsonSerializerOptions options)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    // If baseType is specified, write as object with metadata
    if (value.BaseType.HasValue)
    {
      writer.WriteStartObject();

      // Write baseType
      writer.WriteString("baseType", value.BaseType.Value.ToString(CultureInfo.InvariantCulture));

      // Write items array
      writer.WritePropertyName("items");
      writer.WriteStartArray();

      foreach (var item in value)
      {
        WriteJsonValue(writer, item, value.BaseType.Value);
      }

      writer.WriteEndArray();
      writer.WriteEndObject();
    }
    else
    {
      // Write as simple array if no baseType
      writer.WriteStartArray();

      foreach (var item in value)
      {
        WriteJsonValue(writer, item, null);
      }

      writer.WriteEndArray();
    }
  }

  #region Helper Methods

  /// <summary>
  /// Reads a JSON value based on the current token type.
  /// </summary>
  /// <param name="reader">The JSON reader.</param>
  /// <returns>The read value as an object.</returns>
  private static object? ReadJsonValue(ref Utf8JsonReader reader)
  {
    return reader.TokenType switch
    {
      JsonTokenType.Null => null,
      JsonTokenType.True => true,
      JsonTokenType.False => false,
      JsonTokenType.Number when reader.TryGetInt32(out int intValue) => intValue,
      JsonTokenType.Number when reader.TryGetInt64(out long longValue) => longValue,
      JsonTokenType.Number when reader.TryGetDouble(out double doubleValue) => doubleValue,
      JsonTokenType.String => reader.GetString(),
      _ => throw new JsonException($"Unexpected token type for vector item: {reader.TokenType}")
    };
  }

  /// <summary>
  /// Converts a JSON value to the specified variant type.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="variantType">The target variant type.</param>
  /// <returns>The converted value.</returns>
  private static object? ConvertJsonValue(object? value, VariantType variantType)
  {
    if (value == null)
      return null;

    return variantType switch
    {
      VariantType.Boolean => Convert.ToBoolean(value),
      VariantType.Byte => Convert.ToByte(value),
      VariantType.Int16 => Convert.ToInt16(value),
      VariantType.Int32 => Convert.ToInt32(value),
      VariantType.Int64 => Convert.ToInt64(value),
      VariantType.UInt16 => Convert.ToUInt16(value),
      VariantType.UInt32 => Convert.ToUInt32(value),
      VariantType.UInt64 => Convert.ToUInt64(value),
      VariantType.Single => Convert.ToSingle(value),
      VariantType.Double => Convert.ToDouble(value),
      VariantType.Decimal => Convert.ToDecimal(value),
      VariantType.DateTime when value is string str => DateTime.Parse(str),
      VariantType.DateTime => Convert.ToDateTime(value),
      VariantType.String => value.ToString(),
      VariantType.Char when value is string str => str.Length > 0 ? str[0] : '\0',
      VariantType.Char => Convert.ToChar(value),
      _ => value
    };
  }

  /// <summary>
  /// Writes a value to JSON based on its type.
  /// </summary>
  /// <param name="writer">The JSON writer.</param>
  /// <param name="value">The value to write.</param>
  /// <param name="variantType">The variant type of the value (may be null).</param>
  private static void WriteJsonValue(Utf8JsonWriter writer, object? value, VariantType? variantType)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    // If variantType is specified, use it for formatting hints
    if (variantType.HasValue)
    {
      switch (variantType.Value)
      {
        case VariantType.Boolean when value is bool boolValue:
          writer.WriteBooleanValue(boolValue);
          return;

        case VariantType.Byte when value is byte byteValue:
          writer.WriteNumberValue(byteValue);
          return;

        case VariantType.Int16 when value is short shortValue:
          writer.WriteNumberValue(shortValue);
          return;

        case VariantType.Int32 when value is int intValue:
          writer.WriteNumberValue(intValue);
          return;

        case VariantType.Int64 when value is long longValue:
          writer.WriteNumberValue(longValue);
          return;

        case VariantType.UInt16 when value is ushort ushortValue:
          writer.WriteNumberValue(ushortValue);
          return;

        case VariantType.UInt32 when value is uint uintValue:
          writer.WriteNumberValue(uintValue);
          return;

        case VariantType.UInt64 when value is ulong ulongValue:
          writer.WriteNumberValue(ulongValue);
          return;

        case VariantType.Single when value is float floatValue:
          writer.WriteNumberValue(floatValue);
          return;

        case VariantType.Double when value is double doubleValue:
          writer.WriteNumberValue(doubleValue);
          return;

        case VariantType.Decimal when value is decimal decimalValue:
          writer.WriteNumberValue(decimalValue);
          return;

        case VariantType.DateTime when value is DateTime dateTimeValue:
          writer.WriteStringValue(dateTimeValue.ToString("o")); // ISO 8601 format
          return;

        case VariantType.String:
        case VariantType.Char:
          writer.WriteStringValue(value.ToString());
          return;
      }
    }

    // Fallback: infer type from value
    switch (value)
    {
      case bool b:
        writer.WriteBooleanValue(b);
        break;
      case byte by:
        writer.WriteNumberValue(by);
        break;
      case short s:
        writer.WriteNumberValue(s);
        break;
      case int i:
        writer.WriteNumberValue(i);
        break;
      case long l:
        writer.WriteNumberValue(l);
        break;
      case ushort us:
        writer.WriteNumberValue(us);
        break;
      case uint ui:
        writer.WriteNumberValue(ui);
        break;
      case ulong ul:
        writer.WriteNumberValue(ul);
        break;
      case float f:
        writer.WriteNumberValue(f);
        break;
      case double d:
        writer.WriteNumberValue(d);
        break;
      case decimal dec:
        writer.WriteNumberValue(dec);
        break;
      case DateTime dt:
        writer.WriteStringValue(dt.ToString("o"));
        break;
      default:
        writer.WriteStringValue(value.ToString());
        break;
    }
  }

  #endregion
}
