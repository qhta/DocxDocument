namespace DocumentModel.Drawings.Office;

public partial class TextBody
{
  public bool ShouldSerializeBodyProperties() => BodyProperties is not null;
  public bool ShouldSerializeListStyle() => ListStyle is not null;
  public bool ShouldSerializeParagraph() => Paragraph is not null;
}
