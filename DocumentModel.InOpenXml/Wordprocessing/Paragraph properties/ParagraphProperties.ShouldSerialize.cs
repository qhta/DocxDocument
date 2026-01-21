namespace DocumentModel.Wordprocessing;

public partial class ParagraphProperties
{
  public bool ShouldSerializeParagraphMarkRunProperties() => ParagraphMarkRunProperties is not null;
  public bool ShouldSerializeSectionProperties() => SectionProperties is not null;
  public bool ShouldSerializeParagraphPropertiesChange() => ParagraphPropertiesChange is not null;
}
