namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the color which shall be used to display the contents of this run in the document.
/// </summary>
public partial class Color
{
  
  /// <summary>
  ///   Run Content Color
  /// </summary>
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public String? ThemeShade { get; set; }
  
}
