namespace DocumentModel.Drawings;

public partial struct Degrees : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="Degrees"/> value from XML.
  /// Accepts both plain numeric values and values with a trailing Degrees sign (°).
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>Plain numeric values (e.g., "60.0")</description></item>
  /// <item><description>Values with Degrees sign (e.g., "60°")</description></item>
  /// <item><description>Empty elements</description></item>
  /// </list>
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
      string str = reader.Value;

      if (!string.IsNullOrEmpty(str))
      {
          str = str.TrimEnd('°');
        // Parse the Degrees string to double
        var doubleValue = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
        var longValue =(long)(doubleValue * 60000);
        // Use Unsafe.AsRef to update the readonly field
        System.Runtime.CompilerServices.Unsafe.AsRef(in value) = longValue;
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref="Degrees"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written using the default string representation of the <see cref="Degrees"/> structure.
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}
