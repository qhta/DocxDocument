namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorMapOverride Class.
/// </summary>
public interface IColorMapOverride // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Background 1
  /// </summary>
  public ColorSchemeIndexKind? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public ColorSchemeIndexKind? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public ColorSchemeIndexKind? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public ColorSchemeIndexKind? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public ColorSchemeIndexKind? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public ColorSchemeIndexKind? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public ColorSchemeIndexKind? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public ColorSchemeIndexKind? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public ColorSchemeIndexKind? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public ColorSchemeIndexKind? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public ColorSchemeIndexKind? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public ColorSchemeIndexKind? FollowedHyperlink { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
