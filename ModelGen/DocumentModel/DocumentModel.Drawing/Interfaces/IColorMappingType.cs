namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public interface IColorMappingType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Background 1
  /// </summary>
  public ColorSchemeIndexValues? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public ColorSchemeIndexValues? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public ColorSchemeIndexValues? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public ColorSchemeIndexValues? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public ColorSchemeIndexValues? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public ColorSchemeIndexValues? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public ColorSchemeIndexValues? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public ColorSchemeIndexValues? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public ColorSchemeIndexValues? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public ColorSchemeIndexValues? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public ColorSchemeIndexValues? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public ColorSchemeIndexValues? FollowedHyperlink { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
