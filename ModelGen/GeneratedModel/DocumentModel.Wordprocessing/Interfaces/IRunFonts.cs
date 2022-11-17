namespace DocumentModel.Wordprocessing;

public interface IRunFonts // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public FontTypeHint? Hint { get ; set; }

  public string? Ascii { get ; set; }

  public string? HighAnsi { get ; set; }

  public string? EastAsia { get ; set; }

  public string? ComplexScript { get ; set; }

  public ThemeFont? AsciiTheme { get ; set; }

  public ThemeFont? HighAnsiTheme { get ; set; }

  public ThemeFont? EastAsiaTheme { get ; set; }

  public ThemeFont? ComplexScriptTheme { get ; set; }

}
