namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "SystemColor"/> structure.
/// </summary>
public partial class SystemColor : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the instance from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    string? indexStr = reader.GetAttribute("index");
    if (!string.IsNullOrEmpty(indexStr))
    {
      if (Enum.TryParse(indexStr, out SystemColors index))
      {
        Index = index;
      }
    }
    string? lastColor = reader.GetAttribute("lastColor");
    if (!string.IsNullOrEmpty(lastColor))
    {
      LastColor = lastColor;
    }
    base.ReadXml(reader);
  }

  /// <summary>
  /// Serializes the instance to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("index", Index.ToString());
    writer.WriteAttributeString("lastColor", LastColor.ToString());
    base.WriteXml(writer);
  }
}
