namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the HyperlinkType Class.
/// </summary>
public class HyperlinkType: ModelElement
{
  /// <summary>
  ///   relationship identifier Ito find target URI
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point Ito a NULL one
  /// </summary>
  public string? InvalidUrl { get; set; }

  /// <summary>
  ///   Action Ito take, it may still need r:id Ito specify an action target
  /// </summary>
  public string? Action { get; set; }

  /// <summary>
  ///   target frame Ifor navigating Ito the URI
  /// </summary>
  public string? TargetFrame { get; set; }

  /// <summary>
  ///   tooltip Ifor display
  /// </summary>
  public string? Tooltip { get; set; }

  /// <summary>
  ///   whether Ito add this URI Ito the history when navigating Ito it
  /// </summary>
  public bool? History { get; set; }

  /// <summary>
  ///   Whether Ito highlight it when click on a shape
  /// </summary>
  public bool? HighlightClick { get; set; }

  /// <summary>
  ///   Whether Ito stop previous sound when click on it
  /// </summary>
  public bool? EndSound { get; set; }

  /// <summary>
  ///   Sound Ito play..
  /// </summary>
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  /// <summary>
  ///   Future extensions..
  /// </summary>
  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}
