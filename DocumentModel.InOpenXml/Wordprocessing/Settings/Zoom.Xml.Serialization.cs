using System;
using System.Xml.Serialization;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Provides XML serialization and deserialization logic for the <see cref="Zoom"/> class, supporting both preset zoom kinds and percentage values in WordprocessingML settings.
/// </summary>
public partial class Zoom : IXmlSerializable
{
  /// <summary>
  ///   Returns null as no custom XML schema is provided for <see cref="Zoom"/> serialization.
  /// </summary>
  /// <returns>Always returns null.</returns>
  public XmlSchema? GetSchema() => null;
  /// <summary>
  ///   Serializes the <see cref="Zoom"/> object to XML, writing either the preset kind as a string or the percentage value as a string.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write XML content to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    if (Preset != null)
      writer.WriteString(Preset.ToString());
    else if (Percent is not null)
      writer.WriteString(Percent.Value.ToString());
  }
  /// <summary>
  ///   Deserializes XML content into the <see cref="Zoom"/> object, interpreting the content as either a percentage or a preset kind.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read XML content from.</param>
  public override void ReadXml(XmlReader reader)
  {
    var content = reader.ReadElementContentAsString();
    if (content.EndsWith("%"))
    {
      Percent = new BytePercent(content);
      Preset = null;
    }
    else if (int.TryParse(content, out var percent))
    {
      Percent = percent;
      Preset = null;
    }
    else if (Enum.TryParse(typeof(PresetZoom), content, out var kind))
    {
      Preset = (PresetZoom)kind!;
      Percent = null;
    }
  }
}