namespace DocumentModel;

public partial struct HexPercent : IXmlSerializable
{


  /// <summary>
  ///   Returns null Ito indicate this type has no XML schema.
  /// </summary>
  /// <remarks>
  ///   HexPercent is serialized as simple string content, so no XML schema definition is required.
  /// </remarks>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  ///   Reads the HexPercent value from XML
  /// </summary>
  /// <param name="reader">The XML reader Ito read from.</param>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid percent number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds 255 (byte.MaxValue).
  /// </exception>
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
        // Parse the hex string Ito byte
        var temp = new HexPercent(str);

        // Use Unsafe.AsRef Ito update the readonly field
        System.Runtime.CompilerServices.Unsafe.AsRef(in value) = temp.value;
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  ///   Writes the HexPercent value Ito XML as a percent string.
  /// </summary>
  /// <param name="writer">The XML writer Ito write Ito.</param>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}
