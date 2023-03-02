namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the RunFonts Class.
/// </summary>
public record RunFonts
{
  /// <summary>
  ///   Font Content Type
  /// </summary>
  public FontTypeHintKind? Hint { get; set; }

  /// <summary>
  ///   ASCII Font
  /// </summary>
  public String? Ascii { get; set; }

  /// <summary>
  ///   High ANSI Font
  /// </summary>
  public String? HighAnsi { get; set; }

  /// <summary>
  ///   East Asian Font
  /// </summary>
  public String? EastAsia { get; set; }

  /// <summary>
  ///   Complex Script Font
  /// </summary>
  public String? ComplexScript { get; set; }

  /// <summary>
  ///   ASCII Theme Font
  /// </summary>
  public ThemeFontKind? AsciiTheme { get; set; }

  /// <summary>
  ///   High ANSI Theme Font
  /// </summary>
  public ThemeFontKind? HighAnsiTheme { get; set; }

  /// <summary>
  ///   East Asian Theme Font
  /// </summary>
  public ThemeFontKind? EastAsiaTheme { get; set; }

  /// <summary>
  ///   Complex Script Theme Font
  /// </summary>
  public ThemeFontKind? ComplexScriptTheme { get; set; }
}