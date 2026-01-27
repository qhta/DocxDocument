using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DocumentModel
{
  /// <summary>
  ///   Provides a custom JSON converter for <c>ElementCollection&lt;T&gt;</c> types, enabling correct serialization and deserialization of collection elements in the document model.
  ///   Supports both direct and derived types of <c>ElementCollection&lt;T&gt;</c>.
  /// </summary>
  /// <typeparam name="TCollection">The type of the element collection to convert.</typeparam>
  /// <typeparam name="TItem">The type of items contained in the collection.</typeparam>
  public class ElementCollectionJsonConverter<TCollection, TItem> : JsonConverter<TCollection>
    where TCollection : ElementCollection<TItem>, new()
    where TItem : ICollectionItem
  {
    /// <summary>
    ///   Reads and deserializes a JSON array into an <c>ElementCollection&lt;T&gt;</c> instance.
    /// </summary>
    /// <param name="reader">The reader to read from.</param>
    /// <param name="typeToConvert">The type to convert (should be <c>ElementCollection&lt;T&gt;</c>).</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    /// <returns>A new <typeparamref name="TCollection"/> instance containing the deserialized items, or null if the array is null.</returns>
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

    /// <summary>
    ///   Serializes an <c>ElementCollection&lt;T&gt;</c> instance as a JSON array of items.
    /// </summary>
    /// <param name="writer">The writer to write to.</param>
    /// <param name="value">The <typeparamref name="TCollection"/> value to convert.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    public override void Write(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options)
    {
      JsonSerializer.Serialize(writer, value, typeof(IEnumerable<TItem>), options);
    }
  }
}
