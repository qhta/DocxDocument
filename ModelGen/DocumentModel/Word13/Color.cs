namespace DocumentModel.Word13;


/// <summary>
///   This element specifies the color on which to base the visual elements of a structured document tag.
/// </summary>
public partial class Color
{
  
  /// <summary>
  ///   Run Content Color
  /// </summary>
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public String? ThemeShade { get; set; }
  
}
