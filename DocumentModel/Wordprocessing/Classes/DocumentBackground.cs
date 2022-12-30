namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public partial class DocumentBackground
{
  /// <summary>
  /// color
  /// </summary>
  public String? Color { get; set; }
  
  /// <summary>
  /// themeColor
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get; set; }
  
  /// <summary>
  /// themeTint
  /// </summary>
  public String? ThemeTint { get; set; }
  
  /// <summary>
  /// themeShade
  /// </summary>
  public String? ThemeShade { get; set; }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background { get; set; }
  
}
