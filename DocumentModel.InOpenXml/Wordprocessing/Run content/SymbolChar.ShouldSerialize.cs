namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SymbolChar
{
  public bool ShouldSerializeFont() => !String.IsNullOrEmpty(Font);
  public bool ShouldSerializeChar() => Char is not null;
}
