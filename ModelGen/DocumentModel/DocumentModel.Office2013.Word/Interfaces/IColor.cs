namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the Color Class.
/// </summary>
public interface IColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  public System.String? ThemeTint { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  public System.String? ThemeShade { get ; set; }
  
}
