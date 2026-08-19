namespace DocumentModel;

public readonly partial struct HexByte : IXmlSerializable
{

  /// <summary>
  ///   Returns null to indicate this type has no XML schema.
  /// </summary>
  /// <remarks>
  ///   HexByte is serialized as simple string content, so no XML schema definition is required.
  /// </remarks>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  ///   Reads the HexByte value from XML as hexadecimal string content.
  /// </summary>
  /// <param name="reader">The XML reader to read from.</param>
  /// <remarks>
  ///   <para>
  ///   This method reads the hexadecimal string content from the XML element and parses it
  ///   into the internal ushort value. Empty elements result in a zero value.
  ///   </para>
  ///   <para>
  ///   Since HexByte is a struct with a readonly field, this method uses unsafe code to update
  ///   the field during XML deserialization. This is necessary for XmlSerializer compatibility
  ///   while maintaining immutability for normal usage.
  ///   </para>
  ///   <para>
  ///   The method properly handles three scenarios:
  ///   <list type="number">
  ///   <item><description><b>Empty elements:</b> &lt;Byte /&gt; → Value remains 0 (default)</description></item>
  ///   <item><description><b>Text content:</b> &lt;Byte&gt;41&lt;/Byte&gt; → Parses and sets hex value</description></item>
  ///   <item><description><b>No content:</b> &lt;Byte&gt;&lt;/Byte&gt; → Value remains 0 (default)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
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

    reader.Read(); // Move to content

    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string str = reader.Value;

      if (!string.IsNullOrEmpty(str))
      {
        str = str.TrimStart('#');
        // Parse the hex string to byte
        byte parsedValue = byte.Parse(str, NumberStyles.HexNumber);

        // Use Unsafe.AsRef to update the readonly field
        System.Runtime.CompilerServices.Unsafe.AsRef(in value) = parsedValue;
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  ///   Writes the HexByte value to XML as hexadecimal string content.
  /// </summary>
  /// <param name="writer">The XML writer to write to.</param>
  /// <remarks>
  ///   <para>
  ///   This method writes the hexadecimal string representation of the character code as
  ///   text content within the XML element. The output uses uppercase hexadecimal digits
  ///   (0-9, A-F) for consistency with Office Open XML standards.
  ///   </para>
  ///   <para>
  ///   Zero values are written as "00", not as empty elements, to maintain consistency
  ///   with Office Open XML character code representations.
  ///   </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}
