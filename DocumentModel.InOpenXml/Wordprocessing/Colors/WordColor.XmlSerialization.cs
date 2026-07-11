namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides XML serialization support for the <see cref = "WordColor"/> structure.
/// </summary>
public partial class WordColor : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the <see cref = "WordColor"/> value from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    var readerDepth = reader.Depth;

    var valueStr = reader.GetAttribute("value");
    if (!string.IsNullOrEmpty(valueStr))
    {
      Value = valueStr;
    }
    var themeColorStr = reader.GetAttribute("themeColor");
    if (!string.IsNullOrEmpty(themeColorStr))
    {
      if (Enum.TryParse<DMD.SchemeColors>(themeColorStr, out var themeColor))
        ThemeColor = themeColor;
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
  /// Serializes the <see cref = "WordColor"/> value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a string representing <see cref = "WordColor"/> .
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("value", Value.ToString());
    if (ThemeColor != null)
      writer.WriteAttributeString("themeColor", ThemeColor.ToString());
    if (Tint is not null)
      writer.WriteAttributeString("tint", Tint.ToString());
    if (Shade is not null)
      writer.WriteAttributeString("shade", Shade.ToString());
  }
}
