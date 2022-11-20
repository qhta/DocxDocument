namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public class Shading: IShading
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
  public ShadingPatternValues? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  public string? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  public ThemeColorValues? ThemeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  public string? ThemeTint
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  public string? ThemeShade
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  public string? Fill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  public ThemeColorValues? ThemeFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  public string? ThemeFillTint
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  public string? ThemeFillShade
  {
    get;
    set;
  }
  
}
