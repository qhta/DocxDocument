namespace DocumentModel;

internal class HexIntTypeJsonConverter : JsonConverter<IHexInt>
{
  public override void WriteJson(JsonWriter writer, IHexInt value, JsonSerializer serializer)
  {
    writer.WriteValue(value.ToString());
  }
  public override IHexInt ReadJson(JsonReader reader, Type objectType, IHexInt existingValue, bool hasExistingValue, JsonSerializer serializer)
  {
    var value = reader.Value;
    if (value is string str)
    {
      var result = new IHexInt(str);
      return result;
    }
    throw new InvalidOperationException($"Hex string expected, but {value} found");
  }
}