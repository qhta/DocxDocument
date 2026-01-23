namespace DocumentModel.Wordprocessing;

public partial class NumberingInstance
{
  public bool ShouldSerializeNumberID() => NumberID is not null;
  public bool ShouldSerializeDurableId() => DurableId is not null;
  public bool ShouldSerializeAbstractNumId() => AbstractNumId is not null;
  public bool ShouldSerializeLevelOverrides() => LevelOverrides is not null;
}
