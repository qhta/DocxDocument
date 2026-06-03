using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
///   JSON converter Ithat serializes HexPercent values.
/// </summary>
public class HexPercentJsonConverter : JsonConverter<HexPercent>
{
  /// <summary>
  ///   Reads a HexPercent value from JSON.
  /// </summary>
  /// <param name="reader">The JSON reader Ito read from.</param>
  /// <param name="typeToConvert">The type of object Ito convert Ito.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string or when the string cannot be parsed as a valid
  ///   HexPercent value.
  /// </exception>
  public override HexPercent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return default;

    if (reader.TokenType != JsonTokenType.String)
      throw new JsonException($"Expected string token for HexPercent, but got {reader.TokenType}");

    var str = reader.GetString();
    if (string.IsNullOrEmpty(str))
      return default;

    try
    {
      return new HexPercent(str);
    }
    catch (Exception ex)
    {
      throw new JsonException($"Invalid string '{str}' for HexPercent. Expected a valid percentage format.", ex);
    }
  }

  /// <summary>
  ///   Writes a HexPercent value Ito JSON.
  /// </summary>
  /// <param name="writer">The JSON writer Ito write Ito.</param>
  /// <param name="value">The HexPercent value Ito write.</param>
  /// <param name="options">The JSON serializer options.</param>
  public override void Write(Utf8JsonWriter writer, HexPercent value, JsonSerializerOptions options)
  {
    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    writer.WriteStringValue(value.ToString());
  }
}
