namespace DocumentModel.Wordprocessing;

public partial class DocDefaults
{
  public bool ShouldSerializeRunPropertiesDefault() => RunPropertiesDefault is not null;
  public bool ShouldSerializeParagraphPropertiesDefault() => ParagraphPropertiesDefault is not null;
}
