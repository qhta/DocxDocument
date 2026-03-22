namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SymbolChar
{
  public bool ShouldSerializeFont() => Font is not null;
  public bool ShouldSerializeChar() => Char is not null;
}
