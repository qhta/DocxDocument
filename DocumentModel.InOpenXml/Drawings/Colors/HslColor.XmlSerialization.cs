namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "HslColor"/> structure.
/// </summary>
public partial class HslColor : IXmlSerializable
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
  public override void ReadXml(XmlReader reader)
  {
    reader.MoveToContent();

    string? hueStr = reader.GetAttribute("h");
    if (!string.IsNullOrEmpty(hueStr))
    {
      if (Degrees.TryParse(hueStr, out var hue))
      {
        Hue = hue;
      }
    }

    string? saturationStr = reader.GetAttribute("s");
    if (!string.IsNullOrEmpty(saturationStr))
    {
      if (Percentage.TryParse(saturationStr, out var saturation))
      {
        Saturation = saturation;
      }
    }

    string? luminanceStr = reader.GetAttribute("l");
    if (!string.IsNullOrEmpty(luminanceStr))
    {
      if (Percentage.TryParse(luminanceStr, out var luminance))
      {
        Luminance = luminance;
      }
    }

    base.ReadXml(reader);
  }

  /// <summary>
  /// Serializes the instance to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("h", Hue.ToString());
    writer.WriteAttributeString("s", Saturation.ToString());
    writer.WriteAttributeString("l", Luminance.ToString());
    base.WriteXml(writer);
  }
}
