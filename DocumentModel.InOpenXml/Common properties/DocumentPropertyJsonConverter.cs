namespace DocumentModel;

/// <summary>
/// Json converter for serializing and deserializing document properties. This converter handles the conversion of DocumentProperty objects to and from JSON format, ensuring that the Name and Value properties are correctly represented in the JSON structure. The converter also takes into account the expected type of the Value property based on the Name of the property, using a mapping to determine the appropriate type for deserialization.
/// </summary>
public sealed class DocumentPropertyJsonConverter : JsonConverter<DM.DocumentProperty>
{
  static DocumentPropertyJsonConverter()
  {
    TypeToStringConverter.RegisterAssembly(typeof(DocumentProperty).Assembly);
  }
  /// <summary>
  /// Reads and converts the JSON to a DocumentProperty object. It parses the JSON structure to extract the Name and Value properties, and uses the KnownProperties mapping to determine the expected type of the Value property based on the Name of the property. If the Name is found in the KnownProperties, it deserializes the Value to the appropriate type; otherwise, it leaves the Value as null.
  /// </summary>
  public override DocumentProperty? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    using var doc = JsonDocument.ParseValue(ref reader);
    var root = doc.RootElement;

    DocumentProperty p;
    var propertyIdStr = root.TryGetProperty("PropertyId", out var propertyIdEl)
      ? propertyIdEl.GetString()
      : null;
    if (!string.IsNullOrEmpty(propertyIdStr))
    {
      var propertyId = Int32.Parse(propertyIdStr);
      var linkTarget = root.TryGetProperty("LinkTarget", out var linkTargetEl)
        ? linkTargetEl.GetString()
        : null;

      p = new CustomProperty
      {
        PropertyId = propertyId,
        Name = root.GetProperty("Name").GetString()!,
        LinkTarget = linkTarget,
      };
    }
    else
    {
      p = new BuiltInProperty()
      {
        Name = root.GetProperty("Name").GetString()!,
      };
    }


    var TypeName = root.GetProperty("Type").GetString();
    Type? targetType = null;

    if (!String.IsNullOrEmpty(TypeName))
    {
      targetType = TypeToStringConverter.ResolveType(TypeName);
    }

    if (root.TryGetProperty("Value", out var valueEl))
    {
      if (targetType == null)
        throw new ApplicationException("Target type could not be determined in DocumentPropertyJsonConverter.");
      var str =valueEl.GetString();
      if (str!=null)
      {
        var value = ObjectToStringConverter.ConvertFromString(str!, targetType);
        p.Value = value;
      }
    }

    return p;
  }

  /// <summary>
  /// Writes a DocumentProperty object as JSON. It constructs a JSON object with the Name and Value properties of the DocumentProperty. The Value property is serialized according to its actual type, ensuring that the JSON representation accurately reflects the structure of the DocumentProperty object.
  /// </summary>
  /// <param name="writer"></param>
  /// <param name="value"></param>
  /// <param name="options"></param>
  public override void Write(Utf8JsonWriter writer, DocumentProperty value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();
    if (value.PropertyId.HasValue)
      writer.WriteString("PropertyId",value.PropertyId.ToString());
    writer.WriteString("Name", value.Name);
    if (value.LinkTarget!=null)
      writer.WriteString("LinkTarget", value.LinkTarget);
    var type = value.Value?.GetType() ?? value.Type;
    if (type!=null)
    {
      TypeToStringConverter.RegisterType(type);
      writer.WriteString("Type", type.Name);
    }
    writer.WritePropertyName("Value");

    if (value.Value is null) writer.WriteNullValue();
    else 
    {
      var str = ObjectToStringConverter.ConvertToString(value.Value);
      JsonSerializer.Serialize(writer, str, typeof(string), options);
    }
    writer.WriteEndObject();
  }
}