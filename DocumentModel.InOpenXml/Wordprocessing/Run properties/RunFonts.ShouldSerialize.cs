namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class RunFonts
{
  public bool ShouldSerializeHint() => Hint.HasValue;
  public bool ShouldSerializeAscii() => !String.IsNullOrEmpty(Ascii);
  public bool ShouldSerializeHighAnsi() => !String.IsNullOrEmpty(HighAnsi);
  public bool ShouldSerializeEastAsia() => !String.IsNullOrEmpty(EastAsia);
  public bool ShouldSerializeComplexScript() => !String.IsNullOrEmpty(ComplexScript);
  public bool ShouldSerializeAsciiTheme() => AsciiTheme.HasValue;
  public bool ShouldSerializeHighAnsiTheme() => HighAnsiTheme.HasValue;
  public bool ShouldSerializeEastAsiaTheme() => EastAsiaTheme.HasValue;
  public bool ShouldSerializeComplexScriptTheme() => ComplexScriptTheme.HasValue;
}
