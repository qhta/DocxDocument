namespace DocumentModel.Wordprocessing;

public partial class ParagraphMarkRunProperties
{
  public bool ShouldSerializeParagraphMarkRunPropertiesChange() => ParagraphMarkRunPropertiesChange is not null;
}
