namespace DocumentModel.Wordprocessing;
/// <summary>
/// Provides XML serialization support for the <see cref = "Color"/> structure.
/// </summary>
public partial class Color : IXmlSerializable
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
  if (reader.IsEmptyElement)
  {
   reader.Read();
   return;
  }

  reader.Read(); // Move to content
  if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
  {
   string ColorString = reader.Value;
   if (!string.IsNullOrEmpty(ColorString))
   {
    var parsedValue = new DMW.Color(ColorString);
    Val = parsedValue.Val;
    ThemeColor = parsedValue.ThemeColor;
    ThemeTint = parsedValue.ThemeTint;
    ThemeShade = parsedValue.ThemeShade;
   }

   reader.Read(); // Move past text
  }

  if (reader.NodeType == XmlNodeType.EndElement)
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
  writer.WriteString(ToString());
 }
}
