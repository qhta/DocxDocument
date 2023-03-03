namespace DocumentModel;

internal class HexIntTypeJsonConverter : JsonConverter<HexInt>
{
  public override void WriteJson(JsonWriter writer, HexInt value, JsonSerializer serializer)
  {
    writer.WriteValue(value.ToString());
  }

  public override HexInt ReadJson(JsonReader reader, Type objectType, HexInt existingValue, bool hasExistingValue, JsonSerializer serializer)
  {
    var value = reader.Value;
    if (value is string str)
    {
      var result = new HexInt(str);
      return result;
    }
    throw new InvalidOperationException($"Hex string expected, but {value} found");
  }
}