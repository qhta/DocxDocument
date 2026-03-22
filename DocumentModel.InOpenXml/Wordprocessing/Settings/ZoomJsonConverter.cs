using System;
using System.Text.Json.Serialization;
namespace DocumentModel.Wordprocessing
{
 /// <summary>
 ///   Provides custom JSON serialization and deserialization logic for the <see cref="Zoom"/> class, supporting both preset zoom kinds and percentage values in WordprocessingML settings.
 /// </summary>
 public class ZoomJsonConverter : JsonConverter<Zoom>
 {
  /// <summary>
  ///   Reads and converts JSON data to a <see cref="Zoom"/> object, supporting both string-based preset kinds and numeric percentage values.
  /// </summary>
  /// <param name="reader">The reader to read from.</param>
  /// <param name="typeToConvert">The type to convert (should be <see cref="Zoom"/>).</param>
  /// <param name="options">Options to control the conversion behavior.</param>
  /// <returns>A <see cref="Zoom"/> instance if conversion is successful; otherwise, throws <see cref="JsonException"/>.</returns>
  public override Zoom? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
   if (reader.TokenType == JsonTokenType.String)
   {
    var kindStr = reader.GetString();
    if (Enum.TryParse(typeof(PresetZoom), kindStr, out var kind))
     return new Zoom
     {
      Preset = (PresetZoom)kind!
     };
   }
   else if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int percent))
   {
    return new Zoom
    {
     Percent = percent
    };
   }
   throw new JsonException();
  }
  /// <summary>
  ///   Writes a <see cref="Zoom"/> object as JSON, using a string for preset kinds or a number for percentage values.
  /// </summary>
  /// <param name="writer">The writer to write to.</param>
  /// <param name="value">The <see cref="Zoom"/> value to convert.</param>
  /// <param name="options">Options to control the conversion behavior.</param>
  public override void Write(Utf8JsonWriter writer, Zoom value, JsonSerializerOptions options)
  {
   if (value.Preset != null)
   {
    writer.WriteStringValue(value.Preset.ToString());
   }
   else if (value.Percent != null)
   {
    writer.WriteNumberValue(value.Percent.Value);
   }
   else
   {
    writer.WriteNullValue();
   }
  }
 }
}