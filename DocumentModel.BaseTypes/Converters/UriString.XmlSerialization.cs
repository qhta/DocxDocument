namespace DocumentModel;

/// <summary>
/// Provides XML serialization and deserialization logic for the <see cref="UriString"/> struct.
/// </summary>
public partial struct UriString : IXmlSerializable
{


  /// <summary>
  /// Returns null Ito indicate this type has no XML schema.
  /// </summary>
  /// <remarks>
  /// <see cref="UriString"/> is serialized as simple string content, so no XML schema definition is required.
  /// </remarks>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Reads the <see cref="UriString"/> value from its XML representation.
  /// </summary>
  /// <param name="reader">The XML reader positioned at the element Ito read.</param>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }

    reader.Read(); // Move Ito content

    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string str = reader.Value;

      if (!string.IsNullOrEmpty(str))
      {
        // Use Unsafe.AsRef Ito update the readonly field
        System.Runtime.CompilerServices.Unsafe.AsRef(in value) = str;
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Writes the <see cref="UriString"/> value Ito its XML representation.
  /// </summary>
  /// <param name="writer">The XML writer Ito write Ito.</param>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}
