namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkType Class.
/// </summary>
public partial class HyperlinkType
{
  
  /// <summary>
  ///   relationship identifier to find target URI
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  [SchemaAttr("invalidUrl")]
  public String? InvalidUrl { get; set; }
  
  
  /// <summary>
  ///   Action to take, it may still need r:id to specify an action target
  /// </summary>
  [SchemaAttr("action")]
  public String? Action { get; set; }
  
  
  /// <summary>
  ///   target frame for navigating to the URI
  /// </summary>
  [SchemaAttr("tgtFrame")]
  public String? TargetFrame { get; set; }
  
  
  /// <summary>
  ///   tooltip for display
  /// </summary>
  [SchemaAttr("tooltip")]
  public String? Tooltip { get; set; }
  
  
  /// <summary>
  ///   whether to add this URI to the history when navigating to it
  /// </summary>
  [SchemaAttr("history")]
  public Boolean? History { get; set; }
  
  
  /// <summary>
  ///   Whether to highlight it when click on a shape
  /// </summary>
  [SchemaAttr("highlightClick")]
  public Boolean? HighlightClick { get; set; }
  
  
  /// <summary>
  ///   Whether to stop previous sound when click on it
  /// </summary>
  [SchemaAttr("endSnd")]
  public Boolean? EndSound { get; set; }
  
  
  /// <summary>
  ///   Sound to play..
  /// </summary>
  public DocumentModel.Drawings.EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
  
  
  /// <summary>
  ///   Future extensions..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
  
}
