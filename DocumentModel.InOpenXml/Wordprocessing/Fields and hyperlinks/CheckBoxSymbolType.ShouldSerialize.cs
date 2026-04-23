namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CheckBoxSymbolType
{
  public bool ShouldSerializeFont() => !String.IsNullOrEmpty(Font);
  public bool ShouldSerializeVal() => Val is not null && ShouldSerialize(Val);
}
