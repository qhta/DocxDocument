namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public interface IUnderline // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Underline Style
  /// </summary>
  public DocumentModel.Wordprocessing.UnderlineValues? Val { get ; set; }
  
  /// <summary>
  /// Underline Color
  /// </summary>
  public string? Color { get ; set; }
  
  /// <summary>
  /// Underline Theme Color
  /// </summary>
  public ThemeColorValues? ThemeColor { get ; set; }
  
  /// <summary>
  /// Underline Theme Color Tint
  /// </summary>
  public string? ThemeTint { get ; set; }
  
  /// <summary>
  /// Underline Theme Color Shade
  /// </summary>
  public string? ThemeShade { get ; set; }
  
}
