using System.Text.Json;

using Newtonsoft.Json;

using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace DocumentModel.BaseTypes;

public class VariantJsonConverter : Newtonsoft.Json.JsonConverter<Variant>
{
  public override bool CanWrite => true;

  public override bool CanRead => true;

  public override void WriteJson(JsonWriter writer, Variant? value, JsonSerializer serializer)
  {
    writer.WriteStartObject();
    if (value != null)
    {
      writer.WritePropertyName(nameof(Variant.VariantType));
      writer.WriteRawValue('"' + value.VariantType.ToString() + '"');
      if (value?.Value != null)
      {
        writer.WritePropertyName(nameof(Variant.Value));
        writer.WriteStartObject();
        writer.WritePropertyName(value.Value.GetType().Name.ToLower());
        writer.WriteValue(value.Value);
        writer.WriteEndObject();
      }
    }
    writer.WriteEndObject();
  }

  public override Variant? ReadJson(JsonReader reader, Type objectType, Variant? existingValue, bool hasExistingValue, JsonSerializer serializer)
  {
    if (reader.TokenType == JsonToken.StartObject)
    {
      Variant result = new Variant();
      reader.Read();
      if (reader.TokenType == JsonToken.PropertyName)
      {
        var name = reader.Value as string;
        if (name == nameof(Variant.VariantType))
        {
          var str = reader.ReadAsString();
          if (!Enum.TryParse<VariantType>(str, out var variantType))
            throw new InvalidOperationException("VariantType expected");
          result.VariantType = variantType;
          reader.Read();
          if (reader.TokenType == JsonToken.PropertyName)
          {
            name = reader.Value as string;
            if (name == nameof(Variant.Value))
            {
              reader.Read();
              if (reader.TokenType == JsonToken.StartObject)
              {
                reader.Read();
                if (reader.TokenType == JsonToken.PropertyName)
                {
                  var typeTag = reader.Value as string;
                  switch (typeTag)
                  {
                    case "sbyte":
                      result.Value = (sbyte?)reader.ReadAsInt32();
                      reader.Read();
                      break;
                  }
                }
                if (reader.TokenType == JsonToken.EndObject)
                  reader.Read();
              }
            }
          }
        }
      }
      return result;
    }
    return null;
  }
}