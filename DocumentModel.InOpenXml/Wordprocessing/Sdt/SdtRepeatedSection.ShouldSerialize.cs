namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtRepeatedSection
{
  public bool ShouldSerializeSectionTitle() => SectionTitle is not null;
  public bool ShouldSerializeDoNotAllowInsertDeleteSection() => DoNotAllowInsertDeleteSection is not null;
}
