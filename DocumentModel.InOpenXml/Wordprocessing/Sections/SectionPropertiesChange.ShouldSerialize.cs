namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SectionPropertiesChange
{
  public bool ShouldSerializePreviousSectionProperties() => PreviousSectionProperties is not null;
}
