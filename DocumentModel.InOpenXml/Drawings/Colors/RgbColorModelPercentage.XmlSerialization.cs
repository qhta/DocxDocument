namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "RgbColorModelPercentage"/> structure.
/// </summary>
public partial class RgbColorModelPercentage : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the instance value from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  public override void ReadXml(XmlReader reader)
  {
    string? rStr = reader.GetAttribute("r");
    if (!string.IsNullOrEmpty(rStr))
    {
      Red = Percentage.Parse(rStr);
    }
    string? gStr = reader.GetAttribute("g");
    if (!string.IsNullOrEmpty(gStr))
    {
      Green = Percentage.Parse(gStr);
    }
    string? bStr = reader.GetAttribute("b");
    if (!string.IsNullOrEmpty(bStr))
    {
      Blue = Percentage.Parse(bStr);
    }
    string? aStr = reader.GetAttribute("a");
    if (!string.IsNullOrEmpty(aStr))
    {
      Alpha = Percentage.Parse(aStr);
    }
    base.ReadXml(reader);
  }

  /// <summary>
  /// Serializes the instance value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("r", Red.ToString());
    writer.WriteAttributeString("g", Green.ToString());
    writer.WriteAttributeString("b", Blue.ToString());
    if (Alpha.ToString() != "100%")
      writer.WriteAttributeString("a", Alpha.ToString());

    base.WriteXml(writer);
  }
}
