using System.Globalization;
using System.Xml.Serialization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly
namespace DocumentModel.Wordprocessing;
public partial class Languages : IXmlSerializable
{
 private const string WordprocessingNamespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
 XmlSchema? IXmlSerializable.GetSchema() => null;
 void IXmlSerializable.ReadXml(XmlReader reader)
 {
  if (reader.IsEmptyElement)
  {
   reader.Read();
   return;
  }

  var valAttribute = reader.GetAttribute("val") ?? reader.GetAttribute("val", WordprocessingNamespace);
  var bidiAttribute = reader.GetAttribute("bidi") ?? reader.GetAttribute("bidi", WordprocessingNamespace);
  var eastAsiaAttribute = reader.GetAttribute("eastAsia") ?? reader.GetAttribute("eastAsia", WordprocessingNamespace);
  reader.ReadStartElement();
  if (valAttribute == null && bidiAttribute == null && eastAsiaAttribute == null)
  {
   if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
   {
    var textValue = reader.ReadContentAsString();
    if (!string.IsNullOrWhiteSpace(textValue))
     Val = new HexColor(textValue);
   }
   else
   {
    while (reader.NodeType == XmlNodeType.Element)
    {
     var localName = reader.LocalName;
     var namespaceUri = reader.NamespaceURI;
     var elementValue = reader.ReadElementContentAsString();
     if (namespaceUri != WordprocessingNamespace)
      continue;
     switch (localName)
     {
      case "Val":
       if (!string.IsNullOrWhiteSpace(elementValue))
        Val = elementValue;
       break;
      case "Bidi":
       if (!string.IsNullOrWhiteSpace(elementValue))
        Bidi = elementValue;
       break;
      case "EastAsia":
       if (!string.IsNullOrWhiteSpace(elementValue))
        EastAsia = elementValue;
       break;
     }
    }
   }

   if (reader.NodeType == XmlNodeType.EndElement)
    reader.ReadEndElement();
   return;
  }

  if (!string.IsNullOrWhiteSpace(valAttribute))
   Val = new HexColor(valAttribute);
  if (!string.IsNullOrWhiteSpace(bidiAttribute))
   Bidi = bidiAttribute;
  if (!string.IsNullOrWhiteSpace(eastAsiaAttribute))
   EastAsia = eastAsiaAttribute;
  if (reader.NodeType == XmlNodeType.EndElement)
   reader.ReadEndElement();
 }

 void IXmlSerializable.WriteXml(XmlWriter writer)
 {
  if (!string.IsNullOrEmpty(Val) && Bidi == null && EastAsia == null)
  {
   writer.WriteString(Val);
   return;
  }

  if (!string.IsNullOrEmpty(Val))
   writer.WriteElementString("Val", WordprocessingNamespace, Val);
  if (Bidi != null)
   writer.WriteElementString("Bidi", WordprocessingNamespace, Bidi);
  if (EastAsia != null)
   writer.WriteElementString("EastAsia", WordprocessingNamespace, EastAsia);
 }
}
