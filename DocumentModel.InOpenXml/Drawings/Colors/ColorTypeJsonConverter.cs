namespace DocumentModel;

/// <summary>
/// Json converter for serializing and deserializing color types. This converter handles the conversion
/// of ColorType objects to and from JSON format, ensuring that the Name and Value properties are correctly represented in the JSON structure. The converter also takes into account the expected type of the Value property based on the Name of the property, using a mapping to determine the appropriate type for deserialization.
/// </summary>
public class ColorTypeJsonConverter<T> : JsonConverter<T> where T : DMD.ColorType, new()
{
  static ColorTypeJsonConverter()
  {
    TypeToStringConverter.RegisterAssembly(typeof(DMD.ColorType).Assembly);
  }
  /// <summary>
  /// Reads and converts the JSON to a ColorType object of type T. 
  /// </summary>
  /// <param name="reader">The JSON reader.</param>
  /// <param name="typeToConvert">The type to convert.</param>
  /// <param name="options">The JSON serializer options.</param>
  /// <returns>The deserialized ColorType object of type T.</returns>
  /// <exception cref="ApplicationException"></exception>
  public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    using var doc = JsonDocument.ParseValue(ref reader);
    var root = doc.RootElement;
    T p = new T
    {
      Name = root.GetProperty("Name").GetString()!,
    };
    if (root.TryGetProperty("PropertyId", out var propertyIdEl))
    {
      if (propertyIdEl.TryGetInt32(out var propertyId))
      {
        p.PropertyId = propertyId;
      }
    }

    Type? valueType = null;
    DocumentPropertyType expectedType = DocumentPropertyType.Unknown;
    if (root.TryGetProperty("Type", out var typeEl))
    {
      var typeName = typeEl.GetString();
      if (typeName == "Variant")
        Debug.Assert(true);
      if (Enum.TryParse<DocumentPropertyType>(typeName, out var parsedType))
      {
        expectedType = parsedType;
        valueType = expectedType.ConvertToSystemType();
      }
      else
      {
        valueType = TypeToStringConverter.ResolveType(typeName!);
        expectedType = valueType.ConvertToDocumentPropertyType();
      }
    }
    if (root.TryGetProperty("ExpectedType", out var expectedTypeEl))
    {
      var typeName = expectedTypeEl.GetString();
      if (Enum.TryParse<DocumentPropertyType>(typeName, out var parsedType))
      {
        expectedType = parsedType;
      }
    }
    p.ExpectedType = expectedType;
    p.ValueType = valueType;
    if (root.TryGetProperty("LinkTarget", out var linkTargetEl))
    {
      p.LinkTarget = linkTargetEl.GetString();
    }

    if (root.TryGetProperty("Value", out var valueEl) && valueEl.ValueKind != JsonValueKind.Null)
    {
      if (valueType == null)
        throw new ApplicationException("Target type could not be determined in BuiltInPropertyJsonConverter.");

      var str = valueEl.GetString();
      if (str != null)
      {
        if (valueType == typeof(Variant))
          Debug.Assert(true);
        var value = ObjectToStringConverter.ConvertFromString(str!, valueType);
        p.Value = value;
      }
    }
    else
      p.ValueType = null;

    return p;
  }

  /// <summary>
  /// Writes any type of ColorType as JSON. 
  /// </summary>
  /// <param name="writer">Writer</param>
  /// <param name="value">ColorType value</param>
  /// <param name="options">Serialization options</param>
  public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();
    if (value.Model != null)
    {
      writer.WriteString("Model", value.Model!.ToString());
      switch (value.Model)
      {

      }
    }
    writer.WriteEndObject();
  }
}