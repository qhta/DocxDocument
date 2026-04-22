namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RunFonts
{
  public bool ShouldSerializeHint() => Hint is not null;
  public bool ShouldSerializeAscii() => !String.IsNullOrEmpty(Ascii);
  public bool ShouldSerializeHighAnsi() => !String.IsNullOrEmpty(HighAnsi);
  public bool ShouldSerializeEastAsia() => !String.IsNullOrEmpty(EastAsia);
  public bool ShouldSerializeComplexScript() => !String.IsNullOrEmpty(ComplexScript);
  public bool ShouldSerializeAsciiTheme() => AsciiTheme is not null;
  public bool ShouldSerializeHighAnsiTheme() => HighAnsiTheme is not null;
  public bool ShouldSerializeEastAsiaTheme() => EastAsiaTheme is not null;
  public bool ShouldSerializeComplexScriptTheme() => ComplexScriptTheme is not null;
}
