namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public interface IColorMappingType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Background 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexKind? FollowedHyperlink { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
