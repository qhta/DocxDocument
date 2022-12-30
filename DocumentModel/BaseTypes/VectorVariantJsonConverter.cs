using System.Diagnostics;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace DocumentModel.Properties;

public class VectorVariantJsonConverter : Newtonsoft.Json.JsonConverter<VectorVariant>
{
  public override void WriteJson(JsonWriter writer, VectorVariant? value, Newtonsoft.Json.JsonSerializer serializer)
  {
    if (value == null)
      return;
    writer.WriteStartObject();
    if (value.BaseType != null)
    {
      writer.WritePropertyName("BaseType");
      writer.WriteValue(value.BaseType);
    }
    if (value.Count > 0)
    {
      writer.WritePropertyName("Items");
      writer.WriteStartArray();
      foreach (var item in value)
      {
        serializer.Serialize(writer, item);
      }
      writer.WriteEndArray();
    }
    writer.WriteEndObject();
  }

  public override VectorVariant? ReadJson(JsonReader reader, Type objectType, VectorVariant? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
  {
    Debug.WriteLine("VectorVariantJsonConverter.ReadJson");
    return new VectorVariant();
  }
}


