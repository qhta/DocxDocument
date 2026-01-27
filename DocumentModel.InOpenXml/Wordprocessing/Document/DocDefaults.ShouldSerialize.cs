namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocDefaults
{
  public bool ShouldSerializeRunPropertiesDefault() => RunPropertiesDefault is not null;
  public bool ShouldSerializeParagraphPropertiesDefault() => ParagraphPropertiesDefault is not null;
}
