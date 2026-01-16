using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentModel
{
  public class ElementCollectionJsonConverter<TCollection, TItem> : JsonConverter<TCollection>
    where TCollection : ElementCollection<TItem>, new()
    where TItem : ICollectionItem
  {
    public override TCollection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      var items = JsonSerializer.Deserialize<List<TItem>>(ref reader, options);
      var collection = new TCollection();
      if (items != null)
      {
        foreach (var item in items)
          collection.Add(item);
      }
      return collection;
    }

    public override void Write(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options)
    {
      JsonSerializer.Serialize(writer, value, typeof(IEnumerable<TItem>), options);
    }
  }
}