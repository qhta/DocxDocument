namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides XML serialization support for the <see cref = "PixelsMeasure"/> structure.
/// </summary>
public partial class PixelsMeasure : IXmlSerializable
{
 /// <summary>
 /// This method is reserved and should not be used. Returns null as no schema is required.
 /// </summary>
 /// <returns>Always returns null.</returns>
 XmlSchema? IXmlSerializable.GetSchema() => null;
 /// <summary>
 /// Deserializes the <see cref = "PixelsMeasure"/> value from XML.
 /// Accepts numeric values and values with unit suffixes (mm, cm, pt, in).
 /// </summary>
 /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
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
   string PixelsMeasureString = reader.Value;
   if (!string.IsNullOrEmpty(PixelsMeasureString))
   {
    var parsedValue = new DMW.PixelsMeasure(PixelsMeasureString);
    System.Runtime.CompilerServices.Unsafe.AsRef(in Value) = parsedValue.Value;
   }

   reader.Read(); // Move past text
  }

  if (reader.NodeType == XmlNodeType.EndElement)
  {
   reader.Read(); // Move past end element
  }
 }

 /// <summary>
 /// Serializes the <see cref = "PixelsMeasure"/> value to XML.
 /// </summary>
 /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
 /// <remarks>
 /// The value is written as a string representing <see cref = "PixelsMeasure"/> .
 /// </remarks>
 void IXmlSerializable.WriteXml(XmlWriter writer)
 {
  writer.WriteString(ToString());
 }
}
