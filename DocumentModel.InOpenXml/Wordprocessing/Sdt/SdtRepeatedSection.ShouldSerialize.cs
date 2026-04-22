namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtRepeatedSection
{
  public bool ShouldSerializeSectionTitle() => !String.IsNullOrEmpty(SectionTitle);
  public bool ShouldSerializeDoNotAllowInsertDeleteSection() => DoNotAllowInsertDeleteSection is not null;
}
