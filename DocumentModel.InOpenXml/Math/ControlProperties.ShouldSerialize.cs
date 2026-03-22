namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class ControlProperties
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeInsertedMathControl() => InsertedMathControl is not null;
  public bool ShouldSerializeDeletedMathControl() => DeletedMathControl is not null;
  public bool ShouldSerializeMoveFromMathControl() => MoveFromMathControl is not null;
  public bool ShouldSerializeMoveToMathControl() => MoveToMathControl is not null;
}
