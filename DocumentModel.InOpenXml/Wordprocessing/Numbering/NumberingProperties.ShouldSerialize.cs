namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingProperties
{
  public bool ShouldSerializeNumberingLevelReference() => NumberingLevelReference is not null && ShouldSerialize(NumberingLevelReference);
  public bool ShouldSerializeNumberingId() => NumberingId is not null && ShouldSerialize(NumberingId);
  public bool ShouldSerializeNumberingChange() => NumberingChange is not null && ShouldSerialize(NumberingChange);
  public bool ShouldSerializeInserted() => Inserted is not null && ShouldSerialize(Inserted);
}
