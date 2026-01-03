namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnClick interface.
/// </summary>
public interface HyperlinkOnClick: IModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}