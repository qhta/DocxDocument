namespace DocumentModel.Vml;
/// <summary>
/// Provides XML serialization support for the <see cref = "TextBox"/> class.
/// </summary>
public partial class TextBox : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the <see cref = "TexBox"/> value from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  public override void ReadXml(XmlReader reader)
  {
    reader.MoveToContent();

    var serializableProperties = GetSerializableProperties();

    // Read attributes
    ReadAttributes(reader, serializableProperties);

    var isEmptyElement = reader.IsEmptyElement;
    reader.ReadStartElement();
    if (isEmptyElement)
      return;

    var innerXml = reader.NodeType == XmlNodeType.Text ? reader.ReadContentAsString() :
      reader.ReadInnerXml();
    if (string.IsNullOrWhiteSpace(innerXml))
      TextBoxContent = null;
    else
      TextBoxContent = TextBoxContent.Parse(innerXml);

    if (reader.NodeType == XmlNodeType.EndElement)
      reader.ReadEndElement();
  }

  /// <summary>
  /// Serializes the <see cref = "TextBox"/> value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a string representing <see cref = "TextBox"/> .
  /// </remarks>
  public override void WriteXml(XmlWriter writer)
  {
    base.WriteXml(writer);
    if (TextBoxContent is not null)
      writer.WriteRaw(TextBoxContent.ToString() ?? string.Empty);
  }
}
