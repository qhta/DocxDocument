namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the fonts which shall be used to display the text contents of this run. Within a single run, there can be up to four types of font slot which shall each be allowed to use a unique font:
/// </summary>
public partial class RunFonts
{
  
  /// <summary>
  ///   Font Content Type
  /// </summary>
  [SchemaAttr("w:hint")]
  public DocumentModel.Wordprocessing.FontTypeHintValues? Hint { get; set; }
  
  
  /// <summary>
  ///   ASCII Font
  /// </summary>
  [SchemaAttr("w:ascii")]
  public String? Ascii { get; set; }
  
  
  /// <summary>
  ///   High ANSI Font
  /// </summary>
  [SchemaAttr("w:hAnsi")]
  public String? HighAnsi { get; set; }
  
  
  /// <summary>
  ///   East Asian Font
  /// </summary>
  [SchemaAttr("w:eastAsia")]
  public String? EastAsia { get; set; }
  
  
  /// <summary>
  ///   Complex Script Font
  /// </summary>
  [SchemaAttr("w:cs")]
  public String? ComplexScript { get; set; }
  
  
  /// <summary>
  ///   ASCII Theme Font
  /// </summary>
  [SchemaAttr("w:asciiTheme")]
  public DocumentModel.Wordprocessing.ThemeFontValues? AsciiTheme { get; set; }
  
  
  /// <summary>
  ///   High ANSI Theme Font
  /// </summary>
  [SchemaAttr("w:hAnsiTheme")]
  public DocumentModel.Wordprocessing.ThemeFontValues? HighAnsiTheme { get; set; }
  
  
  /// <summary>
  ///   East Asian Theme Font
  /// </summary>
  [SchemaAttr("w:eastAsiaTheme")]
  public DocumentModel.Wordprocessing.ThemeFontValues? EastAsiaTheme { get; set; }
  
  
  /// <summary>
  ///   Complex Script Theme Font
  /// </summary>
  [SchemaAttr("w:cstheme")]
  public DocumentModel.Wordprocessing.ThemeFontValues? ComplexScriptTheme { get; set; }
  
}
