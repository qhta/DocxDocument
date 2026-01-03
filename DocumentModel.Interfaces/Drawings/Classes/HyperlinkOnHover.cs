namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnHover interface.
/// </summary>
public interface HyperlinkOnHover: IModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}