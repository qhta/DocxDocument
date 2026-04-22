namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Paragraph
{
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null;
  public bool ShouldSerializeRun() => Run is not null;
  public bool ShouldSerializeBreak() => Break is not null;
  public bool ShouldSerializeField() => Field is not null;
  public bool ShouldSerializeTextMath() => TextMath is not null;
  public bool ShouldSerializeEndParagraphRunProperties() => EndParagraphRunProperties is not null;
}
