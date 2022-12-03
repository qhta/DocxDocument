namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public interface HyperlinkOnMouseOver // : DocumentModel.Drawings.HyperlinkType
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public HyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
