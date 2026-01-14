namespace DocumentModel.Drawings;

/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is clicked, including optional sound and extension data.
/// </summary>
public interface HyperlinkOnClick: ExtendableHyperlinkElement
{
  /// <summary>
  ///   Embedded sound to play when the hyperlink is activated.
  /// </summary>
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
}