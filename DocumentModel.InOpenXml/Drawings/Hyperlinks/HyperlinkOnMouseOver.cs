namespace DocumentModel.Drawings;

/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is hovered over with the mouse, including optional sound data.
/// </summary>
public class HyperlinkOnMouseOver: ModelElement
{
  /// <summary>
  ///   Embedded sound to play when the hyperlink is activated on mouse over.
  /// </summary>
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
}