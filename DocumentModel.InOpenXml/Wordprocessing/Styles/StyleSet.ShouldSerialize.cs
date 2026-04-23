namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class StyleSet
{
  public bool ShouldSerializeId() => Id is not null && ShouldSerialize(Id);
  public bool ShouldSerializeVal() => Val is not null && ShouldSerialize(Val);
}
