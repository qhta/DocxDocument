namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class TextProperties
{
  public bool ShouldSerializeBodyProperties() => BodyProperties is not null;
  public bool ShouldSerializeListStyle() => ListStyle is not null;
  public bool ShouldSerializeParagraph() => Paragraph is not null;
}
