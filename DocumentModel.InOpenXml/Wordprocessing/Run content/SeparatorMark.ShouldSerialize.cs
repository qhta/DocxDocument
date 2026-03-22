namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SeparatorMark
{
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeContinuation() => Continuation == true;
}
