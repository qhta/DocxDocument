namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class MoveFromMathControl
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeInsertedMathControl() => InsertedMathControl is not null;
  public bool ShouldSerializeDeletedMathControl() => DeletedMathControl is not null;
}
