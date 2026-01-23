namespace DocumentModel.Math;

public partial class Paragraph
{
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null;
}
