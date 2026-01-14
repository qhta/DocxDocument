namespace DocumentModel.Drawings;

/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is hovered over, including optional sound and extension data.
/// </summary>
public interface HyperlinkOnHover: ExtendableHyperlinkElement
{
  /// <summary>
  ///   Embedded sound to play when the hyperlink is activated on hover.
  /// </summary>
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
}