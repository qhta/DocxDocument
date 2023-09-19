namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run should be displayed along with an underline appearing directly below the character height (less all spacing above and below the characters on the line).
/// </summary>
public partial class Underline
{
  
  /// <summary>
  ///   Underline Style
  /// </summary>
  [SchemaAttr("w:val")]
  public DocumentModel.Wordprocessing.UnderlineValues? Val { get; set; }
  
  
  /// <summary>
  ///   Underline Color
  /// </summary>
  [SchemaAttr("w:color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Underline Theme Color
  /// </summary>
  [SchemaAttr("w:themeColor")]
  public DocumentModel.Wordprocessing.ThemeColorValues? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   Underline Theme Color Tint
  /// </summary>
  [SchemaAttr("w:themeTint")]
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Underline Theme Color Shade
  /// </summary>
  [SchemaAttr("w:themeShade")]
  public String? ThemeShade { get; set; }
  
}
