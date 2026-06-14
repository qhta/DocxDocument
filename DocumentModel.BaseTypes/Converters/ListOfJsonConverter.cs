namespace DocumentModel;

/// <summary>
/// Provides JSON serialization and deserialization support for the <see cref="List{T}"/> class.
/// </summary>
/// <typeparam name="T">The type of elements in the list. Must implement <see cref="IConvertible"/>.</typeparam>
/// <remarks>
/// This converter handles string and array JSON tokens for deserialization,
/// and writes List values as JSON arrays for compatibility with standard JSON conventions.
/// </remarks>
public class ListOfJsonConverter<T> : JsonConverter<ListOf<T>>
  where T : IConvertible
{
  /// <summary>
  /// Reads and converts JSON to a <see cref="List{T}"/> value.
  /// </summary>
  /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="List{T}"/> value parsed from the JSON input.</returns>
  /// <exception cref="JsonException">
  /// Thrown when:
  /// <list type="bullet">
  /// <item><description>The JSON token is a string but contains a null value.</description></item>
  /// <item><description>The JSON token is an array but contains non-convertible values.</description></item>
  /// <item><description>The JSON token is none of the expected types (string, array, or null).</description></item>
  /// </list>
  /// </exception>
  /// <remarks>
  /// Accepts the following input formats:
  /// <list type="bullet">
  /// <item><description>String tokens with space-separated values for numeric types (e.g., "1 2 3 4 5")</description></item>
  /// <item><description>String tokens with comma/semicolon-separated values for string types (e.g., "apple,banana,cherry")</description></item>
  /// <item><description>Array tokens with elements of type T (e.g., [1, 2, 3] or ["apple", "banana", "cherry"])</description></item>
  /// <item><description>Null tokens (returns null)</description></item>
  /// </list>
  /// </remarks>
  public override ListOf<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
    {
      return null;
    }

    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (value == null)
        return null;

      try
      {
        return new ListOf<T>(value);
      }
      catch (Exception ex)
      {
        throw new JsonException($"Invalid List<{typeof(T).Name}> string '{value}'. Error: {ex.Message}", ex);
      }
    }

    if (reader.TokenType == JsonTokenType.StartArray)
    {
      var list = new ListOf<T>();

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndArray)
        {
          return list;
        }

        if (reader.TokenType == JsonTokenType.Null)
        {
          // Skip null values in array
          continue;
        }

        try
        {
          T item;
          
          // Handle different JSON token types based on T
          if (typeof(T) == typeof(string))
          {
            if (reader.TokenType == JsonTokenType.String)
            {
              var strValue = reader.GetString();
              item = (T)(object)strValue!;
            }
            else
            {
              throw new JsonException($"Expected string value for List<string>, but got {reader.TokenType}");
            }
          }
          else if (typeof(T) == typeof(int) || typeof(T) == typeof(Int32))
          {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int intValue))
            {
              item = (T)(object)intValue;
            }
            else
            {
              throw new JsonException($"Expected number value for List<{typeof(T).Name}>, but got {reader.TokenType}");
            }
          }
          else if (typeof(T) == typeof(long) || typeof(T) == typeof(Int64))
          {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out long longValue))
            {
              item = (T)(object)longValue;
            }
            else
            {
              throw new JsonException($"Expected number value for List<{typeof(T).Name}>, but got {reader.TokenType}");
            }
          }
          else if (typeof(T) == typeof(double) || typeof(T) == typeof(Double))
          {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetDouble(out double doubleValue))
            {
              item = (T)(object)doubleValue;
            }
            else
            {
              throw new JsonException($"Expected number value for List<{typeof(T).Name}>, but got {reader.TokenType}");
            }
          }
          else if (typeof(T) == typeof(bool) || typeof(T) == typeof(Boolean))
          {
            if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
            {
              item = (T)(object)reader.GetBoolean();
            }
            else
            {
              throw new JsonException($"Expected boolean value for List<{typeof(T).Name}>, but got {reader.TokenType}");
            }
          }
          else
          {
            // For other IConvertible types, try to get as string and convert
            string? stringValue = null;
            
            if (reader.TokenType == JsonTokenType.String)
            {
              stringValue = reader.GetString();
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
              stringValue = reader.GetDouble().ToString(CultureInfo.InvariantCulture);
            }
            else if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
            {
              stringValue = reader.GetBoolean().ToString(CultureInfo.InvariantCulture);
            }
            
            if (stringValue != null)
            {
              item = (T)Convert.ChangeType(stringValue, typeof(T));
            }
            else
            {
              throw new JsonException($"Cannot convert {reader.TokenType} to List<{typeof(T).Name}>");
            }
          }
          
          list.Add(item);
        }
        catch (Exception ex) when (ex is not JsonException)
        {
          throw new JsonException($"Error converting array element to type {typeof(T).Name}. Error: {ex.Message}", ex);
        }
      }

      throw new JsonException($"Unexpected end of JSON array for List<{typeof(T).Name}>");
    }

    throw new JsonException($"Expected string, array, or null token for List<{typeof(T).Name}>, but got {reader.TokenType}");
  }

  /// <summary>
  /// Writes a <see cref="List{T}"/> value as JSON.
  /// </summary>
  /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
  /// <param name="value">The <see cref="List{T}"/> value to serialize.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <remarks>
  /// Writes the List value as a JSON array.
  /// For example, a list containing 1, 2, 3 is written as [1, 2, 3].
  /// A list containing "apple", "banana", "cherry" is written as ["apple", "banana", "cherry"].
  /// If the value is null, a JSON null is written.
  /// If the list is empty, an empty array [] is written.
  /// </remarks>
  public override void Write(Utf8JsonWriter writer, ListOf<T>? value, JsonSerializerOptions options)
  {
    if (value == null)
    {
      writer.WriteNullValue();
      return;
    }

    writer.WriteStartArray();
    
    foreach (var item in value)
    {
      if (item == null)
      {
        writer.WriteNullValue();
        continue;
      }

      // Write based on the type of T
      if (item is string strValue)
      {
        writer.WriteStringValue(strValue);
      }
      else if (item is int intValue)
      {
        writer.WriteNumberValue(intValue);
      }
      else if (item is long longValue)
      {
        writer.WriteNumberValue(longValue);
      }
      else if (item is double doubleValue)
      {
        writer.WriteNumberValue(doubleValue);
      }
      else if (item is float floatValue)
      {
        writer.WriteNumberValue(floatValue);
      }
      else if (item is decimal decimalValue)
      {
        writer.WriteNumberValue(decimalValue);
      }
      else if (item is bool boolValue)
      {
        writer.WriteBooleanValue(boolValue);
      }
      else if (item is byte byteValue)
      {
        writer.WriteNumberValue(byteValue);
      }
      else if (item is short shortValue)
      {
        writer.WriteNumberValue(shortValue);
      }
      else if (item is uint uintValue)
      {
        writer.WriteNumberValue(uintValue);
      }
      else if (item is ulong ulongValue)
      {
        writer.WriteNumberValue(ulongValue);
      }
      else if (item is ushort ushortValue)
      {
        writer.WriteNumberValue(ushortValue);
      }
      else
      {
        // For other IConvertible types, convert to string
        writer.WriteStringValue(item.ToString(CultureInfo.InvariantCulture));
      }
    }
    
    writer.WriteEndArray();
  }
}
