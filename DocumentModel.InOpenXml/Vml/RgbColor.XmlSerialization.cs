namespace DocumentModel.Vml;
/// <summary>
/// Provides XML serialization support for the <see cref = "RgbColor"/> structure.
/// </summary>
public partial class RgbColor : IXmlSerializable
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

    var valueStr = reader.GetAttribute("value");
    if (!string.IsNullOrEmpty(valueStr))
    {
      RgbColor parsedValue = RgbColor.Parse(valueStr);

      // Use Unsafe.AsRef to update the readonly field
      System.Runtime.CompilerServices.Unsafe.AsRef(in Value) = parsedValue.Value;
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
    writer.WriteAttributeString("value", Value.ToString());
  }
}
