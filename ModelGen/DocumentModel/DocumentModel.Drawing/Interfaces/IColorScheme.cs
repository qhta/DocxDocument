namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public interface IColorScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  public DocumentModel.Drawing.IDark1Color? Dark1Color { get ; set; }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public DocumentModel.Drawing.ILight1Color? Light1Color { get ; set; }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public DocumentModel.Drawing.IDark2Color? Dark2Color { get ; set; }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public DocumentModel.Drawing.ILight2Color? Light2Color { get ; set; }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public DocumentModel.Drawing.IAccent1Color? Accent1Color { get ; set; }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public DocumentModel.Drawing.IAccent2Color? Accent2Color { get ; set; }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public DocumentModel.Drawing.IAccent3Color? Accent3Color { get ; set; }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public DocumentModel.Drawing.IAccent4Color? Accent4Color { get ; set; }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public DocumentModel.Drawing.IAccent5Color? Accent5Color { get ; set; }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public DocumentModel.Drawing.IAccent6Color? Accent6Color { get ; set; }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public DocumentModel.Drawing.IHyperlink? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public DocumentModel.Drawing.IFollowedHyperlinkColor? FollowedHyperlinkColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
