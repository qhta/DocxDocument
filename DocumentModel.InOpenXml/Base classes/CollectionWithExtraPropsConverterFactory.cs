/// <summary>
/// A factory for creating JSON converters that handle collections with extra properties.
/// </summary>
public sealed class CollectionWithExtraPropsConverterFactory : JsonConverterFactory
{
  /// <summary>
  /// Checks if the specified type can be converted by this factory. It returns true if the type is an ElementCollection{T} for some T; otherwise, false.
  /// </summary>
  /// <param name="typeToConvert"></param>
  /// <returns></returns>
  public override bool CanConvert(Type typeToConvert)
    => GetElementCollectionItemType(typeToConvert) is not null;

  /// <summary>
  /// Creates a JSON converter for the specified type. It throws an InvalidOperationException if the type is not an ElementCollection{T} for some T.
  /// </summary>
  /// <param name="typeToConvert"></param>
  /// <param name="options"></param>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
  public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
  {
    Debug.WriteLine($"Creating converter for {typeToConvert}");
    var itemType = GetElementCollectionItemType(typeToConvert)
      ?? throw new InvalidOperationException("Not an ElementCollection<T> type.");

    var interfaces = typeToConvert.GetInterfaces().Where(intf => intf.Name.StartsWith("ICollection")).ToArray();
    foreach (var @interface in interfaces)
    {
      Debug.WriteLine($"  Interface: {@interface}");
    }

    var converterType = typeof(CollectionWithExtraPropsConverter<,>)
          .MakeGenericType(typeToConvert, itemType);

    var result = (JsonConverter)Activator.CreateInstance(converterType)!;
    return result;
  }

  private static Type? GetElementCollectionItemType(Type? type)
  {
    if (type == typeof(DXW.CompatibilitySetting)) Debug.Assert(true);
    while (type != typeof(object) && type is not null)
    {
      if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(DM.ElementCollection<>))
        return type.GetGenericArguments()[0];
      type = type.BaseType!;
    }
    return null;
  }
}

/// <summary>
/// Created JSON converter for collections that have extra properties.
/// This converter handles serialization and deserialization of collections that implement ICollection{TItem} and have additional public properties.
/// It serializes the collection as a JSON object with the extra properties and an "Items" property containing the collection items.
/// </summary>
/// <typeparam name="TCollection">The type of the collection.</typeparam>
/// <typeparam name="TItem">The type of the items in the collection.</typeparam>
public sealed class CollectionWithExtraPropsConverter<TCollection, TItem> : JsonConverter<TCollection>
  where TCollection : class, ICollection<TItem>, new()
{
  private static readonly PropertyInfo[] ExtraProps = typeof(TCollection)
    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
    .Where(p => p.CanRead && p.CanWrite && p.GetIndexParameters().Length == 0 && p.Name != "Count"
                && p.GetCustomAttribute<JsonIgnoreAttribute>(true) == null)
    .ToArray();

  /// <summary>
  /// Reads and deserializes a JSON object into an instance of TCollection.
  /// It handles both array and object representations of the collection, populating the extra properties and the collection items accordingly.
  /// </summary>
  /// <param name="reader">The Utf8JsonReader to read from.</param>
  /// <param name="typeToConvert">The type of the object to convert.</param>
  /// <param name="options">The serializer options to use.</param>
  /// <returns>An instance of TCollection populated with the deserialized data.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  public override TCollection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null) return null;

    var result = new TCollection();
    // var AddMethod = typeof(TCollection).GetMethod("Add", [typeof(TItem)]);
    if (reader.TokenType == JsonTokenType.StartArray)
    {
      var items = JsonSerializer.Deserialize<List<TItem>>(ref reader, options);
      if (items != null)
        foreach (var item in items)
          if (item != null)
            result.Add(item);
      return result;
    }

    using var doc = JsonDocument.ParseValue(ref reader);
    var root = doc.RootElement;

    foreach (var prop in ExtraProps)
      if (root.TryGetProperty(prop.Name, out var jsonProp) && jsonProp.ValueKind != JsonValueKind.Null)
        prop.SetValue(result, jsonProp.Deserialize(prop.PropertyType, options));

    if (root.TryGetProperty("Items", out var itemsProp))
    {
      var items = itemsProp.Deserialize<List<TItem>>(options);
      if (items != null)
        foreach (var item in items)
          if (item != null)
            result.Add(item);
    }

    return result;
  }

  /// <summary>
  /// Writes an instance of TCollection to JSON, including its extra properties and the collection items.
  /// </summary>
  /// <param name="writer">The Utf8JsonWriter to write to.</param>
  /// <param name="value">The instance of TCollection to serialize.</param>
  /// <param name="options">The serializer options to use.</param>
  public override void Write(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();

    foreach (var prop in ExtraProps)
    {
      var propValue = prop.GetValue(value);
      if (propValue is null) continue;
      writer.WritePropertyName(prop.Name);
      JsonSerializer.Serialize(writer, propValue, prop.PropertyType, options);
    }

    if (value.Any())
    {
      writer.WritePropertyName("Items");
      JsonSerializer.Serialize(writer, value, typeof(IEnumerable<TItem>), options);
    }

    writer.WriteEndObject();
  }
}