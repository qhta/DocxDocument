namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public interface IColor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  public ThemeColorValues? ThemeColor { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  public string? ThemeTint { get ; set; }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  public string? ThemeShade { get ; set; }
  
}
