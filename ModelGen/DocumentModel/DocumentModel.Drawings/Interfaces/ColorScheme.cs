namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public interface ColorScheme
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  public Dark1Color? Dark1Color { get ; set; }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public Light1Color? Light1Color { get ; set; }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public Dark2Color? Dark2Color { get ; set; }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public Light2Color? Light2Color { get ; set; }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public Accent1Color? Accent1Color { get ; set; }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public Accent2Color? Accent2Color { get ; set; }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public Accent3Color? Accent3Color { get ; set; }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public Accent4Color? Accent4Color { get ; set; }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public Accent5Color? Accent5Color { get ; set; }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public Accent6Color? Accent6Color { get ; set; }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public Hyperlink? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public FollowedHyperlinkColor? FollowedHyperlinkColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
