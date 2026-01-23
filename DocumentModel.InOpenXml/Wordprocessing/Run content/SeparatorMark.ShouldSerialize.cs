namespace DocumentModel.Wordprocessing;

public partial class SeparatorMark
{
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeContinuation() => Continuation == true;
}
