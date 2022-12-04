namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public class Shading
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
  public ShadingPatternKind? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  public ThemeColorKind? ThemeFill
  {
    get;
    set;
  }
  
}
