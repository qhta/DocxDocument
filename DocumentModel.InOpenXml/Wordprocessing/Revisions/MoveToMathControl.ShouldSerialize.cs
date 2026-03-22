namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class MoveToMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeInsertedMathControl() => InsertedMathControl is not null;
  public bool ShouldSerializeDeletedMathControl() => DeletedMathControl is not null;
}
