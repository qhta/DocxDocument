namespace DocumentModel;

/// <summary>
///   JSON converter that serializes enum values as string names rather than numeric values.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that enum values are written as their string names (e.g., "Dark1", "Accent2")
///   in JSON output rather than numeric values (e.g., 0, 1). During deserialization, the converter
///   reads string values and parses them back to the appropriate enum type, supporting both exact
///   matches and case-insensitive parsing.
///   </para>
///   <para>
///   String-based enum serialization provides several benefits:
///   <list type="bullet">
///   <item><description>Human-readable JSON output that's easier to debug and maintain</description></item>
///   <item><description>Better compatibility when enum values are reordered or new values are added</description></item>
///   <item><description>Self-documenting JSON that clearly indicates the meaning of each value</description></item>
///   <item><description>Simplified integration with external systems that expect string enum values</description></item>
///   </list>
///   </para>
///   <para>
///   This converter is applied using the <c>[JsonConverter(typeof(StringEnumConverter))]</c> attribute
///   on enum types that should be serialized as strings. It handles nullable enum types and provides
///   appropriate error messages when invalid string values are encountered during deserialization.
///   </para>
///   <para>
///   <b>Usage Example:</b>
///   <code>
///   [JsonConverter(typeof(StringEnumConverter))]
///   public enum ThemeColorIndex
///   {
///       Dark1,
///       Light1,
///       Accent1,
///       Accent2
///   }
///   
///   // Serializes to: { "color": "Accent1" }
///   // Instead of: { "color": 2 }
///   </code>
///   </para>
/// </remarks>
public class StringEnumConverter : JsonConverterFactory
{
  /// <summary>
  ///   Determines whether this converter can convert the specified type.
  /// </summary>
  /// <param name="typeToConvert">The type to check for conversion support.</param>
  /// <returns>
  ///   <see langword="true"/> if the type is an enum or nullable enum; otherwise <see langword="false"/>.
  /// </returns>
  public override bool CanConvert(Type typeToConvert)
  {
    // Handle both regular enums and Nullable<TEnum>
    var underlyingType = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;
    return underlyingType.IsEnum;
  }

  /// <summary>
  ///   Creates a concrete converter instance for the specified enum type.
  /// </summary>
  /// <param name="typeToConvert">The enum type to create a converter for.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>A converter instance that handles the specified enum type.</returns>
  public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
  {
    var underlyingType = Nullable.GetUnderlyingType(typeToConvert);
    var enumType = underlyingType ?? typeToConvert;
    var isNullable = underlyingType != null;

    var converterType = isNullable
        ? typeof(NullableStringEnumConverter<>).MakeGenericType(enumType)
        : typeof(StringEnumConverterInner<>).MakeGenericType(enumType);

    return (JsonConverter)Activator.CreateInstance(converterType)!;
  }

  /// <summary>
  ///   Inner converter that handles non-nullable enum types.
  /// </summary>
  /// <typeparam name="TEnum">The enum type to convert.</typeparam>
  private class StringEnumConverterInner<TEnum> : JsonConverter<TEnum>
      where TEnum : struct, Enum
  {
    /// <summary>
    ///   Reads an enum value from JSON as a string.
    /// </summary>
    /// <param name="reader">The JSON reader to read from.</param>
    /// <param name="typeToConvert">The type of enum to convert to.</param>
    /// <param name="options">The JSON serializer options.</param>
    /// <returns>The enum value parsed from the JSON string.</returns>
    /// <exception cref="JsonException">
    ///   Thrown when the JSON token is not a string or when the string value cannot be parsed as a valid enum value.
    /// </exception>
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      if (reader.TokenType != JsonTokenType.String)
      {
        throw new JsonException($"Expected string token for enum {typeof(TEnum).Name}, but got {reader.TokenType}");
      }

      var enumString = reader.GetString();
      if (string.IsNullOrEmpty(enumString))
      {
        throw new JsonException($"Empty string cannot be converted to enum {typeof(TEnum).Name}");
      }

      // Try exact match first, then case-insensitive match
      if (Enum.TryParse<TEnum>(enumString, ignoreCase: false, out var result))
      {
        return result;
      }

      if (Enum.TryParse<TEnum>(enumString, ignoreCase: true, out result))
      {
        return result;
      }

      throw new JsonException($"Unable to convert '{enumString}' to enum {typeof(TEnum).Name}");
    }

    /// <summary>
    ///   Writes an enum value to JSON as a string.
    /// </summary>
    /// <param name="writer">The JSON writer to write to.</param>
    /// <param name="value">The enum value to write.</param>
    /// <param name="options">The JSON serializer options.</param>
    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
      writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
    }
  }

  /// <summary>
  ///   Inner converter that handles nullable enum types.
  /// </summary>
  /// <typeparam name="TEnum">The enum type to convert.</typeparam>
  private class NullableStringEnumConverter<TEnum> : JsonConverter<TEnum?>
      where TEnum : struct, Enum
  {
    /// <summary>
    ///   Reads a nullable enum value from JSON.
    /// </summary>
    /// <param name="reader">The JSON reader to read from.</param>
    /// <param name="typeToConvert">The type of nullable enum to convert to.</param>
    /// <param name="options">The JSON serializer options.</param>
    /// <returns>
    ///   The enum value parsed from the JSON string, or <see langword="null"/> if the JSON value is null.
    /// </returns>
    /// <exception cref="JsonException">
    ///   Thrown when the JSON token is not a string or null, or when the string value cannot be parsed as a valid enum value.
    /// </exception>
    public override TEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      if (reader.TokenType == JsonTokenType.Null)
      {
        return null;
      }

      if (reader.TokenType != JsonTokenType.String)
      {
        throw new JsonException($"Expected string or null token for enum {typeof(TEnum).Name}, but got {reader.TokenType}");
      }

      var enumString = reader.GetString();
      if (string.IsNullOrEmpty(enumString))
      {
        return null;
      }

      // Try exact match first, then case-insensitive match
      if (Enum.TryParse<TEnum>(enumString, ignoreCase: false, out var result))
      {
        return result;
      }

      if (Enum.TryParse<TEnum>(enumString, ignoreCase: true, out result))
      {
        return result;
      }

      throw new JsonException($"Unable to convert '{enumString}' to enum {typeof(TEnum).Name}");
    }

    /// <summary>
    ///   Writes a nullable enum value to JSON.
    /// </summary>
    /// <param name="writer">The JSON writer to write to.</param>
    /// <param name="value">The nullable enum value to write.</param>
    /// <param name="options">The JSON serializer options.</param>
    public override void Write(Utf8JsonWriter writer, TEnum? value, JsonSerializerOptions options)
    {
      if (value.HasValue)
      {
        writer.WriteStringValue(value.Value.ToString(CultureInfo.InvariantCulture));
      }
      else
      {
        writer.WriteNullValue();
      }
    }
  }
}
