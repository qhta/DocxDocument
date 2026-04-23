namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphMarkRunProperties
{
  public bool ShouldSerializeParagraphMarkRunPropertiesChange() => ParagraphMarkRunPropertiesChange is not null && ShouldSerialize(ParagraphMarkRunPropertiesChange);
}
