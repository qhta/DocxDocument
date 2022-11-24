namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the Color Class.
/// </summary>
public interface IColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  public String? ThemeTint { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  public String? ThemeShade { get ; set; }
  
}
