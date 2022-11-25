namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public interface IHyperlinkType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// relationship identifier to find target URI
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  public System.String? InvalidUrl { get ; set; }
  
  /// <summary>
  /// Action to take, it may still need r:id to specify an action target
  /// </summary>
  public System.String? Action { get ; set; }
  
  /// <summary>
  /// target frame for navigating to the URI
  /// </summary>
  public System.String? TargetFrame { get ; set; }
  
  /// <summary>
  /// tooltip for display
  /// </summary>
  public System.String? Tooltip { get ; set; }
  
  /// <summary>
  /// whether to add this URI to the history when navigating to it
  /// </summary>
  public System.Boolean? History { get ; set; }
  
  /// <summary>
  /// Whether to highlight it when click on a shape
  /// </summary>
  public System.Boolean? HighlightClick { get ; set; }
  
  /// <summary>
  /// Whether to stop previous sound when click on it
  /// </summary>
  public System.Boolean? EndSound { get ; set; }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  public DocumentModel.Drawing.IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? HyperlinkExtensionList { get ; set; }
  
}
