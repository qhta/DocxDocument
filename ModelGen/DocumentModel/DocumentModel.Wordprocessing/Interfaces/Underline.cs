namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public interface Underline
{
  /// <summary>
  /// Underline Style
  /// </summary>
  public DocumentModel.Wordprocessing.UnderlineKind? Val { get ; set; }
  
  /// <summary>
  /// Underline Color
  /// </summary>
  public String? Color { get ; set; }
  
  /// <summary>
  /// Underline Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Underline Theme Color Tint
  /// </summary>
  public String? ThemeTint { get ; set; }
  
  /// <summary>
  /// Underline Theme Color Shade
  /// </summary>
  public String? ThemeShade { get ; set; }
  
}
