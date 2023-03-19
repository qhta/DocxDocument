namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnHover Class.
/// </summary>
public class HyperlinkOnHover: ModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}