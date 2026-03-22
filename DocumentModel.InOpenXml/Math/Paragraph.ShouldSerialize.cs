namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class Paragraph
{
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null;
}
