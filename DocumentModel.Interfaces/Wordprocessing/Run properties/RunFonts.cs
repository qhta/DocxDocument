namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RunFonts Class.
/// </summary>
public class RunFonts: ITypedModelElement, IRunProperty
{
  /// <summary>
  ///   Font Content Type
  /// </summary>
  public FontTypeHintKind? Hint { get; set; }
  /// <summary>
  ///   ASCII Font
  /// </summary>
  public RunFont? Ascii { get; set; }
  /// <summary>
  ///   High ANSI Font
  /// </summary>
  public RunFont? Ansi { get; set; }
  /// <summary>
  ///   East Asian Font
  /// </summary>
  public RunFont? EastAsia { get; set; }
  /// <summary>
  ///   Complex Script Font
  /// </summary>
  public RunFont? ComplexScript { get; set; }
  ///// <summary>
  /////   ASCII Theme Font
  ///// </summary>
  //public ThemeFontKind? AsciiTheme { get; set; }
  ///// <summary>
  /////   High ANSI Theme Font
  ///// </summary>
  //public ThemeFontKind? HighAnsiTheme { get; set; }
  ///// <summary>
  /////   East Asian Theme Font
  ///// </summary>
  //public ThemeFontKind? EastAsiaTheme { get; set; }
  ///// <summary>
  /////   Complex Script Theme Font
  ///// </summary>
  //public ThemeFontKind? ComplexScriptTheme { get; set; }
}