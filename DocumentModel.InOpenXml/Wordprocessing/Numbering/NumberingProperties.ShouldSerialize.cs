namespace DocumentModel.Wordprocessing;

public partial class NumberingProperties
{
  public bool ShouldSerializeNumberingLevelReference() => NumberingLevelReference is not null;
  public bool ShouldSerializeNumberingId() => NumberingId is not null;
  public bool ShouldSerializeNumberingChange() => NumberingChange is not null;
  public bool ShouldSerializeInserted() => Inserted is not null;
}
