namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides XML serialization support for the <see cref = "SchemeColor"/> structure.
/// </summary>
public partial class SchemeColor : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the <see cref = "Color"/> value from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    var readerDepth = reader.Depth;

    var indexStr = reader.GetAttribute("index");
    if (!string.IsNullOrEmpty(indexStr))
    {
      if (Enum.TryParse(indexStr, out DMD.SchemeColors index))
      {
        Index = index;
      }
    }

    var tintStr = reader.GetAttribute("tint");
    if (!string.IsNullOrEmpty(tintStr))
    {
      Tint = tintStr;
    }

    var shadeStr = reader.GetAttribute("shade");
    if (!string.IsNullOrEmpty(shadeStr))
    {
      Shade = shadeStr;

    }
    if (reader.IsEmptyElement)
    {
      reader.Read(); // Move past empty element
      return;
    }
    if (reader.NodeType == XmlNodeType.EndElement && reader.Depth == readerDepth)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref = "Color"/> value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a string representing <see cref = "Color"/> .
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("index", Index.ToString());
    if (Tint is not null)
      writer.WriteAttributeString("tint", Tint.ToString());
    if (Shade is not null)
      writer.WriteAttributeString("shade", Shade.ToString());
  }
}
