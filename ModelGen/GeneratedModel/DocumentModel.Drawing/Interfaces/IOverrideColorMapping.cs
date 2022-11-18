namespace DocumentModel.Drawing;

/// <summary>
/// Override Color Mapping.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IOverrideColorMapping // : DocumentFormat.OpenXml.Drawing.ColorMappingType
{
  /// <summary>
  /// Background 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndex? FollowedHyperlink { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
