namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public interface IRunFonts // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Font Content Type
  /// </summary>
  public FontTypeHint? Hint { get ; set; }
  
  /// <summary>
  /// ASCII Font
  /// </summary>
  public string? Ascii { get ; set; }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  public string? HighAnsi { get ; set; }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  public string? EastAsia { get ; set; }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  public string? ComplexScript { get ; set; }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  public ThemeFont? AsciiTheme { get ; set; }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  public ThemeFont? HighAnsiTheme { get ; set; }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  public ThemeFont? EastAsiaTheme { get ; set; }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  public ThemeFont? ComplexScriptTheme { get ; set; }
  
}
