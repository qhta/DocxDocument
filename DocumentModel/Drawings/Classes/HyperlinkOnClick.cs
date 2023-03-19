namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnClick Class.
/// </summary>
public class HyperlinkOnClick: ModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}