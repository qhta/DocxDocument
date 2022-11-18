namespace DocumentModel.Wordprocessing;

/// <summary>
/// Theme Color Mappings.
/// </summary>
public interface IColorSchemeMapping // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndex? FollowedHyperlink { get ; set; }
  
}
