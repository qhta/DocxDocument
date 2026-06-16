namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="CustomProperty"/> class.
/// </summary>
public partial class CustomProperty : IXmlSerializable
{
  static CustomProperty()
  {
    // Register known types for XML serialization
    TypeToStringConverter.RegisterType(typeof(CustomProperty));
  }

  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    // Read attributes
    string? name = reader.GetAttribute("name");
    string? propertyIdStr = reader.GetAttribute("propertyId");
    string? linkTarget = reader.GetAttribute("linkTarget");
    string? typename = reader.GetAttribute("type");


    reader.Read(); // Move to content

    var str = reader.Value;
    object? value = null;
    Type? type = null;
    if (!String.IsNullOrEmpty(str))
    {
      if (typename != null) type = TypeToStringConverter.ResolveType(typename);
      value = ObjectToStringConverter.ConvertFromString(str, type ?? typeof(object));
    }

    var CustomProperty = new CustomProperty
    {
      PropertyId = propertyIdStr != null ? int.Parse(propertyIdStr) : null,
      Name = name,
      Value = value,
      Type = type,
      LinkTarget = linkTarget
    };
    System.Runtime.CompilerServices.Unsafe.AsRef(in _propertyId) = CustomProperty.PropertyId;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _name) = CustomProperty.Name;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _type) = CustomProperty.Type;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = CustomProperty.Value;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _linkTarget) = CustomProperty.LinkTarget;
    if (reader.NodeType == XmlNodeType.Text) reader.Read(); // Move past text node
    if (reader.NodeType == XmlNodeType.EndElement) reader.Read(); // Move past end element

  }

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write attributes
    writer.WriteAttributeString("name", Name);
    writer.WriteAttributeString("propertyId", PropertyId.ToString());
    if (LinkTarget != null)
      writer.WriteAttributeString("linkTarget", LinkTarget);



    if (Value is not null)
    {
      var type = Value?.GetType() ?? Type;
      if (type != null)
      {
        TypeToStringConverter.RegisterType(type);
        writer.WriteAttributeString("type", type.Name);
      }
      var str = ObjectToStringConverter.ConvertToString(Value);
      writer.WriteValue(str);
    }
  }

}
