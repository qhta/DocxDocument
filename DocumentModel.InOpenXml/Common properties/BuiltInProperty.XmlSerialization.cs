namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="ArrayVariant"/> class.
/// </summary>
public partial class BuiltInProperty : IXmlSerializable
{
  static BuiltInProperty()
  {
    // Register known types for XML serialization
    TypeToStringConverter.RegisterType(typeof(BuiltInProperty));
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
    string? typename = reader.GetAttribute("type");
    Type? type = null;
    if (typename!= null)
    {
      type = TypeToStringConverter.ResolveType(typename);
    }

    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }
    reader.Read(); // Move to content
 
    var str = reader.Value;
    var value = ObjectToStringConverter.ConvertFromString(str, type ?? typeof(object));
    var builtInProperty = new BuiltInProperty { Name = name, Value = value, Type = type };
    System.Runtime.CompilerServices.Unsafe.AsRef(in _name) = builtInProperty.Name;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _type) = builtInProperty.Type;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = builtInProperty.Value;
    if (reader.NodeType == XmlNodeType.Text) reader.Read(); // Move past text node
    if (reader.NodeType == XmlNodeType.EndElement) reader.Read(); // Move past end element

  }

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write attributes
    writer.WriteAttributeString("name", Name);

    var type = Value?.GetType() ?? Type;
    if (type != null)
    {
      TypeToStringConverter.RegisterType(type);
      writer.WriteAttributeString("type", type.Name);
    }
    if (Value is not null)
    {
      var str = ObjectToStringConverter.ConvertToString(Value);
      writer.WriteValue(str);
    }
  }

}
