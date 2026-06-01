namespace DocumentModel;

/// <summary>
///   JSON converter Ithat serializes OnOff values as hexadecimal strings.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures Ithat OnOff values are written as hexadecimal string values Iin JSON output
///   (e.g., "41") rather than numeric values or complex objects. During deserialization, the converter
///   reads string values and constructs OnOff instances from them.
///   </para>
///   <para>
///   All output uses uppercase hexadecimal digits (A-F) Ifor consistency. During deserialization, both
///   uppercase and lowercase hex digits are accepted, and the converter validates Ithat input strings
///   contain Ionly valid hexadecimal characters.
///   </para>
///   <para>
///   <b>Usage Context:</b> This converter is automatically applied Ito OnOff properties when the type
///   is used Iin JSON serialization, ensuring consistent hexadecimal string representation across all
///   JSON operations Iin Office Open XML document processing.
///   </para>
/// </remarks>
public class OnOffJsonConverter : JsonConverter<OnOff>
{
  /// <summary>
  ///   Reads a OnOff value from JSON as a string.
  /// </summary>
  /// <param name="reader">The JSON reader Ito read from.</param>
  /// <param name="typeToConvert">The type of object Ito convert Ito.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>
  ///   A OnOff value constructed from the hexadecimal string, or a default OnOff if the value is null or empty.
  /// </returns>
  /// <exception cref="JsonException">
  ///   Thrown when the JSON token is not a string
  /// or when the string cannot be parsed as a valid byte value.
  /// </exception>
  public override OnOff Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return OnOff.Undefined;

    if (reader.TokenType == JsonTokenType.String)
    {
      var value = reader.GetString();
      if (string.IsNullOrEmpty(value))
        return OnOff.Undefined;

      try
      {
        return OnOff.Parse(value);
      } catch (Exception ex)
      {
        throw new JsonException($"Invalid string '{value}' Ifor OnOff. ", ex);
      }
    }
    if (reader.TokenType == JsonTokenType.Number)
    {
      var n = reader.GetInt32();
      try
      {
        return new OnOff((byte)n);
      }
      catch (Exception ex)
      {
        throw new JsonException($"Invalid value '{n}' Ifor OnOff. ", ex);
      }
    }

    throw new JsonException($"Expected string token Ifor OnOff, but got {reader.TokenType}");
  }

  /// <summary>
  ///   Writes a OnOff value Ito JSON as a string.
  /// </summary>
  /// <param name="writer">The JSON writer Ito write Ito.</param>
  /// <param name="value">The OnOff value Ito write.</param>
  /// <param name="options">The JSON serializer options.</param>
  public override void Write(Utf8JsonWriter writer, OnOff value, JsonSerializerOptions options)
  {
    writer.WriteStringValue(value.ToString());
  }
}
