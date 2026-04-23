namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocDefaults
{
  public bool ShouldSerializeDefaultRunProperties() => DefaultRunProperties is not null && ShouldSerialize(DefaultRunProperties);
  public bool ShouldSerializeDefaultParagraphProperties() => DefaultParagraphProperties is not null && ShouldSerialize(DefaultParagraphProperties);
}
