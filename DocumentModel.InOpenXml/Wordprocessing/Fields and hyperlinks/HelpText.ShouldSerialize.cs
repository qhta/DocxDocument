namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class HelpText
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
}
