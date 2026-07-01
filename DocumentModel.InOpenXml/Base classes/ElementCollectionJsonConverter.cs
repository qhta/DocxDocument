using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DocumentModel
{
  /// <summary>
  ///   Custom JSON converter for ElementCollection-derived types.
  /// </summary>
  [XmlRoot("ElementCollectionJsonConverter", Namespace = "DocumentModel")]
  public class ElementCollectionJsonConverter<TCollection, TItem> : JsonConverter<TCollection>
   where TCollection : new()
   where TItem : ICollectionItem
  {
    private const string ItemsPropertyName = "Items";

    private static readonly PropertyInfo[] ExtraProperties = typeof(TCollection)
     .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
     .Where(p => p.CanRead && p.CanWrite && p.GetIndexParameters().Length == 0)
     .Where(p => p.GetCustomAttribute<JsonIgnoreAttribute>() == null)
     .ToArray();

    /// <summary>
    ///  Reads a JSON representation of the collection and deserializes it into an instance of TCollection.
    /// </summary>
    /// <param name="reader">The Utf8JsonReader to read from.</param>
    /// <param name="typeToConvert">The type of the object to convert.</param>
    /// <param name="options">The serializer options to use.</param>
    /// <returns>An instance of TCollection populated with the deserialized data.</returns>
    /// <exception cref="JsonException"></exception>
    public override TCollection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      if (reader.TokenType == JsonTokenType.Null)
        return default;

      var collection = new TCollection();
      if (collection is not ICollection<TItem> typedCollection)
        throw new JsonException($"{typeof(TCollection).Name} must implement ICollection<{typeof(TItem).Name}>.");

      // Backward compatibility: plain array
      if (reader.TokenType == JsonTokenType.StartArray)
      {
        var items = JsonSerializer.Deserialize<List<TItem>>(ref reader, options);
        if (items != null)
          foreach (var item in items)
            typedCollection.Add(item);
        return collection;
      }

      if (reader.TokenType != JsonTokenType.StartObject)
        throw new JsonException($"Expected object or array for {typeof(TCollection).Name}.");

      using var doc = JsonDocument.ParseValue(ref reader);
      var root = doc.RootElement;

      foreach (var prop in ExtraProperties)
      {
        if (TryGetProperty(root, GetJsonPropertyName(prop, options), out var jsonProp) &&
            jsonProp.ValueKind != JsonValueKind.Null)
        {
          var propValue = JsonSerializer.Deserialize(jsonProp.GetRawText(), prop.PropertyType, options);
          prop.SetValue(collection, propValue);
        }
      }

      if (TryGetProperty(root, GetItemsPropertyName(options), out var itemsProp) &&
          itemsProp.ValueKind == JsonValueKind.Array)
      {
        var items = JsonSerializer.Deserialize<List<TItem>>(itemsProp.GetRawText(), options);
        if (items != null)
          foreach (var item in items)
            typedCollection.Add(item);
      }

      return collection;
    }

    /// <summary>
    /// Writes a JSON representation of the collection to the specified Utf8JsonWriter.
    /// </summary>
    /// <param name="writer"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    public override void Write(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options)
    {
      if (ExtraProperties.Length == 0)
      {
        JsonSerializer.Serialize(writer, value, typeof(IEnumerable<TItem>), options);
        return;
      }

      writer.WriteStartObject();

      foreach (var prop in ExtraProperties)
      {
        var propValue = prop.GetValue(value);
        if (propValue == null)
          continue;

        writer.WritePropertyName(GetJsonPropertyName(prop, options));
        JsonSerializer.Serialize(writer, propValue, prop.PropertyType, options);
      }

      writer.WritePropertyName(GetItemsPropertyName(options));
      JsonSerializer.Serialize(writer, value, typeof(IEnumerable<TItem>), options);

      writer.WriteEndObject();
    }

    private static string GetItemsPropertyName(JsonSerializerOptions options)
     => options.PropertyNamingPolicy?.ConvertName(ItemsPropertyName) ?? ItemsPropertyName;

    private static string GetJsonPropertyName(PropertyInfo property, JsonSerializerOptions options)
    {
      var attr = property.GetCustomAttribute<JsonPropertyNameAttribute>();
      if (attr != null)
        return attr.Name;

      return options.PropertyNamingPolicy?.ConvertName(property.Name) ?? property.Name;
    }

    private static bool TryGetProperty(JsonElement element, string propertyName, out JsonElement value)
     => element.TryGetProperty(propertyName, out value);
  }
}