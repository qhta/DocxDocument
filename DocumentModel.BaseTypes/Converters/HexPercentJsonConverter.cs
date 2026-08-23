namespace DocumentModel;

/// <summary>
///   JSON converter that serializes HexPercent values.
/// </summary>
public class HexPercentJsonConverter : JsonConverter<HexPercent>
{
  /// <summary>
  ///   Reads a HexPercent value from JSON.
  /// </summary>
  /// <param name="reader">The JSON reader to read from.</param>
  /// <param name="typeToConvert">The type of object to convert to.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or when the string cannot be parsed as a valid
  ///   HexPercent value.
  /// </exception>
  public override HexPercent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return default;

    if (reader.TokenType == JsonTokenType.String)
    {
      var str = reader.GetString();
      try
      {
        if (string.IsNullOrEmpty(str))
          return default;

        return new HexPercent(str!);
      }
      catch (Exception ex)
      {
        throw new JsonException($"Invalid string '{str}' for HexPercent. Expected a valid percentage format.", ex);
      }
    }
    if (reader.TokenType == JsonTokenType.Number)
    {
      var decValue = reader.GetDecimal().ToString(CultureInfo.InvariantCulture);
      return new HexPercent(decValue);
    }
    throw new JsonException($"Invalid token '{reader.TokenType}' for HexPercent. Expected string or number.");
  }

  /// <summary>
  ///   Writes a HexPercent value to JSON.
  /// </summary>
  /// <param name="writer">The JSON writer to write to.</param>
  /// <param name="value">The HexPercent value to write.</param>
  /// <param name="options">The JSON serializer options.</param>
  public override void Write(Utf8JsonWriter writer, HexPercent value, JsonSerializerOptions options)
  {
    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    writer.WriteStringValue(value.ToHexString());
  }
}
