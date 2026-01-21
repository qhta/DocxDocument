namespace DocumentModel.Wordprocessing;

public partial class CheckBoxSymbolType
{
  public bool ShouldSerializeFont() => Font is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
