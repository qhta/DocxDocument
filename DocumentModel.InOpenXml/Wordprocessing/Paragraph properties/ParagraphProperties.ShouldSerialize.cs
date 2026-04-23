namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphProperties
{
  public bool ShouldSerializeParagraphStyleId() => !String.IsNullOrEmpty(ParagraphStyleId);
  public bool ShouldSerializeDivId() => !String.IsNullOrEmpty(DivId);
  public bool ShouldSerializeConditionalFormatStyle() => ConditionalFormatStyle is not null && ShouldSerialize(ConditionalFormatStyle);
  public bool ShouldSerializeParagraphMarkRunProperties() => ParagraphMarkRunProperties is not null && ShouldSerialize(ParagraphMarkRunProperties);
  public bool ShouldSerializeSectionProperties() => SectionProperties is not null && ShouldSerialize(SectionProperties);
  public bool ShouldSerializeParagraphPropertiesChange() => ParagraphPropertiesChange is not null && ShouldSerialize(ParagraphPropertiesChange);
}
