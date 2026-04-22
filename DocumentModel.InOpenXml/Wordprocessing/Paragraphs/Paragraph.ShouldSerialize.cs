namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Paragraph
{
  public bool ShouldSerializeParagraphId() => ParagraphId is not null;
  public bool ShouldSerializeTextId() => TextId is not null;
  public bool ShouldSerializeRsidParagraphMarkRevision() => RsidParagraphMarkRevision is not null;
  public bool ShouldSerializeRsidParagraphAddition() => RsidParagraphAddition is not null;
  public bool ShouldSerializeRsidParagraphDeletion() => RsidParagraphDeletion is not null;
  public bool ShouldSerializeRsidParagraphProperties() => RsidParagraphProperties is not null;
  public bool ShouldSerializeRsidRunAdditionDefault() => RsidRunAdditionDefault is not null;
  public bool ShouldSerializeNoSpellError() => NoSpellError is not null;
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null;
}
