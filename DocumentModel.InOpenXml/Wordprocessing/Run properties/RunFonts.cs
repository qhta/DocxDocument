namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents font selection and theme font mapping for a text run in WordprocessingML documents.
  /// This interface enables specification of font names and theme fonts for ASCII, High ANSI, East Asian, and complex script character ranges, as well as font type hints for advanced font selection and rendering.
  /// </summary>
  public class RunFonts : RunProperty
  {
    
    /// <summary>
    /// Font content type hint, specifying the intended use or type of the font (e.g., default, East Asian, complex script).
    /// </summary>
    public FontTypeHintKind? Hint { get; set; }
    
    /// <summary>
    /// Font information for ASCII characters (first 128 Unicode code points).
    /// </summary>
    public RunFont? Ascii { get; set; }
    
    /// <summary>
    /// Font information for High ANSI characters (extended Latin and other Western scripts).
    /// </summary>
    public RunFont? Ansi { get; set; }
    
    /// <summary>
    /// Font information for East Asian characters (Chinese, Japanese, Korean, etc.).
    /// </summary>
    public RunFont? EastAsia { get; set; }
    
    /// <summary>
    /// Font information for complex script characters (Arabic, Hebrew, Thai, etc.).
    /// </summary>
    public RunFont? ComplexScript { get; set; }
    
    /// <summary>
    /// Theme font for ASCII characters, enabling theme-based font selection for ASCII text.
    /// </summary>
    public ThemeFontKind? AsciiTheme { get; set; }
    
    /// <summary>
    /// Theme font for High ANSI characters, enabling theme-based font selection for extended Latin and Western scripts.
    /// </summary>
    public ThemeFontKind? HighAnsiTheme { get; set; }
    
    /// <summary>
    /// Theme font for East Asian characters, enabling theme-based font selection for CJK scripts.
    /// </summary>
    public ThemeFontKind? EastAsiaTheme { get; set; }
    
    /// <summary>
    /// Theme font for complex script characters, enabling theme-based font selection for bidirectional and complex scripts.
    /// </summary>
    public ThemeFontKind? ComplexScriptTheme { get; set; }
  }