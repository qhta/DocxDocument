using System.Security.AccessControl;

using Qhta.Conversion;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="DocumentProperty"/> class.
/// </summary>
public partial class DocumentProperties : IXmlSerializable
{
  static DocumentProperties()
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
    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }

    reader.Read();
    while (reader.NodeType != XmlNodeType.EndElement)
    {
      if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "DocumentProperty")
      {
        DocumentProperty property;
        if (reader.GetAttribute("propertyId") == null)
          property = new BuiltInProperty();
        else
          property = new CustomProperty();

        ((IXmlSerializable)property).ReadXml(reader);
        Add(property);
      }
      else
      {
        reader.Read();
      }
    }

    reader.Read();
  }

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    foreach (var property in this)
    {
      writer.WriteStartElement("DocumentProperty");
      if (property.PropertyId != null)
        writer.WriteAttributeString("propertyId", property.PropertyId.ToString());
      writer.WriteAttributeString("name", property.Name);
      if (property.LinkTarget != null)
        writer.WriteAttributeString("linkTarget", property.LinkTarget);

      var type = property.Value?.GetType() ?? property.Type;
      if (type != null)
      {
        TypeToStringConverter.RegisterType(type);
        writer.WriteAttributeString("type", type.Name);
      }

      if (property.Value is not null)
      {
        var str = ObjectToStringConverter.ConvertToString(property.Value);
        writer.WriteValue(str);
      }
      writer.WriteEndElement();
    }
  }

}
