using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel.Vml;

[JsonConverter(typeof(RulesJsonConverter))]
public partial class Rules
{
}

internal sealed class RulesJsonConverter : JsonConverter<Rules>
{
  public override Rules? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null)
      return null;

    var result = new Rules();

    // Backward compatibility: allow plain array payload
    if (reader.TokenType == JsonTokenType.StartArray)
    {
      var items = JsonSerializer.Deserialize<List<Rule>>(ref reader, options);
      if (items != null)
      {
        foreach (var item in items)
          result.Add(item);
      }
      return result;
    }

    if (reader.TokenType != JsonTokenType.StartObject)
      throw new JsonException("Expected object or array for Rules.");

    using var doc = JsonDocument.ParseValue(ref reader);
    var root = doc.RootElement;

    if (root.TryGetProperty("Extension", out var extensionProp) &&
        extensionProp.ValueKind != JsonValueKind.Null)
    {
      result.Extension = extensionProp.Deserialize<ExtensionHandlingBehavior>(options);
    }

    if (root.TryGetProperty("Items", out var itemsProp) &&
        itemsProp.ValueKind == JsonValueKind.Array)
    {
      var items = itemsProp.Deserialize<List<Rule>>(options);
      if (items != null)
      {
        foreach (var item in items)
          result.Add(item);
      }
    }

    return result;
  }

  public override void Write(Utf8JsonWriter writer, Rules value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();

    if (value.Extension is not null)
    {
      writer.WritePropertyName("Extension");
      JsonSerializer.Serialize(writer, value.Extension, options);
    }

    writer.WritePropertyName("Items");
    JsonSerializer.Serialize(writer, value, typeof(IEnumerable<Rule>), options);

    writer.WriteEndObject();
  }
}