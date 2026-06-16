using System.Security.AccessControl;

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
    string? name = reader.GetAttribute("name");
    string? propertyIdStr = reader.GetAttribute("propertyId");
    string? linkTarget = reader.GetAttribute("linkTarget");

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
    if (!string.IsNullOrEmpty(propertyIdStr))
    {
      var documentProperty = new DocumentProperty
      {
        PropertyId = int.Parse(propertyIdStr),
        Name = name, 
        Value = value, 
        Type = type, 
        LinkTarget = linkTarget
      };
      System.Runtime.CompilerServices.Unsafe.AsRef(in _propertyId) = documentProperty.PropertyId;
      System.Runtime.CompilerServices.Unsafe.AsRef(in _name) = documentProperty.Name;
      System.Runtime.CompilerServices.Unsafe.AsRef(in _type) = documentProperty.Type;
      System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = documentProperty.Value;
      System.Runtime.CompilerServices.Unsafe.AsRef(in _linkTarget) = documentProperty.LinkTarget;
    }
    else
    {
      var documentProperty = new DocumentProperty
      {
        Name = name,
        Value = value,
        Type = type,
      };
      System.Runtime.CompilerServices.Unsafe.AsRef(in _name) = documentProperty.Name;
      System.Runtime.CompilerServices.Unsafe.AsRef(in _type) = documentProperty.Type;
      System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = documentProperty.Value;

    }
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
