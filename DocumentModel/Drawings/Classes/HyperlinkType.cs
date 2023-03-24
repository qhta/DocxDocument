namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HyperlinkType Class.
/// </summary>
public class HyperlinkType: ModelElement
{
  /// <summary>
  ///   relationship identifier to find target URI
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  public String? InvalidUrl { get; set; }

  /// <summary>
  ///   Action to take, it may still need r:id to specify an action target
  /// </summary>
  public String? Action { get; set; }

  /// <summary>
  ///   target frame for navigating to the URI
  /// </summary>
  public String? TargetFrame { get; set; }

  /// <summary>
  ///   tooltip for display
  /// </summary>
  public String? Tooltip { get; set; }

  /// <summary>
  ///   whether to add this URI to the history when navigating to it
  /// </summary>
  public Boolean? History { get; set; }

  /// <summary>
  ///   Whether to highlight it when click on a shape
  /// </summary>
  public Boolean? HighlightClick { get; set; }

  /// <summary>
  ///   Whether to stop previous sound when click on it
  /// </summary>
  public Boolean? EndSound { get; set; }

  /// <summary>
  ///   Sound to play..
  /// </summary>
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  /// <summary>
  ///   Future extensions..
  /// </summary>
  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}