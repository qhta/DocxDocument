namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DocDefaults
{
  public bool ShouldSerializeRunPropertiesDefault() => DefaultRunProperties is not null;
  public bool ShouldSerializeParagraphPropertiesDefault() => DefaultParagraphProperties is not null;
}
