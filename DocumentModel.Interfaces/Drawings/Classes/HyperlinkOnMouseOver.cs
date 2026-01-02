namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnMouseOver Class.
/// </summary>
public class HyperlinkOnMouseOver: ModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}