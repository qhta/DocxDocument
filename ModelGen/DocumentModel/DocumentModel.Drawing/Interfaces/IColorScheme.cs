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
  public DocumentModel.Drawing.IColor2Type? Dark1Color { get ; set; }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Light1Color { get ; set; }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Dark2Color { get ; set; }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Light2Color { get ; set; }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Accent1Color { get ; set; }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Accent2Color { get ; set; }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Accent3Color { get ; set; }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Accent4Color { get ; set; }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Accent5Color { get ; set; }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Accent6Color { get ; set; }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public DocumentModel.Drawing.IColor2Type? FollowedHyperlinkColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
