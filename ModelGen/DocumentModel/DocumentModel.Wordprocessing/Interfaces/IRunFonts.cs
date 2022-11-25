namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public interface IRunFonts // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Font Content Type
  /// </summary>
  public DocumentModel.Wordprocessing.FontTypeHintKind? Hint { get ; set; }
  
  /// <summary>
  /// ASCII Font
  /// </summary>
  public System.String? Ascii { get ; set; }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  public System.String? HighAnsi { get ; set; }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  public System.String? EastAsia { get ; set; }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  public System.String? ComplexScript { get ; set; }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? AsciiTheme { get ; set; }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? HighAnsiTheme { get ; set; }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? EastAsiaTheme { get ; set; }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeFontKind? ComplexScriptTheme { get ; set; }
  
}
