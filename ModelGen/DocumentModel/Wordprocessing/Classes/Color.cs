namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the color which shall be used to display the contents of this run in the document.
/// </summary>
public partial class Color
{
  
  /// <summary>
  ///   Run Content Color
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  [SchemaAttr("w:themeColor")]
  public DocumentModel.Wordprocessing.ThemeColorValues? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  [SchemaAttr("w:themeTint")]
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  [SchemaAttr("w:themeShade")]
  public String? ThemeShade { get; set; }
  
}
