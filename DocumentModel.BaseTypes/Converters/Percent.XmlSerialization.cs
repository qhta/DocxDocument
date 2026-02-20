namespace DocumentModel;

public partial struct Percent : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="Percent"/> value from XML.
  /// Accepts both plain numeric values and values with a trailing percent sign (%).
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>Plain numeric values (e.g., "50")</description></item>
  /// <item><description>Values with percent sign (e.g., "50%")</description></item>
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
      string percentString = reader.Value;

      if (!string.IsNullOrEmpty(percentString))
      {
        if (percentString.EndsWith("%"))
        {
          // Remove the percent sign and parse the remaining string
          percentString = percentString.TrimEnd('%');
        }

        // Parse the percent string to double
        var parsedValue = decimal.Parse(percentString.Replace(",", "."), CultureInfo.InvariantCulture);

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
  /// Serializes the <see cref="Percent"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written using the default string representation of the <see cref="Percent"/> structure.
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}