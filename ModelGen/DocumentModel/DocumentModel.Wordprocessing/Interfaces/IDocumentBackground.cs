namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.IBackground))]
public interface IDocumentBackground // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// color
  /// </summary>
  public string? Color { get ; set; }
  
  /// <summary>
  /// themeColor
  /// </summary>
  public ThemeColorValues? ThemeColor { get ; set; }
  
  /// <summary>
  /// themeTint
  /// </summary>
  public string? ThemeTint { get ; set; }
  
  /// <summary>
  /// themeShade
  /// </summary>
  public string? ThemeShade { get ; set; }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.IBackground? Background { get ; set; }
  
}
