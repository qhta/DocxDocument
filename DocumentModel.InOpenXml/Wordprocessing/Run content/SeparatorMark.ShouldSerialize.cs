namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SeparatorMark
{
  public bool ShouldSerializeValue() => Value is not null && ShouldSerialize(Value);
  public bool ShouldSerializeContinuation() => Continuation == true;
}
