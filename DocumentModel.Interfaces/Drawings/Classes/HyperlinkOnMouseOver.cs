namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkOnMouseOver interface.
/// </summary>
public interface HyperlinkOnMouseOver: IModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}