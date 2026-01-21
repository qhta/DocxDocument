namespace DocumentModel.Wordprocessing;

public partial class RunFonts
{
  public bool ShouldSerializeHint() => Hint is not null;
  public bool ShouldSerializeAscii() => Ascii is not null;
  public bool ShouldSerializeAnsi() => Ansi is not null;
  public bool ShouldSerializeEastAsia() => EastAsia is not null;
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeAsciiTheme() => AsciiTheme is not null;
  public bool ShouldSerializeHighAnsiTheme() => HighAnsiTheme is not null;
  public bool ShouldSerializeEastAsiaTheme() => EastAsiaTheme is not null;
  public bool ShouldSerializeComplexScriptTheme() => ComplexScriptTheme is not null;
}
