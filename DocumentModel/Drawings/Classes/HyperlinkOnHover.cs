namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnHover Class.
/// </summary>
public record HyperlinkOnHover
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}