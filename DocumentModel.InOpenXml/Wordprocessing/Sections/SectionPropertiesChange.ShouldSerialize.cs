namespace DocumentModel.Wordprocessing;

public partial class SectionPropertiesChange
{
  public bool ShouldSerializePreviousSectionProperties() => PreviousSectionProperties is not null;
}
