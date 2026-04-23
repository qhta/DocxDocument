namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RunFonts
{
  public bool ShouldSerializeHint() => Hint is not null && ShouldSerialize(Hint);
  public bool ShouldSerializeAscii() => !String.IsNullOrEmpty(Ascii);
  public bool ShouldSerializeHighAnsi() => !String.IsNullOrEmpty(HighAnsi);
  public bool ShouldSerializeEastAsia() => !String.IsNullOrEmpty(EastAsia);
  public bool ShouldSerializeComplexScript() => !String.IsNullOrEmpty(ComplexScript);
  public bool ShouldSerializeAsciiTheme() => AsciiTheme is not null && ShouldSerialize(AsciiTheme);
  public bool ShouldSerializeHighAnsiTheme() => HighAnsiTheme is not null && ShouldSerialize(HighAnsiTheme);
  public bool ShouldSerializeEastAsiaTheme() => EastAsiaTheme is not null && ShouldSerialize(EastAsiaTheme);
  public bool ShouldSerializeComplexScriptTheme() => ComplexScriptTheme is not null && ShouldSerialize(ComplexScriptTheme);
}
