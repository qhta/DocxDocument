namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public interface IDocumentBackground // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// themeColor
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// themeTint
  /// </summary>
  public System.String? ThemeTint { get ; set; }
  
  /// <summary>
  /// themeShade
  /// </summary>
  public System.String? ThemeShade { get ; set; }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.IBackground? Background { get ; set; }
  
}
