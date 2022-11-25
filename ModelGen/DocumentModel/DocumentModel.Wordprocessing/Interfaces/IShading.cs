namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public interface IShading // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
  public DocumentModel.Wordprocessing.ShadingPatternKind? Val { get ; set; }
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  public System.String? ThemeTint { get ; set; }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  public System.String? ThemeShade { get ; set; }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  public System.String? Fill { get ; set; }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeFill { get ; set; }
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  public System.String? ThemeFillTint { get ; set; }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  public System.String? ThemeFillShade { get ; set; }
  
}
