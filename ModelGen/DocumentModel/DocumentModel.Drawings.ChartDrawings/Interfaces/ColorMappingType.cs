namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public partial interface ColorMappingType
{
  /// <summary>
  /// Background 1
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Background1 { get; set; }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Text1 { get; set; }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Background2 { get; set; }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Text2 { get; set; }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent1 { get; set; }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent2 { get; set; }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent3 { get; set; }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent4 { get; set; }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent5 { get; set; }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent6 { get; set; }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Hyperlink { get; set; }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? FollowedHyperlink { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
