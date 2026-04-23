namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class MoveToMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null && ShouldSerialize(RunProperties);
  public bool ShouldSerializeInsertedMathControl() => InsertedMathControl is not null && ShouldSerialize(InsertedMathControl);
  public bool ShouldSerializeDeletedMathControl() => DeletedMathControl is not null && ShouldSerialize(DeletedMathControl);
}
