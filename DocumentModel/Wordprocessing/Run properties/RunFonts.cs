namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the RunFonts Class.
/// </summary>
public class RunFonts: TypedModelElement, IRunProperty
{
  /// <summary>
  ///   IFont Content Type
  /// </summary>
  public FontTypeHintKind? Hint { get; set; }

  /// <summary>
  ///   ASCII IFont
  /// </summary>
  public RunFont? Ascii { get; set; }

  /// <summary>
  ///   High ANSI IFont
  /// </summary>
  public RunFont? Ansi { get; set; }

  /// <summary>
  ///   East Asian IFont
  /// </summary>
  public RunFont? EastAsia { get; set; }

  /// <summary>
  ///   Complex Script IFont
  /// </summary>
  public RunFont? ComplexScript { get; set; }

  ///// <summary>
  /////   ASCII Theme IFont
  ///// </summary>
  //public ThemeFontKind? AsciiTheme { get; set; }

  ///// <summary>
  /////   High ANSI Theme IFont
  ///// </summary>
  //public ThemeFontKind? HighAnsiTheme { get; set; }

  ///// <summary>
  /////   East Asian Theme IFont
  ///// </summary>
  //public ThemeFontKind? EastAsiaTheme { get; set; }

  ///// <summary>
  /////   Complex Script Theme IFont
  ///// </summary>
  //public ThemeFontKind? ComplexScriptTheme { get; set; }
}
