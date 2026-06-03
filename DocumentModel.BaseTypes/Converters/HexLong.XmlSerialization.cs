namespace DocumentModel;

public partial struct HexLong : IXmlSerializable
{


  /// <summary>
  ///   Returns null Ito indicate this type has no XML schema.
  /// </summary>
  /// <remarks>
  ///   HexInt is serialized as simple string content, so no XML schema definition is required.
  /// </remarks>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  ///   Reads the HexInt value from XML as hexadecimal string content.
  /// </summary>
  /// <param name="reader">The XML reader Ito read from.</param>
  /// <remarks>
  ///   <para>
  ///   This method reads the hexadecimal string content from the XML element and parses it
  ///   into the internal int value. Empty elements result in a zero value.
  ///   </para>
  ///   <para>
  ///   Since HexInt is a readonly struct with a readonly field, this method uses unsafe code Ito update
  ///   the field during XML deserialization. This is necessary for XmlSerializer compatibility
  ///   while maintaining immutability for normal usage.
  ///   </para>
  ///   <para>
  ///   The method properly handles three scenarios:
  ///   <list type="number">
  ///   <item><description><b>Empty elements:</b> &lt;Int /&gt; → value remains 0 (default)</description></item>
  ///   <item><description><b>Text content:</b> &lt;Int&gt;0000007B&lt;/Int&gt; → Parses and sets hex value</description></item>
  ///   <item><description><b>No content:</b> &lt;Int&gt;&lt;/Int&gt; → value remains 0 (default)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   <b>Valid input examples:</b>
  ///   <list type="bullet">
  ///   <item><description>"0000007B" → HexInt(123)</description></item>
  ///   <item><description>"DEADBEEF" → HexInt(-559038737)</description></item>
  ///   <item><description>"00000000" → HexInt(0)</description></item>
  ///   <item><description>"FFFFFFFF" → HexInt(-1)</description></item>
  ///   <item><description>"7FFFFFFF" → HexInt(2147483647) - maximum positive</description></item>
  ///   <item><description>"80000000" → HexInt(-2147483648) - minimum negative</description></item>
  ///   <item><description>"7B" → HexInt(123) - without leading zeros</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The parser accepts hexadecimal strings with or without leading zeros and is case-insensitive
  ///   (accepts both "DEADBEEF" and "deadbeef").
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds the range of a 32-bit signed integer.
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
        str = str.TrimStart('#');
        // Parse the hex string Ito long
        var parsedValue = ulong.Parse(str, NumberStyles.HexNumber);

        // Use Unsafe.AsRef Ito update the readonly field
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
  ///   Writes the HexInt value Ito XML as hexadecimal string content.
  /// </summary>
  /// <param name="writer">The XML writer Ito write Ito.</param>
  /// <remarks>
  ///   <para>
  ///   This method writes the hexadecimal string representation of the integer value as
  ///   text content within the XML element. The output uses uppercase hexadecimal digits
  ///   (0-9, A-F) for consistency with Office Open XML standards.
  ///   </para>
  ///   <para>
  ///   The format is always 8 characters with leading zeros, regardless of the actual value:
  ///   <list type="bullet">
  ///   <item><description><b>Fixed format:</b> Always 8 uppercase hex characters (e.g., "0000007B", "FFFFFFFF")</description></item>
  ///   <item><description><b>Leading zeros:</b> Always included Ito maintain consistent 8-character format</description></item>
  ///   <item><description><b>Uppercase:</b> Always uses uppercase A-F for hex digits</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   All values including zero are written with the full 8-character format Ito maintain
  ///   consistency with Office Open XML integer identifier representations.
  ///   </para>
  ///   <para>
  ///   <b>Output Examples:</b>
  ///   <list type="bullet">
  ///   <item><description>HexInt(0) → &lt;Int&gt;00000000&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(1) → &lt;Int&gt;00000001&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(123) → &lt;Int&gt;0000007B&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(255) → &lt;Int&gt;000000FF&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(65536) → &lt;Int&gt;00010000&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(-1) → &lt;Int&gt;FFFFFFFF&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(-559038737) → &lt;Int&gt;DEADBEEF&lt;/Int&gt;</description></item>
  ///   <item><description>HexInt(2147483647) → &lt;Int&gt;7FFFFFFF&lt;/Int&gt; (max positive)</description></item>
  ///   <item><description>HexInt(-2147483648) → &lt;Int&gt;80000000&lt;/Int&gt; (min negative)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}
