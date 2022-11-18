namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkSound))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkExtensionList))]
public interface IHyperlinkOnHover // : DocumentFormat.OpenXml.Drawing.HyperlinkType
{
  /// <summary>
  /// relationship identifier to find target URI
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  public string? InvalidUrl { get ; set; }
  
  /// <summary>
  /// Action to take, it may still need r:id to specify an action target
  /// </summary>
  public string? Action { get ; set; }
  
  /// <summary>
  /// target frame for navigating to the URI
  /// </summary>
  public string? TargetFrame { get ; set; }
  
  /// <summary>
  /// tooltip for display
  /// </summary>
  public string? Tooltip { get ; set; }
  
  /// <summary>
  /// whether to add this URI to the history when navigating to it
  /// </summary>
  public bool? History { get ; set; }
  
  /// <summary>
  /// Whether to highlight it when click on a shape
  /// </summary>
  public bool? HighlightClick { get ; set; }
  
  /// <summary>
  /// Whether to stop previous sound when click on it
  /// </summary>
  public bool? EndSound { get ; set; }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  public IHyperlinkSound? HyperlinkSound { get ; set; }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
