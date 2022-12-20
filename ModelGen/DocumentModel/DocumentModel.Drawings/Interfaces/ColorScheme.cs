namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public partial interface ColorScheme
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  public DocumentModel.Drawings.Dark1Color? Dark1Color { get; set; }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public DocumentModel.Drawings.Light1Color? Light1Color { get; set; }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public DocumentModel.Drawings.Dark2Color? Dark2Color { get; set; }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public DocumentModel.Drawings.Light2Color? Light2Color { get; set; }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public DocumentModel.Drawings.Accent1Color? Accent1Color { get; set; }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public DocumentModel.Drawings.Accent2Color? Accent2Color { get; set; }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public DocumentModel.Drawings.Accent3Color? Accent3Color { get; set; }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public DocumentModel.Drawings.Accent4Color? Accent4Color { get; set; }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public DocumentModel.Drawings.Accent5Color? Accent5Color { get; set; }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public DocumentModel.Drawings.Accent6Color? Accent6Color { get; set; }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public DocumentModel.Drawings.Hyperlink? Hyperlink { get; set; }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public DocumentModel.Drawings.FollowedHyperlinkColor? FollowedHyperlinkColor { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
