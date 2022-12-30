namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public partial class Shading
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
  public DocumentModel.Wordprocessing.ShadingPatternKind? Val { get; set; }
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  public String? Color { get; set; }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get; set; }
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  public String? ThemeTint { get; set; }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  public String? ThemeShade { get; set; }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  public String? Fill { get; set; }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeFill { get; set; }
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  public String? ThemeFillTint { get; set; }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  public String? ThemeFillShade { get; set; }
  
}
