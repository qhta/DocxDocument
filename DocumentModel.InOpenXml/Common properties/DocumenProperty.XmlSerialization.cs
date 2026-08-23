namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="DocumentProperty"/> class.
/// </summary>
public partial class DocumentProperty : IXmlSerializable
{
  static DocumentProperty()
  {
    // Register known types for XML serialization
    TypeToStringConverter.RegisterType(typeof(DocumentProperty));
  }

  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    // Read attributes
    string? propertyIdStr = reader.GetAttribute("propertyId");
    int? propertyId = null;
    if (!string.IsNullOrEmpty(propertyIdStr))
      propertyId = int.Parse(propertyIdStr);

    string? name = reader.GetAttribute("name");

    Type? valueType = null;
    DocumentPropertyType expectedType = DocumentPropertyType.Unknown;
    string? typeName = reader.GetAttribute("type");
    if (typeName != null)
    {
      if (Enum.TryParse<DocumentPropertyType>(typeName, out var parsedType))
      {
        expectedType = parsedType;
        valueType = expectedType.ConvertToSystemType();
      }
      else
      {
        valueType = TypeToStringConverter.ResolveType(typeName);
        expectedType = valueType.ConvertToDocumentPropertyType();
      }
    }
    typeName = reader.GetAttribute("expectedType");
    if (typeName != null)
    {
      if (Enum.TryParse<DocumentPropertyType>(typeName, out var parsedType))
      {
        expectedType = parsedType;
      }
    }


    string? linkTarget = reader.GetAttribute("linkTarget");
    reader.Read(); // Move to content
    object? value = null;
    if (reader.HasValue)
    {
      var str = reader.Value;
      value = ObjectToStringConverter.ConvertFromString(str, valueType ?? typeof(object));
    }
    else
    {
      if (reader.NodeType == XmlNodeType.Element)
      {
        if (valueType != null)
        {
          value = Activator.CreateInstance(valueType);
          if (value is IXmlSerializable xmlSerializable)
            xmlSerializable.ReadXml(reader);
        }
      }
    }
    if (value == null)
      valueType = null;

    var documentProperty = new CustomProperty
    {
      PropertyId = propertyId,
      Name = name,
      Value = value,
      ExpectedType = expectedType,
      ValueType = valueType,
      LinkTarget = linkTarget
    };
    System.Runtime.CompilerServices.Unsafe.AsRef(in _propertyId) = propertyId;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _name) = documentProperty.Name;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _expectedType) = documentProperty.ExpectedType;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _valueType) = documentProperty.ValueType;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = documentProperty.Value;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _linkTarget) = documentProperty.LinkTarget;

    if (reader.NodeType == XmlNodeType.Text) reader.Read(); // Move past text node
    if (reader.NodeType == XmlNodeType.EndElement) reader.Read(); // Move past end element

  }

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    if (PropertyId != null)
      writer.WriteAttributeString("propertyId", PropertyId.ToString());

    writer.WriteAttributeString("name", Name);

    var valueType = Value?.GetType() ?? ValueType;
    var expectedType = ExpectedType;
    if (expectedType == DocumentPropertyType.Unknown && valueType != null)
      expectedType = valueType.ConvertToDocumentPropertyType();

    if (valueType != null && expectedType != DocumentPropertyType.Unknown
                          && valueType == expectedType.ConvertToSystemType())
    {
      TypeToStringConverter.RegisterType(valueType);
      writer.WriteAttributeString("type", expectedType.ToString());
    }
    else
    {
      if (valueType != null)
      {
        TypeToStringConverter.RegisterType(valueType);
        writer.WriteAttributeString("type", valueType.Name);
      }
      if (expectedType != DocumentPropertyType.Unknown)
      {
        writer.WriteAttributeString("expectedType", expectedType.ToString());
      }
    }

    if (LinkTarget != null)
    {
      writer.WriteAttributeString("linkTarget", LinkTarget);
    }

    if (Value is not null)
    {
      var str = ObjectToStringConverter.ConvertToString(Value);
      if (str != null)
        writer.WriteValue(str);
      else if (Value is IXmlSerializable serializable)
      {
        writer.WriteStartElement(Value.GetType().Name);
        serializable.WriteXml(writer);
        writer.WriteEndElement();
      }

    }
  }

}
