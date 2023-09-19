namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of colors which are referred to as a color scheme.  The color scheme is responsible for defining a list of twelve colors.  The twelve colors consist of six accent colors, two dark colors, two light colors and a color for each of a hyperlink and followed hyperlink.
/// </summary>
public partial class ColorScheme
{
  
  /// <summary>
  ///   The common name for this color scheme.  This name can show up in the user interface in a list of color schemes.
  /// </summary>
  [SchemaAttr("name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Dark 1.
  /// </summary>
  public DocumentModel.Drawings.Dark1Color? Dark1Color { get; set; }
  
  
  /// <summary>
  ///   Light 1.
  /// </summary>
  public DocumentModel.Drawings.Light1Color? Light1Color { get; set; }
  
  
  /// <summary>
  ///   Dark 2.
  /// </summary>
  public DocumentModel.Drawings.Dark2Color? Dark2Color { get; set; }
  
  
  /// <summary>
  ///   Light 2.
  /// </summary>
  public DocumentModel.Drawings.Light2Color? Light2Color { get; set; }
  
  
  /// <summary>
  ///   Accent 1.
  /// </summary>
  public DocumentModel.Drawings.Accent1Color? Accent1Color { get; set; }
  
  
  /// <summary>
  ///   Accent 2.
  /// </summary>
  public DocumentModel.Drawings.Accent2Color? Accent2Color { get; set; }
  
  
  /// <summary>
  ///   Accent 3.
  /// </summary>
  public DocumentModel.Drawings.Accent3Color? Accent3Color { get; set; }
  
  
  /// <summary>
  ///   Accent 4.
  /// </summary>
  public DocumentModel.Drawings.Accent4Color? Accent4Color { get; set; }
  
  
  /// <summary>
  ///   Accent 5.
  /// </summary>
  public DocumentModel.Drawings.Accent5Color? Accent5Color { get; set; }
  
  
  /// <summary>
  ///   Accent 6.
  /// </summary>
  public DocumentModel.Drawings.Accent6Color? Accent6Color { get; set; }
  
  
  /// <summary>
  ///   Hyperlink.
  /// </summary>
  public DocumentModel.Drawings.Hyperlink? Hyperlink { get; set; }
  
  
  /// <summary>
  ///   Followed Hyperlink.
  /// </summary>
  public DocumentModel.Drawings.FollowedHyperlinkColor? FollowedHyperlinkColor { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
