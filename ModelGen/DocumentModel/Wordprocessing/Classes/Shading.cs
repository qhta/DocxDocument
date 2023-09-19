namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the shading applied to the contents of the paragraph.
/// </summary>
public partial class Shading
{
  
  /// <summary>
  ///   Shading Pattern
  /// </summary>
  [SchemaAttr("w:val")]
  public DocumentModel.Wordprocessing.ShadingPatternValues? Val { get; set; }
  
  
  /// <summary>
  ///   Shading Pattern Color
  /// </summary>
  [SchemaAttr("w:color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Shading Pattern Theme Color
  /// </summary>
  [SchemaAttr("w:themeColor")]
  public DocumentModel.Wordprocessing.ThemeColorValues? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   Shading Pattern Theme Color Tint
  /// </summary>
  [SchemaAttr("w:themeTint")]
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Shading Pattern Theme Color Shade
  /// </summary>
  [SchemaAttr("w:themeShade")]
  public String? ThemeShade { get; set; }
  
  
  /// <summary>
  ///   Shading Background Color
  /// </summary>
  [SchemaAttr("w:fill")]
  public String? Fill { get; set; }
  
  
  /// <summary>
  ///   Shading Background Theme Color
  /// </summary>
  [SchemaAttr("w:themeFill")]
  public DocumentModel.Wordprocessing.ThemeColorValues? ThemeFill { get; set; }
  
  
  /// <summary>
  ///   Shading Background Theme Color Tint
  /// </summary>
  [SchemaAttr("w:themeFillTint")]
  public String? ThemeFillTint { get; set; }
  
  
  /// <summary>
  ///   Shading Background Theme Color Shade
  /// </summary>
  [SchemaAttr("w:themeFillShade")]
  public String? ThemeFillShade { get; set; }
  
}
