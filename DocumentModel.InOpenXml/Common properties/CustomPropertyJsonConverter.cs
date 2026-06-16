using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;

namespace DocumentModel;

/// <summary>
/// Json converter for serializing and deserializing custom document properties. This converter handles the conversion of CustomProperty objects to and from JSON format, ensuring that the Name and Value properties are correctly represented in the JSON structure. The converter also takes into account the expected type of the Value property based on the Name of the property, using a mapping to determine the appropriate type for deserialization.
/// </summary>
public sealed class CustomPropertyJsonConverter : JsonConverter<DM.CustomProperty>
{
  static CustomPropertyJsonConverter()
  {
    TypeToStringConverter.RegisterAssembly(typeof(DocumentProperty).Assembly);
  }
  /// <summary>
  /// Reads and converts the JSON to a CustomProperty object. It parses the JSON structure to extract the Name and Value properties, and uses the KnownProperties mapping to determine the expected type of the Value property based on the Name of the property. If the Name is found in the KnownProperties, it deserializes the Value to the appropriate type; otherwise, it leaves the Value as null.
  /// </summary>
  public override CustomProperty? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    using var doc = JsonDocument.ParseValue(ref reader);
    var root = doc.RootElement;

    var p = new CustomProperty
    {
      Name = root.GetProperty("Name").GetString()!,
    };
    var propertyIdStr = root.GetProperty("PropertyId").GetString();
    if (!string.IsNullOrEmpty(propertyIdStr)) p.PropertyId = Int32.Parse(propertyIdStr);

    string? typeName = null;
    if (root.TryGetProperty("Type", out var typeNameEl))
      typeName = typeNameEl.ToString();
    Type? targetType = null;

    if (!String.IsNullOrEmpty(typeName))
    {
      targetType = TypeToStringConverter.ResolveType(typeName);
    }
    var linkTarget = root.TryGetProperty("LinkTarget", out var linkTargetEl)
      ? linkTargetEl.GetString()
      : null;
    p.LinkTarget = linkTarget;

    if (root.TryGetProperty("Value", out var valueEl))
    {
      if (targetType == null)
        throw new ApplicationException("Target type could not be determined in CustomPropertyJsonConverter.");
      var str =valueEl.GetString();
      if (str!=null)
      {
        var value = ObjectToStringConverter.ConvertFromString(str!, targetType);
        p.Value = value;
      }
    }
    else if (targetType!=null)
    {
      p.Type = targetType;
    }

    return p;
  }

  /// <summary>
  /// Writes a CustomProperty object as JSON. It constructs a JSON object with the Name and Value properties of the CustomProperty. The Value property is serialized according to its actual type, ensuring that the JSON representation accurately reflects the structure of the CustomProperty object.
  /// </summary>
  /// <param name="writer"></param>
  /// <param name="value"></param>
  /// <param name="options"></param>
  public override void Write(Utf8JsonWriter writer, CustomProperty value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();
    writer.WriteString("PropertyId",value.PropertyId?.ToString());
    writer.WriteString("Name", value.Name);
    var type = value.Value?.GetType() ?? value.Type;
    if (type!=null)
    {
      TypeToStringConverter.RegisterType(type);
      writer.WriteString("Type", type.Name);
    }
    if (!string.IsNullOrEmpty(value.LinkTarget)) writer.WriteString("LinkTarget", value.LinkTarget);
    if (value.Value!=null)
    {
      writer.WritePropertyName("Value");
      var str = ObjectToStringConverter.ConvertToString(value.Value);
      JsonSerializer.Serialize(writer, str, typeof(string), options);
    }
    writer.WriteEndObject();
  }
}