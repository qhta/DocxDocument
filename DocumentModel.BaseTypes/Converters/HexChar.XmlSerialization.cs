namespace DocumentModel;

public partial record HexChar : IXmlSerializable
{


  /// <summary>
  ///   Returns null to indicate this type has no XML schema.
  /// </summary>
  /// <remarks>
  ///   HexChar is serialized as simple string content, so no XML schema definition is required.
  /// </remarks>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  ///   Reads the HexChar value from XML as hexadecimal string content.
  /// </summary>
  /// <param name="reader">The XML reader to read from.</param>
  /// <remarks>
  ///   <para>
  ///   This method reads the hexadecimal string content from the XML element and parses it
  ///   into the internal ushort value. Empty elements result in a zero value.
  ///   </para>
  ///   <para>
  ///   Since HexChar is a struct with a readonly field, this method uses unsafe code to update
  ///   the field during XML deserialization. This is necessary for XmlSerializer compatibility
  ///   while maintaining immutability for normal usage.
  ///   </para>
  ///   <para>
  ///   The method properly handles three scenarios:
  ///   <list type="number">
  ///   <item><description><b>Empty elements:</b> &lt;Char /&gt; → Value remains 0 (default)</description></item>
  ///   <item><description><b>Text content:</b> &lt;Char&gt;41&lt;/Char&gt; → Parses and sets hex value</description></item>
  ///   <item><description><b>No content:</b> &lt;Char&gt;&lt;/Char&gt; → Value remains 0 (default)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   <b>Valid input examples:</b>
  ///   <list type="bullet">
  ///   <item><description>"41" → HexChar(65) for 'A'</description></item>
  ///   <item><description>"20" → HexChar(32) for space</description></item>
  ///   <item><description>"03B1" → HexChar(945) for Greek alpha α</description></item>
  ///   <item><description>"FFFF" → HexChar(65535) for maximum value</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds 65535 (ushort.MaxValue).
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
        // Parse the hex string to ushort
        ushort parsedValue = ushort.Parse(str, NumberStyles.HexNumber);

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
  ///   Writes the HexChar value to XML as hexadecimal string content.
  /// </summary>
  /// <param name="writer">The XML writer to write to.</param>
  /// <remarks>
  ///   <para>
  ///   This method writes the hexadecimal string representation of the character code as
  ///   text content within the XML element. The output uses uppercase hexadecimal digits
  ///   (0-9, A-F) for consistency with Office Open XML standards.
  ///   </para>
  ///   <para>
  ///   The format is automatically selected based on the value range:
  ///   <list type="bullet">
  ///   <item><description><b>Values 0-255:</b> 2-digit format (e.g., "41", "FF")</description></item>
  ///   <item><description><b>Values 256-65535:</b> 4-digit format (e.g., "0100", "FFFF")</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Zero values are written as "00", not as empty elements, to maintain consistency
  ///   with Office Open XML character code representations.
  ///   </para>
  ///   <para>
  ///   <b>Output Examples:</b>
  ///   <list type="bullet">
  ///   <item><description>HexChar(0) → &lt;Char&gt;00&lt;/Char&gt;</description></item>
  ///   <item><description>HexChar(65) → &lt;Char&gt;41&lt;/Char&gt;</description></item>
  ///   <item><description>HexChar(255) → &lt;Char&gt;FF&lt;/Char&gt;</description></item>
  ///   <item><description>HexChar(256) → &lt;Char&gt;0100&lt;/Char&gt;</description></item>
  ///   <item><description>HexChar(945) → &lt;Char&gt;03B1&lt;/Char&gt;</description></item>
  ///   <item><description>HexChar(65535) → &lt;Char&gt;FFFF&lt;/Char&gt;</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}