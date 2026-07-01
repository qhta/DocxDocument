namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "PresetColor"/> structure.
/// </summary>
public partial class PresetColor : IXmlSerializable
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
  public override void ReadXml(XmlReader reader)
  {
    reader.MoveToContent();

    string? indexStr = reader.GetAttribute("index");
    if (!string.IsNullOrEmpty(indexStr))
    {
      if (Enum.TryParse<PresetColors>(indexStr, out var index))
      {
        Index = index;
      }
    }
    base.ReadXml(reader);
  }

  /// <summary>
  /// Serializes the instance to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("index", Index.ToString());
    base.WriteXml(writer);
  }
}
