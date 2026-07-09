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
      R = Percentage.Parse(rStr);
    }
    string? gStr = reader.GetAttribute("g");
    if (!string.IsNullOrEmpty(gStr))
    {
      G = Percentage.Parse(gStr);
    }
    string? bStr = reader.GetAttribute("b");
    if (!string.IsNullOrEmpty(bStr))
    {
      B = Percentage.Parse(bStr);
    }
    string? aStr = reader.GetAttribute("a");
    if (!string.IsNullOrEmpty(aStr))
    {
      A = Percentage.Parse(aStr);
    }
    base.ReadXml(reader);
  }

  /// <summary>
  /// Serializes the instance value to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    writer.WriteAttributeString("r", R.ToString());
    writer.WriteAttributeString("g", G.ToString());
    writer.WriteAttributeString("b", B.ToString());
    if (A!= 1.0)
      writer.WriteAttributeString("a", A.ToString());

    base.WriteXml(writer);
  }
}
