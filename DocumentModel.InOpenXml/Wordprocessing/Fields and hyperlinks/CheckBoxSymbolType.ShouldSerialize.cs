namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CheckBoxSymbolType
{
  public bool ShouldSerializeFont() => Font is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
