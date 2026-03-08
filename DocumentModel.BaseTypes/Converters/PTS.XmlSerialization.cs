namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="PTS"/> structure.
/// </summary>
public partial class PTS : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="PTS"/> value from XML.
  /// Accepts numeric values and values with unit suffixes (mm, cm, pt, in).
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>Plain numeric values (e.g., "72" representing points directly)</description></item>
  /// <item><description>Values with millimeter suffix (e.g., "25.4mm")</description></item>
  /// <item><description>Values with centimeter suffix (e.g., "2.54cm")</description></item>
  /// <item><description>Values with point suffix (e.g., "12pt")</description></item>
  /// <item><description>Values with inch suffix (e.g., "1in")</description></item>
  /// <item><description>Empty elements</description></item>
  /// </list>
  /// Commas in the input are automatically replaced with periods for decimal separator consistency.
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
      string pointsString = reader.Value;

      if (!string.IsNullOrEmpty(pointsString))
      {
        PTS parsedValue = new PTS(pointsString);

        System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = parsedValue._value;
        System.Runtime.CompilerServices.Unsafe.AsRef(in _unit) = parsedValue.Unit;
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref="PTS"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a plain numeric string representing points without unit suffix.
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}