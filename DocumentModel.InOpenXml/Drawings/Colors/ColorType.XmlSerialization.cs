using DocumentModel.XmlSerialization;

namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "Color"/> structure.
/// </summary>
public partial class ColorType : IXmlSerializable
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
  public new void ReadXml(XmlReader reader)
  {
    
  }

  /// <summary>
  /// Serializes the <see cref = "Color"/> value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a string representing <see cref = "Color"/> .
  /// </remarks>
  public new void WriteXml(XmlWriter writer)
  {
    if (InternalColor == null)
    {
      Debug.WriteLine("InternalColor is null");
      return;
    }
    
    var serializer = XmlSerializationHelper.CreateXmlSerializer(InternalColor.GetType(), out var namespaces);
    serializer.Serialize(writer, InternalColor, namespaces);

  }
}
