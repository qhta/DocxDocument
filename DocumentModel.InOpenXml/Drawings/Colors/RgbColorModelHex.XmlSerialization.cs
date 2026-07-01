namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "RgbColorModelHex"/> structure.
/// </summary>
public partial class RgbColorModelHex : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the instance value from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  public override void ReadXml(XmlReader reader)
  {
    string? valueStr = reader.GetAttribute("value");
    if (!string.IsNullOrEmpty(valueStr))
    {
      Value = new HexColor(valueStr);
    }
    base.ReadXml(reader);
  }

  /// <summary>
  /// Serializes the instance value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("value", Value.ToString());
    base.WriteXml(writer);
  }
}
