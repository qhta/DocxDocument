using System.Diagnostics;
using Newtonsoft.Json;

namespace DocumentModel.Properties;

public class HeadingPairsJsonConverter: Newtonsoft.Json.JsonConverter<HeadingPairs>
{
  public override void WriteJson(JsonWriter writer, HeadingPairs? value, JsonSerializer serializer)
  {
    if (value == null)
      return;
    writer.WriteStartObject();
    if (value.VTVector != null)
    {
      writer.WritePropertyName("VTVector");
      serializer.Serialize(writer, value.VTVector);
    }
    writer.WriteEndObject();
  }

  public override HeadingPairs? ReadJson(JsonReader reader, Type objectType, HeadingPairs? existingValue, bool hasExistingValue, JsonSerializer serializer)
  {
    var result = new HeadingPairs();
    result.VTVector = (VectorVariant?)serializer.Deserialize(reader);
    return result;
  }
}