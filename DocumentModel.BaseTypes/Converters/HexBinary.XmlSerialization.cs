namespace DocumentModel;

public partial class HexBinary : IXmlSerializable
{


  /// <summary>
  ///   Returns null to indicate this type has no XML schema.
  /// </summary>
  /// <remarks>
  ///   HexBinary is serialized as simple string content, so no XML schema definition is required.
  /// </remarks>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  ///   Reads the HexBinary value from XML as hexadecimal string content.
  /// </summary>
  /// <param name="reader">The XML reader to read from.</param>
  /// <remarks>
  ///   <para>
  ///   This method reads the hexadecimal string content from the XML element and replaces
  ///   the internal byte array with the parsed value. Empty elements result in an empty byte array.
  ///   </para>
  ///   <para>
  ///   <b>Implementation Note:</b> Since HexBinary uses a readonly field for immutability,
  ///   this method uses reflection to update the field during XML deserialization. This is
  ///   necessary for XmlSerializer compatibility while maintaining immutability for normal usage.
  ///   </para>
  ///   <para>
  ///   The method properly handles three scenarios:
  ///   <list type="number">
  ///   <item><description><b>Empty elements:</b> &lt;Data /&gt; → Leaves value unchanged (empty from constructor)</description></item>
  ///   <item><description><b>Text content:</b> &lt;Data&gt;ABCD&lt;/Data&gt; → Parses and sets hex value</description></item>
  ///   <item><description><b>No content:</b> &lt;Data&gt;&lt;/Data&gt; → Leaves value unchanged (empty from constructor)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
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
      string hexString = reader.Value;

      // Parse the hex string and update the readonly field using reflection
      if (!string.IsNullOrEmpty(hexString))
      {
        // Use reflection to set the readonly field during deserialization
        var valueField = typeof(HexBinary).GetField("value",
          System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        valueField?.SetValue(this, hexString);
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  ///   Writes the HexBinary value to XML as hexadecimal string content.
  /// </summary>
  /// <param name="writer">The XML writer to write to.</param>
  /// <remarks>
  ///   <para>
  ///   This method writes the hexadecimal string representation of the byte array as
  ///   text content within the XML element. The output uses uppercase hexadecimal digits
  ///   (0-9, A-F) for consistency with Office Open XML standards.
  ///   </para>
  ///   <para>
  ///   Empty byte arrays result in empty XML elements (&lt;Data /&gt;), which is the
  ///   standard XML representation for absent or empty binary data.
  ///   </para>
  ///   <para>
  ///   <b>Output Examples:</b>
  ///   <list type="bullet">
  ///   <item><description>4 bytes → &lt;Data&gt;DEADBEEF&lt;/Data&gt;</description></item>
  ///   <item><description>Empty → &lt;Data /&gt;</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    if (value.Length > 0)
    {
      writer.WriteString(ToString());
    }
  }
}
