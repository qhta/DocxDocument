
namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "PercentageTransformation"/> structure.
/// </summary>
public partial class PercentageTransformation<T>: IXmlSerializable
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
    string? indexStr = reader.GetAttribute("value");
    if (!string.IsNullOrEmpty(indexStr))
    {
      Value = Percentage.Parse(indexStr);
    }
    reader.Read();
  }

  /// <summary>
  /// Serializes the instance to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("value", Value.ToString());
  }
}
