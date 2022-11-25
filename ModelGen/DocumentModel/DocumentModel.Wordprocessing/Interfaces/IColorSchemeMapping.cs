namespace DocumentModel.Wordprocessing;

/// <summary>
/// Theme Color Mappings.
/// </summary>
public interface IColorSchemeMapping // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? FollowedHyperlink { get ; set; }
  
}
