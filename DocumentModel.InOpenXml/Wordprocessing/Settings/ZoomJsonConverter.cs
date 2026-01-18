using System;
using System.Text.Json.Serialization;

namespace DocumentModel.Wordprocessing
{
  public class ZoomJsonConverter : JsonConverter<Zoom>
  {
    public override Zoom? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      if (reader.TokenType == JsonTokenType.String)
      {
        var kindStr = reader.GetString();
        if (Enum.TryParse(typeof(PresetZoomKind), kindStr, out var kind))
          return new Zoom { Kind = (PresetZoomKind)kind! };
      }
      else if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int percent))
      {
        return new Zoom { Percent = percent };
      }
      throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, Zoom value, JsonSerializerOptions options)
    {
      if (value.Kind != null)
      {
        writer.WriteStringValue(value.Kind.ToString());
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