using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.Wordprocessing;

public partial class Color : IXmlSerializable
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
    var themeColorAttribute = reader.GetAttribute("themeColor") ?? reader.GetAttribute("themeColor", WordprocessingNamespace);
    var themeTintAttribute = reader.GetAttribute("themeTint") ?? reader.GetAttribute("themeTint", WordprocessingNamespace);
    var themeShadeAttribute = reader.GetAttribute("themeShade") ?? reader.GetAttribute("themeShade", WordprocessingNamespace);

    reader.ReadStartElement();

    if (valAttribute == null && themeColorAttribute == null && themeTintAttribute == null && themeShadeAttribute == null)
    {
      if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
      {
        var textValue = reader.ReadContentAsString();
        if (!string.IsNullOrWhiteSpace(textValue))
          Val = new HexRgb(textValue);
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
                Val = new HexRgb(elementValue);
              break;
            case "ThemeColor":
              if (!string.IsNullOrWhiteSpace(elementValue))
                ThemeColor = (ThemeColors?)DocumentModel.OpenXml.EnumConverter.ConvertFrom(elementValue, typeof(ThemeColors));
              break;
            case "ThemeTint":
              if (!string.IsNullOrWhiteSpace(elementValue))
                ThemeTint = byte.Parse(elementValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
              break;
            case "ThemeShade":
              if (!string.IsNullOrWhiteSpace(elementValue))
                ThemeShade = byte.Parse(elementValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
              break;
          }
        }
      }

      if (reader.NodeType == XmlNodeType.EndElement)
        reader.ReadEndElement();
      return;
    }

    if (!string.IsNullOrWhiteSpace(valAttribute))
      Val = new HexRgb(valAttribute);
    if (!string.IsNullOrWhiteSpace(themeColorAttribute))
      ThemeColor = (ThemeColors?)DocumentModel.OpenXml.EnumConverter.ConvertFrom(themeColorAttribute, typeof(ThemeColors));
    if (!string.IsNullOrWhiteSpace(themeTintAttribute))
      ThemeTint = byte.Parse(themeTintAttribute, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
    if (!string.IsNullOrWhiteSpace(themeShadeAttribute))
      ThemeShade = byte.Parse(themeShadeAttribute, NumberStyles.HexNumber, CultureInfo.InvariantCulture);

    if (reader.NodeType == XmlNodeType.EndElement)
      reader.ReadEndElement();
  }

  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    if (Val.HasValue && ThemeColor == null && ThemeTint == null && ThemeShade == null)
    {
      writer.WriteString(Val.Value.ToString());
      return;
    }

    if (Val.HasValue)
      writer.WriteElementString("Val", WordprocessingNamespace, Val.Value.ToString());
    if (ThemeColor != null)
      writer.WriteElementString("ThemeColor", WordprocessingNamespace,
        (string)DocumentModel.OpenXml.EnumConverter.ConvertTo(ThemeColor, typeof(string))!);
    if (ThemeTint != null)
      writer.WriteElementString("ThemeTint", WordprocessingNamespace, ThemeTint.Value.ToString("X2", CultureInfo.InvariantCulture));
    if (ThemeShade != null)
      writer.WriteElementString("ThemeShade", WordprocessingNamespace, ThemeShade.Value.ToString("X2", CultureInfo.InvariantCulture));
  }
}
