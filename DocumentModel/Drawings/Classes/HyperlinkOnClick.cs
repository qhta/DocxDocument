namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnClick Class.
/// </summary>
public record HyperlinkOnClick
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}