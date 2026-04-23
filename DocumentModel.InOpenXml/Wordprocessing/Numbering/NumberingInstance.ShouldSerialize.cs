namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingInstance
{
  public bool ShouldSerializeNumberID() => NumberID is not null && ShouldSerialize(NumberID);
  public bool ShouldSerializeDurableId() => DurableId is not null && ShouldSerialize(DurableId);
  public bool ShouldSerializeAbstractNumId() => AbstractNumId is not null && ShouldSerialize(AbstractNumId);
}
