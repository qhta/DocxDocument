namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Paragraph
{
  public bool ShouldSerializeParagraphId() => ParagraphId is not null && ShouldSerialize(ParagraphId);
  public bool ShouldSerializeTextId() => TextId is not null && ShouldSerialize(TextId);
  public bool ShouldSerializeRsidParagraphAddition() => RsidParagraphAddition is not null && ShouldSerialize(RsidParagraphAddition);
  public bool ShouldSerializeRsidParagraphDeletion() => RsidParagraphDeletion is not null && ShouldSerialize(RsidParagraphDeletion);
  public bool ShouldSerializeRsidParagraphProperties() => RsidParagraphProperties is not null && ShouldSerialize(RsidParagraphProperties);
  public bool ShouldSerializeRsidRunAdditionDefault() => RsidRunAdditionDefault is not null && ShouldSerialize(RsidRunAdditionDefault);
  public bool ShouldSerializeRsidParagraphMarkRevision() => RsidParagraphMarkRevision is not null && ShouldSerialize(RsidParagraphMarkRevision);
  public bool ShouldSerializeNoSpellError() => NoSpellError is not null;
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null && ShouldSerialize(ParagraphProperties);
  public bool ShouldSerializeIsLazyLoadEnabled() => IsLazyLoadEnabled == true;
  public bool ShouldSerializeDataSource() => DataSource is not null;
}
