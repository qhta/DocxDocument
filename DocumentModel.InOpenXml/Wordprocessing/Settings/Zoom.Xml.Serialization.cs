using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel.Wordprocessing;

public partial class Zoom : IXmlSerializable
{
  public XmlSchema? GetSchema() => null;

  public void WriteXml(XmlWriter writer)
  {
    if (Kind != null)
      writer.WriteString(Kind.ToString());
    else if (Percent != null)
      writer.WriteString(Percent.Value.ToString());
  }

  public void ReadXml(XmlReader reader)
  {
    var content = reader.ReadElementContentAsString();
    if (Enum.TryParse(typeof(PresetZoomKind), content, out var kind))
    {
      Kind = (PresetZoomKind)kind!;
      Percent = null;
    }
    else if (int.TryParse(content, out var percent))
    {
      Percent = percent;
      Kind = null;
    }
  }
}