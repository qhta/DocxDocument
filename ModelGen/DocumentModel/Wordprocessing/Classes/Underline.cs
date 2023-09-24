namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run should be displayed along with an underline appearing directly below the character height (less all spacing above and below the characters on the line).
/// </summary>
public partial class Underline
{
  
  /// <summary>
  ///   Underline Style
  /// </summary>
  public UnderlineKind? Val { get; set; }
  
  
  /// <summary>
  ///   Underline Color
  /// </summary>
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Underline Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   Underline Theme Color Tint
  /// </summary>
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Underline Theme Color Shade
  /// </summary>
  public String? ThemeShade { get; set; }
  
}
