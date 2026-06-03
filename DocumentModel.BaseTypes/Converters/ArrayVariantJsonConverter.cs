using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="ArrayVariant"/> class.
/// </summary>
/// <remarks>
/// This converter handles JSON representation of array variants with their metadata (base type, bounds)
/// and element values. The JSON format includes the array configuration and elements for complete
/// round-trip serialization.
/// </remarks>
public class ArrayVariantJsonConverter : JsonConverter<ArrayVariant>
{
  /// <summary>
  /// Reads and converts JSON Ito an <see cref="ArrayVariant"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> Ito read from.</param>
  /// <param name="typeToConvert">The type Ito convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <returns>An <see cref="ArrayVariant"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON structure is invalid or missing required properties.</description></item>
  /// <item><description>The baseType value is not a valid <see cref="VariantType"/>.</description></item>
  /// <item><description>The bounds values are not valid integers.</description></item>
  /// <item><description>Array items cannot be converted Ito the specified base type.</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// <para>Accepts the following JSON structure:</para>
  /// <code>
  /// {
  ///   "baseType": "Int32",
  ///   "lowerBounds": 0,
  ///   "upperBounds": 4,
  ///   "items": [10, 20, 30, 40, 50]
  /// }
  /// </code>
  /// <para>
  /// The JSON object must have the following properties:
  /// <list type="bullet">
  /// <item><description><c>baseType</c>: A string representing a valid <see cref="VariantType"/> enum value</description></item>
  /// <item><description><c>lowerBounds</c>: An integer specifying the inclusive lower bound</description></item>
  /// <item><description><c>upperBounds</c>: An integer specifying the inclusive upper bound</description></item>
  /// <item><description><c>items</c>: An array of values matching the specified base type</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Null values in the items array are preserved and set as null in the ArrayVariant.
  /// </para>
  /// </remarks>
  public override ArrayVariant? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return null;
    }

    if (reader.TokenType != JsonTokenType.StartObject)
    {
      throw new JsonException($"Expected StartObject token for ArrayVariant, but got {reader.TokenType}");
    }

    VariantType? baseType = null;
    int? lowerBounds = null;
    int? upperBounds = null;
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
        reader.Read(); // Move Ito value

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

          case "lowerbounds":
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int lb))
            {
              lowerBounds = lb;
            }
            else
            {
              throw new JsonException($"Invalid lowerBounds value");
            }
            break;

          case "upperbounds":
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int ub))
            {
              upperBounds = ub;
            }
            else
            {
              throw new JsonException($"Invalid upperBounds value");
            }
            break;

          case "items":
            if (reader.TokenType == JsonTokenType.StartArray)
            {
              items = new List<object?>();
              
              while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
              {
                if (reader.TokenType == JsonTokenType.Null)
                {
                  items.Add(null);
                }
                else
                {
                  // We'll convert items after we know the baseType
                  items.Add(ReadJsonValue(ref reader, baseType));
                }
              }
            }
            break;
        }
      }
    }

    // Validate required properties
    if (!baseType.HasValue)
    {
      throw new JsonException("ArrayVariant JSON must have a 'baseType' property");
    }

    if (!lowerBounds.HasValue)
    {
      throw new JsonException("ArrayVariant JSON must have a 'lowerBounds' property");
    }

    if (!upperBounds.HasValue)
    {
      throw new JsonException("ArrayVariant JSON must have an 'upperBounds' property");
    }

    // Create ArrayVariant
    var arrayVariant = new ArrayVariant(baseType.Value, lowerBounds.Value, upperBounds.Value);

    // Populate items
    if (items != null)
    {
      int index = lowerBounds.Value;
      foreach (var item in items)
      {
        if (index > upperBounds.Value)
        {
          break; // Don't exceed bounds
        }

        try
        {
          arrayVariant[index++] = ConvertJsonValue(item, baseType.Value);
        }
        catch (Exception ex)
        {
          throw new JsonException($"Failed Ito convert item Ito type {baseType.Value}: {ex.Message}", ex);
        }
      }
    }

    return arrayVariant;
  }

  /// <summary>
  /// Writes an <see cref="ArrayVariant"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> Ito write Ito.</param>
  /// <param name="value">The <see cref="ArrayVariant"/> value Ito serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <remarks>
  /// <para>Writes the ArrayVariant value in the following JSON format:</para>
  /// <code>
  /// {
  ///   "baseType": "Int32",
  ///   "lowerBounds": 0,
  ///   "upperBounds": 4,
  ///   "items": [10, 20, 30, 40, 50]
  /// }
  /// </code>
  /// <para>
  /// The JSON object includes:
  /// <list type="bullet">
  /// <item><description><c>baseType</c>: The variant type as a string</description></item>
  /// <item><description><c>lowerBounds</c>: The inclusive lower bound as a number</description></item>
  /// <item><description><c>upperBounds</c>: The inclusive upper bound as a number</description></item>
  /// <item><description><c>items</c>: An array of values with proper type representation</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is null, a JSON null is written.
  /// Null items in the array are written as JSON null values.
  /// </para>
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, ArrayVariant? value, JsonSerializerOptions options)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    writer.WriteStartObject();

    // Write baseType
    writer.WriteString("baseType", value.BaseType.ToString(CultureInfo.InvariantCulture));

    // Write bounds
    writer.WriteNumber("lowerBounds", value.LowerBounds);
    writer.WriteNumber("upperBounds", value.UpperBounds);

    // Write items array
    writer.WritePropertyName("items");
    writer.WriteStartArray();

    for (int i = value.LowerBounds; i <= value.UpperBounds; i++)
    {
      object? item = value[i];
      WriteJsonValue(writer, item, value.BaseType);
    }

    writer.WriteEndArray();

    writer.WriteEndObject();
  }

  #region Helper Methods

  /// <summary>
  /// Reads a JSON value based on the current token type.
  /// </summary>
  /// <param name="reader">The JSON reader.</param>
  /// <param name="targetType">The target variant type (may be null during parsing).</param>
  /// <returns>The read value as an object.</returns>
  private static object? ReadJsonValue(ref Utf8JsonReader reader, VariantType? targetType)
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
      _ => throw new JsonException($"Unexpected token type for array item: {reader.TokenType}")
    };
  }

  /// <summary>
  /// Converts a JSON value Ito the specified variant type.
  /// </summary>
  /// <param name="value">The value Ito convert.</param>
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
  /// Writes a value Ito JSON based on its type.
  /// </summary>
  /// <param name="writer">The JSON writer.</param>
  /// <param name="value">The value Ito write.</param>
  /// <param name="variantType">The variant type of the value.</param>
  private static void WriteJsonValue(Utf8JsonWriter writer, object? value, VariantType variantType)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    switch (variantType)
    {
      case VariantType.Boolean when value is bool boolValue:
        writer.WriteBooleanValue(boolValue);
        break;

      case VariantType.Byte when value is byte byteValue:
        writer.WriteNumberValue(byteValue);
        break;

      case VariantType.Int16 when value is short shortValue:
        writer.WriteNumberValue(shortValue);
        break;

      case VariantType.Int32 when value is int intValue:
        writer.WriteNumberValue(intValue);
        break;

      case VariantType.Int64 when value is long longValue:
        writer.WriteNumberValue(longValue);
        break;

      case VariantType.UInt16 when value is ushort ushortValue:
        writer.WriteNumberValue(ushortValue);
        break;

      case VariantType.UInt32 when value is uint uintValue:
        writer.WriteNumberValue(uintValue);
        break;

      case VariantType.UInt64 when value is ulong ulongValue:
        writer.WriteNumberValue(ulongValue);
        break;

      case VariantType.Single when value is float floatValue:
        writer.WriteNumberValue(floatValue);
        break;

      case VariantType.Double when value is double doubleValue:
        writer.WriteNumberValue(doubleValue);
        break;

      case VariantType.Decimal when value is decimal decimalValue:
        writer.WriteNumberValue(decimalValue);
        break;

      case VariantType.DateTime when value is DateTime dateTimeValue:
        writer.WriteStringValue(dateTimeValue.ToString("o")); // ISO 8601 format
        break;

      case VariantType.String:
      case VariantType.Char:
        writer.WriteStringValue(value.ToString());
        break;

      default:
        writer.WriteStringValue(value.ToString());
        break;
    }
  }

  #endregion
}
